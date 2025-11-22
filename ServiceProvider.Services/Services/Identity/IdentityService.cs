
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using ServiceProvider.Core.Settings;
using PrismBenefits.Core.Interfaces.Services.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using ServiceProvider.Core.Extensions;

namespace ServiceProvider.Services;

public class IdentityService : IIdentityService
{
	private readonly IIdentityRepository _repository;
	private readonly IJwtTokenHandlerService _jwtTokenHandler;
	public IdentityService(IIdentityRepository repository, IJwtTokenHandlerService jwtTokenHandler)
	{
		_repository = repository;
		_jwtTokenHandler = jwtTokenHandler;
	}

	public async Task<UserProfile?> GetUserProfileAsync(Guid userId)
	{
		var user = await _repository.GetUserProfileAsync(userId);
		return user;
	}

	public async Task<User> AddDevUserAsync()
	{
		var user = new User
		{
			Id = Guid.NewGuid(),
			Email = "dev@dev.com",
			FirstName = "Dev",
			LastName = "User",
			Password = "DevPassword123!",
			RoleId = new Guid("dc8ec90f-0260-47f5-9c71-4f8cf3861d96") ,
			AccessLevel = Core.Enums.UserAccessLevel.SuperAdmin,
			IsActive = true
		};

		// Hash the default password before saving
		user.Password = user.Password.HashPassword();

		var devuser = await _repository.AddDevUserAsync(user);
		return devuser;
	}

	public async Task<bool> IsUserActiveAsync(Guid userId)
	{
		var status = await _repository.GetUserStatusAsync(userId);

		// user not found
		// user not active
		// user deleted
		if (status == null || !status.IsActive)
			return false;

		// user is active
		return true;
	}

	public async Task<string?> LoginAsync(string email, string password)
	{
		var user = await _repository.GetUserByEmailAsync(email);
		if (user == null || !user.IsActive)
			return null;

		// Verify the password hash
		var passwordVerificationResult = password.VerifyPassword(user.Password);
		if (!passwordVerificationResult)
			return null;

		var claims = new[]
		{
			new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
			new Claim(JwtRegisteredClaimNames.Email, user.Email),
			new Claim(JwtRegisteredClaimNames.GivenName, user.FirstName),
			new Claim(JwtRegisteredClaimNames.FamilyName, user.LastName),
			new Claim("role", user.Role?.Name ?? "User"),
			new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
		};

		return _jwtTokenHandler.GenerateToken(
			claims,
			AppSettings.ServiceProviderJwt.ValidIssuer,
			AppSettings.ServiceProviderJwt.ValidAudiences.FirstOrDefault() ?? "",
			AppSettings.ServiceProviderJwt.IssuerSigningKey,
			DateTime.Now.AddHours(1));
	}
}