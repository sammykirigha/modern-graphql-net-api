using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PrismBenefits.Core.Interfaces.Services.Identity;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.DTOs.User;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.EmailService;
using ServiceProvider.Core.Interfaces.Passwords;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Interfaces.Services.Users;
using ServiceProvider.Core.Models;
using ServiceProvider.Core.Settings;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ServiceProvider.Services.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _user_repository;
    private readonly IRoleRepository _role_repository;
    private readonly IJwtTokenHandlerService _jwtTokenHandler;
    private readonly IPasswordResetTokenService _tokenService;
    private readonly IMapper _mapper;
    private readonly IEmailService _smtpEmailService;
    private readonly IEntityLogService _log;

    public UserService(
        IUserRepository user_repository, 
        IRoleRepository role_repository,
        IJwtTokenHandlerService jwtTokenHandler,
        IEmailService smtpEmailService,
        IMapper mapper,
        IPasswordResetTokenService tokenService, 
        IEntityLogService log)
    {
        _user_repository = user_repository;
        _jwtTokenHandler = jwtTokenHandler;
        _role_repository = role_repository;
        _tokenService = tokenService;
        _smtpEmailService = smtpEmailService;
        _log = log;
        _mapper = mapper;
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
public async Task<CreateUserDto> AddAsync(CreateUserDto input, EntityLogInfo logInfo)
{
    using var trans = await _user_repository.BeginTransactionAsync();
    
    // Map DTO to User entity
    var userObj = _mapper.Map<User>(input);

    // Hash the password
    var hashedPassword =  userObj.Password.HashPassword();

    // Get the default role ID for "User"
    var roleId = await _role_repository.GetList()
        .Where(r => r.Name == "User")
        .Select(r => r.Id)
        .FirstOrDefaultAsync();

    // Assign values to the user entity
    userObj.Id = Guid.NewGuid();
    userObj.Password = hashedPassword;
    userObj.RoleId = roleId;
    userObj.IsActive = true;
    userObj.DateCreated = DateTime.UtcNow;

    // Save the user to the database
    var entity = await _user_repository.AddAsync(userObj);

    // Log the creation event
    await _log.LogAddAsync(logInfo, entity);

    // Map the saved entity back to DTO
    var returnObj = _mapper.Map<CreateUserDto>(entity);

    // Commit the transaction
    await trans.CommitAsync();

    return returnObj;
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

		if(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
			throw new AppException("Please provide email or password, and try again.");
		
        var user = await _user_repository.GetByEmailAsync(email);

		if (user == null || !user.IsActive)
			throw new AppException("Invalid Credentials, try again.");

		var passwordVerificationResult = password.VerifyPassword(user.Password);

		if (!passwordVerificationResult)
			throw new AppException("Invalid Credentials password, try again.");

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
    
    public async Task<string> ForgetPassword(string email)
    {
	    var user = await _user_repository.GetByEmailAsync(email);
	    if (user == null || !user.IsActive)
		    throw new AppException("INo registered user with the email provided");
	    
	    var token = _tokenService.GenerateResetToken(email);
	    var url = $"http://localhost:3000/reset-password?token={token}";

	    await _smtpEmailService.SendEmailAsync(email, "Reset Your Password", url);
	    
	    return $"Kindly check your email for password reset";
    }
    
    public async Task<bool> ResetPassword(string token, string  newpassword, string confirmPassword)
    {
	    //decode the token to get the email
	    var email = _tokenService.DecodeResetToken(token);
	    
	    //get the user with the email
	    var user = await _user_repository.GetByEmailAsync(email);
	    if(user == null || !user.IsActive)
		    throw new AppException("No registered user with the email provided");
	    
	    //check if new password and confirm password are the same
	    var passwordMatch = newpassword == confirmPassword;
	    if (!passwordMatch)
		    throw new AppException($"Your new password and confirm password do not match");
	    //hash the new password
	    var hashedPassword = newpassword.HashPassword();
	    //update the user password
		user.Password = hashedPassword;
		
	    await _user_repository.UpdateAsync(user);
	    //return true when updated
	    return true;
    }
}