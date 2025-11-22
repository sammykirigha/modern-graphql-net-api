using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace PrismBenefits.Core.Interfaces.Services.Identity;

public interface IJwtTokenHandlerService
{
	Task<TokenValidationResult> ValidateToken(string token, string validIssuer, string[] validAudiences, string key);
	string GenerateToken(IEnumerable<Claim> claims, string issuer, string audience, string key, DateTime expires);
}