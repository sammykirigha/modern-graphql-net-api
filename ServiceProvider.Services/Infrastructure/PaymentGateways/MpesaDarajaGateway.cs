using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using ServiceProvider.Core.DTOs.Payment;
using ServiceProvider.Core.Interfaces.Services.PaymentStrategy;
using ServiceProvider.Core.Models.Mpesa;
using ServiceProvider.Core.Settings;
using ServiceProvider.Services.Infrastructure.MPesaServices;

namespace ServiceProvider.Services.Infrastructure;

public class MpesaDarajaGateway : IPaymentStrategy
{
	private readonly MPesaSettings _mpesaSettings;
	
	public MpesaDarajaGateway(IOptions<MPesaSettings> mpesaSettings)
	{ 
		_mpesaSettings = mpesaSettings.Value;
	}
	
	public async Task ProcessPayment( PaymentDto paymentDto)
	{
		var gateway =  new DarajaGateway( Options.Create(_mpesaSettings));
		var darajaClient =  await gateway.GetDarajaClientAsync(_mpesaSettings.InProduction);

		if (darajaClient == null)
			return;

		await ProcessPaymentStatic(gateway, paymentDto.Receiver,  paymentDto.Amount, darajaClient);
	}
	
	public static  async Task ProcessPaymentStatic(DarajaGateway darajaGateway, long receiver, float amount, DarajaClient darajaClient)
	{
		Console.WriteLine("Receiver for the stk push");

		var stkRequestBody= new StkRequestBody()
		{
			BusinessShortCode = 174379,
			TransactionType = "CustomerPayBillOnline",
			Amount = amount,
			PartyA = 600999,
			PartyB = 174379,
			PhoneNumber = receiver,
			CallBackUrl = new Uri("https://mydomain.com/path"),
			AccountReference = "CompanyXLTD",
			TransactionDesc = "Payment of X"
		};
		
		stkRequestBody.Password = darajaGateway.GetStkPushPassword(stkRequestBody.BusinessShortCode,
			DateTime.Now.ToString("yyyyMMddHHmmss"));
		
		var pushResponse  = await darajaClient.SendStkPushAsync(stkRequestBody);
		
		Console.WriteLine(JsonConvert.SerializeObject(pushResponse, Formatting.Indented));
		if (pushResponse is null) { return; }
		
		var isCompleted = false;
		
		while (!isCompleted)
		{
			var (completed, pushQueryResponse) = await darajaClient.QueryStkPushStatus(pushResponse, stkRequestBody);
			isCompleted = completed;
			if (pushQueryResponse is not null)
			{
				Console.WriteLine(JsonConvert.SerializeObject(pushQueryResponse, Formatting.Indented));
			}
			if (!isCompleted)
			{
				Console.WriteLine("Waiting for 5 seconds before next status check...");
				await Task.Delay(5000); // Wait for 5 seconds before the next check
			}
		}
	}
}