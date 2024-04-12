using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using PrismBenefits.Core.Interfaces.Services.Identity;
using System.Text;

namespace ServiceProvider.Services;

public class JwtTokenHandlerService : IJwtTokenHandlerService
{
	public async Task<TokenValidationResult> ValidateToken(string token, string validIssuer, string[] validAudiences,
		string key)
	{
		var validationParameters = new TokenValidationParameters
		{
			ValidateIssuer = true,
			ValidIssuer = validIssuer,
			ValidateAudience = true,
			ValidAudiences = validAudiences,
			ValidateIssuerSigningKey = true,
			IssuerSigningKey =
				new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
			ValidateLifetime = true,
			ClockSkew = TimeSpan.Zero
		};

		var tokenHandler = new JsonWebTokenHandler();
		return await tokenHandler.ValidateTokenAsync(token, validationParameters);
	}
}