using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Settings;
using System.Net.Http.Headers;
using System.Text;

namespace ServiceProvider.Services.Infrastructure.MPesaServices;

public class DarajaGateway
{
	    private readonly MPesaSettings _mpesaSettings;
		private string EndPoint { get; set; }
        public DarajaGateway( IOptions<MPesaSettings> mpesaSettings)
        {
	        _mpesaSettings = mpesaSettings.Value;
	        
            EndPoint = _mpesaSettings.InProduction
                ? $"https://api.safaricom.co.ke/oauth/v1/generate"
                : $"https://sandbox.safaricom.co.ke/mpesa/c2b/v2/registerurl";
        }

        public async Task<DarajaClient?> GetDarajaClientAsync(bool isInProduction)
        {
            var client=new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_mpesaSettings.ConsumerKey}:{_mpesaSettings.ConsumerSecret}")));

            var response = await client.GetAsync($"{EndPoint}?grant_type={_mpesaSettings.GrantType}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                if (!string.IsNullOrEmpty(content))
                {
                    var data = JsonConvert.DeserializeObject<dynamic>(content);

                    string accessToken = data?["access_token"].ToString() ?? throw new InvalidOperationException();
                    long expiresIn = data?["expires_in"];


                    return new DarajaClient(accessToken, expiresIn, isInProduction);
                }


                return null;
            }

            // handle when status code is not success
            throw new AppException(await response.Content.ReadAsStringAsync());

        }

        /// <inheritdoc />
        public string GetStkPushPassword(long shortCode, string timestamp) =>
            Convert.ToBase64String(Encoding.UTF8.GetBytes($"{shortCode}{_mpesaSettings.PassKey}{timestamp}"));


        /// <inheritdoc />
        public Task<DarajaClient?> RefreshTokenAsync()
        {
            throw new AppException();
        }

        /// <inheritdoc />
        public bool IsTokenValid(string token)
        {
            throw new AppException();
        }


}