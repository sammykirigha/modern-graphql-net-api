using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using ServiceProvider.Core.Interfaces.Services;

namespace ServiceProvider.Services;

public class ClaimsUserService : IClaimsUserService
{
	private readonly IHttpContextAccessor _accessor;
    
	public ClaimsUserService(IHttpContextAccessor accessor)
	{
		_accessor = accessor;
	}
    
	public Guid GetContextUserId()
	{
		var sub = _accessor.HttpContext?.User.FindFirst("sub")?.Value;

        if (string.IsNullOrEmpty(sub))
        {
           sub = _accessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value; 
        }

		return Guid.TryParse(sub, out var id) ? id : Guid.Empty;
	}

	public ClaimsPrincipal? GetContextUser()
	{
		return _accessor.HttpContext?.User;
	}
}