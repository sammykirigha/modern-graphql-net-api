using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.WebApi.Admin.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
	private readonly IUserProfileService _userProfileService;
	private readonly IIdentityService _identityService;
	private readonly IWebHostEnvironment _environment;

	public AuthController(
		IUserProfileService userProfileService,
		IIdentityService identityService,
		IWebHostEnvironment environment
	)
	{
		_userProfileService = userProfileService;
		_identityService = identityService;
		_environment = environment;
	}

	[HttpPost("AddDevUser")]
	public async Task<IActionResult> AddDevUser()
	{
		if (!_environment.IsDevelopment() && !_environment.IsStaging())
		{
			return Forbid();
		}

		var user = await _identityService.AddDevUserAsync();
		return Ok(user);
	}

	[Authorize]
	[HttpGet("GetUserInfo")]
	public async Task<UserProfile> GetUserInfo()
	{
		var user = await _userProfileService.GetUserProfileAsync();
		return user;
	}

	[AllowAnonymous]
	[HttpPost("Login")]
	public async Task<IActionResult> Login([FromBody] LoginRequest request)
	{
		var token = await _identityService.LoginAsync(request.Email, request.Password);
		// if (token == null)
		// 	return Unauthorized("Invalid credentials try again");

		return Ok(new { Token = token });
	}
}

public class LoginRequest
{
	public string Email { get; set; } = "";
	public string Password { get; set; } = "";
}
