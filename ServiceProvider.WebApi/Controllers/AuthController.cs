using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.WebApi.Admin.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
	private readonly IUserProfileService _service;
	private readonly IWebHostEnvironment _environment;

	public AuthController(
		IUserProfileService service,
		IWebHostEnvironment environment
	)
	{
		_service = service;
		_environment = environment;
	}

	[Authorize]
	[HttpGet("AddDevUser")]
	public async Task<IActionResult> AddDevUser()
	{
		if (!_environment.IsDevelopment() && !_environment.IsStaging())
		{
			return Forbid();
		}

		var user = await _service.AddDevUserAsync();
		return Ok(user);
	}

	[Authorize]
	[HttpGet("GetUserInfo")]
	public async Task<UserProfile> GetUserInfo()
	{
		var user = await _service.GetUserProfileAsync();
		return user;
	}
}
