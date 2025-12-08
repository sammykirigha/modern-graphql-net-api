using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using PrismBenefits.Core.Interfaces.Services.Identity;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.DTOs.User;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.EmailService;
using ServiceProvider.Core.Interfaces.Passwords;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Repositories.Auth;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Interfaces.Services.Users;
using ServiceProvider.Core.Models;
using ServiceProvider.Core.Models.Auth;
using ServiceProvider.Core.Settings;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace ServiceProvider.Services.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _user_repository;
    private readonly IRoleRepository _role_repository;
    private readonly IJwtTokenHandlerService _jwtTokenHandler;
    private readonly IPasswordResetTokenService _tokenService;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IMapper _mapper;
    private readonly IEmailService _smtpEmailService;
    private readonly IRefreshTokenRepository _refreshTokenRepository;
    private readonly IEntityLogService _log;

    public UserService(
        IUserRepository user_repository, 
        IRoleRepository role_repository,
        IHttpContextAccessor httpContextAccessor,
        IJwtTokenHandlerService jwtTokenHandler,
        IEmailService smtpEmailService,
        IRefreshTokenRepository refreshTokenRepository,
        IMapper mapper,
        IPasswordResetTokenService tokenService, 
        IEntityLogService log)
    {
        _user_repository = user_repository;
        _httpContextAccessor = httpContextAccessor;
        _jwtTokenHandler = jwtTokenHandler;
        _role_repository = role_repository;
        _tokenService = tokenService;
        _smtpEmailService = smtpEmailService;
        _refreshTokenRepository = refreshTokenRepository;
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
    var userObj = _mapper.Map<User>(input);

    var hashedPassword =  userObj.Password.HashPassword();

    var roleId = await _role_repository.GetList()
        .Where(r => r.Name == "User")
        .Select(r => r.Id)
        .FirstOrDefaultAsync();

    userObj.Id = Guid.NewGuid();
    userObj.Password = hashedPassword;
    userObj.RoleId = roleId;
    userObj.DateCreated = DateTime.UtcNow;

    var entity = await _user_repository.AddAsync(userObj);
    await _log.LogAddAsync(logInfo, entity);
    
    await _smtpEmailService.SendEmailAsync(entity.Email, "Account Creation Successful",
		$"Your account has been successfully created. Click the link to activate your account. ");

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

    public async Task<LoginResponseDto> LoginAsync(string email, string password)
    {
	    using var trans = await _user_repository.BeginTransactionAsync();
		if(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
			throw new AppException("Please provide email or password, and try again.");
		
        var user = await _user_repository.GetByEmailAsync(email);

		if (user == null || !user.IsActive)
			throw new AppException("Invalid Credentials, try again.");

		var passwordVerificationResult = password.VerifyPassword(user.Password);

		if (!passwordVerificationResult)
			throw new AppException("Invalid Credentials password, try again.");

		var accessTokens = GenerateAccessTokens(user);
		var refreshToken = GenerateRefreshToken(user.Id);
		
		await _refreshTokenRepository.AddAsync(refreshToken);
		SetRefreshTokenInCookie(refreshToken.Token);
		
		await trans.CommitAsync();
		
		return new LoginResponseDto()
		{
			AccessToken = accessTokens,
			RefreshToken = refreshToken.Token
		};
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
    
    //activate account
    public async Task<bool> ActivateAccount(string token)
    {
	    using var trans = await _user_repository.BeginTransactionAsync();
	    //decode the token to get the email
	    var email = _tokenService.DecodeResetToken(token);

	    //get the user with the email
	    var user = await _user_repository.GetByEmailAsync(email);
	    if (user == null)
		    throw new AppException("No registered user with the email provided");

	    //activate the user account
	    user.IsActive = true;
	    await _user_repository.UpdateAsync(user);
	    await trans.CommitAsync();
	    
	    return true;
    }

    
    public async Task<LoginResponseDto> RefreshTokenAsync()
	{
		var refreshtoken = _httpContextAccessor.HttpContext?.Request.Cookies["refreshToken"];
		if (!string.IsNullOrEmpty(refreshtoken))
			SetRefreshTokenInCookie(refreshtoken);
		
	    var existingRefreshToken = await _refreshTokenRepository.GetByTokenAsync(refreshtoken);
	    if (existingRefreshToken == null || existingRefreshToken.Expires < DateTime.UtcNow)
		    throw new AppException("Invalid or expired refresh token.");
	    
	    if(!existingRefreshToken.IsActive)
		    throw new AppException("Refresh token is no longer active.");

	    var user = await _user_repository.GetByIdAsync(existingRefreshToken.UserId);
	    if (user == null)
		    throw new AppException("User not found.");
	    
	    existingRefreshToken.Revoked = DateTime.UtcNow;
	    
	    var newAccessToken = GenerateAccessTokens(user);
	    var newRefreshToken = GenerateRefreshToken(user.Id);

	    await _refreshTokenRepository.AddAsync(newRefreshToken);
	    
	    return new LoginResponseDto()
	    {
		    AccessToken = newAccessToken,
		    RefreshToken = newRefreshToken.Token
	    };
	}
    private string GenerateAccessTokens(User user)
    {
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
		    DateTime.UtcNow.AddHours(4));
    }
    
    private RefreshToken GenerateRefreshToken(Guid userId)
    {
	    var randomNumber = new byte[32];
	    using (var geneator = new RNGCryptoServiceProvider())
	    {
		    geneator.GetBytes(randomNumber);
		    return new RefreshToken()
		    {
			    Id = Guid.NewGuid(),
			    UserId = userId,
			    Token = Convert.ToBase64String(randomNumber),
			    Expires = DateTime.UtcNow.AddDays(10),
			    DateCreated = DateTime.UtcNow
		    };
	    }
	}
    
    private  void SetRefreshTokenInCookie(string refreshToken)
    {
	    // Implementation to set the refresh token in an HTTP-only cookie
	    var cooikieOptions = new CookieOptions()
	    {
		    HttpOnly = true,
		    Expires = DateTime.UtcNow.AddDays(10)
	    };
	    // This is typically done in the context of an HTTP response
	    var response = _httpContextAccessor.HttpContext?.Response;
	    response.Cookies.Append("refreshToken", refreshToken, cooikieOptions);
    }
    
}