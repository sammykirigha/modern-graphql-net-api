using Microsoft.EntityFrameworkCore;
using PrismBenefits.Core.Interfaces.Services.Identity;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using ServiceProvider.Core.Settings;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ServiceProvider.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _user_repository;
    private readonly IRoleRepository _role_repository;
    private readonly IJwtTokenHandlerService _jwtTokenHandler;
    private readonly IEntityLogService _log;

    public UserService(
        IUserRepository user_repository, IRoleRepository role_repository,IJwtTokenHandlerService jwtTokenHandler,
        IEntityLogService log)
    {
        _user_repository = user_repository;
        _jwtTokenHandler = jwtTokenHandler;
        _role_repository = role_repository;
        _log = log;
    }

    // QUERIES
    public async Task<User?> GetByIdAsync(Guid id)
    {
        var entity = await _user_repository.GetByIdAsync(id);
        return entity;
    }

    public IQueryable<User> GetList()
    {
        return _user_repository.GetList().AsNoTracking();
    }

    public IQueryable<UserPaged> GetListPaged()
    {
        return (
            from u in _user_repository.GetList()
            select new UserPaged
            {
                User = u
            }
        ).AsNoTracking();
    }

    // MUTATIONS
    public async Task<User> AddAsync(User input, EntityLogInfo logInfo)
    {

        using var trans = await _user_repository.BeginTransactionAsync();

        //hash the password before saving
        input.Password = input.Password.HashPassword();

        var roleId = await _role_repository.GetList()
                     .Where(r => r.Name == "User")
                     .Select(r => r.Id)
                     .FirstOrDefaultAsync();

        input.Id = Guid.NewGuid();
        input.RoleId = roleId;
        input.IsActive = true;
        input.DateCreated = DateTime.UtcNow;
        input.DateCreated = DateTime.UtcNow;

        var entity = await _user_repository.AddAsync(input);
        await _log.LogAddAsync(logInfo, entity);

        await trans.CommitAsync();

        return entity;
    }

    public async Task<User> UpdateAsync(User input, EntityLogInfo logInfo, User? oldEntity = null)
    {
        using var trans = await _user_repository.BeginTransactionAsync();

        oldEntity ??= await _user_repository.GetByIdAsync(input.Id)
                      ?? throw new AppException($"{nameof(User)} not found.", ValidationCode.MissingRequirementEntity);
        var entity = await _user_repository.UpdateAsync(input);
        await _log.LogUpdateAsync(logInfo, entity, oldEntity);

        await trans.CommitAsync();

        return entity;
    }

    public async Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo)
    {
        using var trans = await _user_repository.BeginTransactionAsync();

        var entity = await _user_repository.GetByIdAsync(id)
                     ?? throw new AppException($"{nameof(User)} not found.", ValidationCode.MissingRequirementEntity);

        var result = await _user_repository.DeleteAsync(id);

        await _log.LogDeleteAsync(logInfo, entity);

        await trans.CommitAsync();

        return result > 0;
    }

    public async Task<string> LoginAsync(string email, string password)
    {
        var user = await _user_repository.GetByEmailAsync(email);
		if (user == null || !user.IsActive)
			throw new AppException("Invalid Credentials, try again.");

		// Verify the password hash
		var passwordVerificationResult = password.VerifyPassword(user.Password);
		if (!passwordVerificationResult)
			throw new AppException("Invalid Credentials, try again.");

		var claims = new[]
		{
			new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
			new Claim(JwtRegisteredClaimNames.Email, user.Email),
			new Claim(JwtRegisteredClaimNames.GivenName, user.FirstName),
			new Claim(JwtRegisteredClaimNames.FamilyName, user.LastName),
			new Claim("role", user.Role?.Name ?? "User"),
			new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
		};

		//use cookies to store token for web clients

		return _jwtTokenHandler.GenerateToken(
			claims,
			AppSettings.ServiceProviderJwt.ValidIssuer,
			AppSettings.ServiceProviderJwt.ValidAudiences.FirstOrDefault() ?? "",
			AppSettings.ServiceProviderJwt.IssuerSigningKey,
			DateTime.Now.AddHours(1));
	}
    
}