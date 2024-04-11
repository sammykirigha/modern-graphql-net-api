using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using ServiceProvider.Core.Interfaces.Services;
using Microsoft.Identity.Web;
using ServiceProvider.Core.Extensions;

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
		return _accessor.HttpContext?.User.GetObjectId().ToGuid() ?? Guid.Empty;
	}

	public ClaimsPrincipal? GetContextUser()
	{
		return _accessor.HttpContext?.User;
	}
}