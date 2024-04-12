using Microsoft.IdentityModel.Tokens;

namespace PrismBenefits.Core.Interfaces.Services.Identity;

public interface IJwtTokenHandlerService
{
	Task<TokenValidationResult> ValidateToken(string token, string validIssuer, string[] validAudiences, string key);
}