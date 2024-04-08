using System.Security.Claims;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IClaimsUserService
{
	Guid GetContextUserId();
    
	ClaimsPrincipal? GetContextUser();
}