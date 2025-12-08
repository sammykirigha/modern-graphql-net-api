using Microsoft.EntityFrameworkCore;
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
using ServiceProvider.Core.Models.ServiceProvider;


namespace ServiceProvider.Services;

public class ServiceProviderEntityService :  IServiceProviderEntityService
{
    private readonly  IServiceProviderEntityRepository  _spRepository;
    private readonly  IUserRepository  _userRepository;
    private readonly IEmailService _emailService;
    private readonly  IRoleRepository  _roleRepository;
    private readonly IUserService _userService;
    private readonly IPasswordResetTokenService _tokenService;
    private readonly IEntityLogService _log;
    
    public ServiceProviderEntityService(
	    IServiceProviderEntityRepository spRepository, 
	    IUserRepository  userRepository, 
	    IRoleRepository  roleRepository,
	    IPasswordResetTokenService tokenService, 
	    IEmailService emailService,
	    IUserService userService,
        IEntityLogService log)
    {
	    _spRepository = spRepository;
	    _userRepository = userRepository;
	    _tokenService = tokenService;
	    _roleRepository = roleRepository;
	    _userService =  userService;
	    _emailService = emailService;
        _log = log;
    }
    
    // QUERIES
    public async Task<ServiceProviderEntity?> GetByIdAsync(Guid id)
    {
        var entity = await _spRepository.GetByIdAsync(id);
        return entity;
    }
    
    public IQueryable<ServiceProviderEntity> GetList()
    {
        return _spRepository.GetList().AsNoTracking();
    }
    
    public IQueryable<ServiceProviderEntityPaged> GetPagedList()
    {
        return (
            from u in _spRepository.GetList()
            select new ServiceProviderEntityPaged
            {
                ServiceProvider = u
            }
        ).AsNoTracking();
    }
    
    // MUTATIONS
    public async Task<ServiceProviderEntity> AddAsync(ServiceProviderEntity entity, EntityLogInfo logInfo)
    {
        using var trans = await _spRepository.BeginTransactionAsync();
        
        var user = await _userRepository.GetByEmailAsync(entity.Email);
        var tempPassword = "ServiceProvider@2025!";
        var hashedPassword = tempPassword.HashPassword();
        
        if(user == null)
		{
			var newUser = new User
			{
				Id = Guid.NewGuid(),
				Email = entity.Email,
				FirstName = entity.FirstName,
				LastName = entity.LastName,
				Password = hashedPassword, 
			};
			user = await _userRepository.AddAsync(newUser);
			await _log.LogAddAsync(logInfo, user);
			
			//send email to user with password reset link
			var token = _tokenService.GenerateResetToken(entity.Email);
			var url = $"http://localhost:3000/reset-password?token={token}";

			await _emailService.SendEmailAsync(user.Email, "Account Creation, Reset Password",
				$"Dear {user.FirstName} {user.LastName} your account has been created as a service provider. Please reset your password. This is the system password {tempPassword} click the link to reset your password: " + url);
			
		}
        
        //if found update the role to service-provider
        var serviceProviderId =await _roleRepository.GetList()
	        .Where(r => r.Name == "ServiceProvider")
	        .Select(r => r.Id)
	        .FirstOrDefaultAsync();
        
        user.RoleId = serviceProviderId;
        await _userRepository.UpdateAsync(user);
        
        entity.UserId = user.Id;
        var serviceProvider = await _spRepository.AddAsync(entity);
        await _log.LogAddAsync(logInfo, serviceProvider);

        await trans.CommitAsync();
        return serviceProvider;
    }
    
    public async Task<LoginResponseDto> ActivateAccountAndResetPassword(string token, string newPassword, string confirmPassword)
	{
		using var trans = await _spRepository.BeginTransactionAsync();
		var email = _tokenService.DecodeResetToken(token);
	    if (string.IsNullOrEmpty(email))
		    throw new AppException("Invalid or expired token.");

	    // Here you would typically set a flag on the user to mark the account as active.
	    var user = await _userRepository.GetByEmailAsync(email)
	               ?? throw new AppException("User not found.", ValidationCode.MissingRequirementEntity);

	    //check if password and confirm password match
	    var passwordMatch = newPassword == confirmPassword;
	    if (!passwordMatch)
		    throw new AppException($"Your new password and confirm password do not match");
	    
	    var hashedPassword = newPassword.HashPassword();
	    
	    user.Password = hashedPassword;
	    user.IsActive = true;
	    await _userRepository.UpdateAsync(user);
	    
	    var serviceProvider = await _spRepository.GetList().Where(sp => sp.Email == email).FirstOrDefaultAsync();
	    serviceProvider.IsActive = true;
	    
	    await _spRepository.UpdateAsync(serviceProvider);
	    
	    var tokenResult = await _userService.LoginAsync(email, newPassword);
	    
	    await trans.CommitAsync();
	    return tokenResult;
	}

    public async Task<ServiceProviderEntity> UpdateAsync(ServiceProviderEntity entity, EntityLogInfo logInfo, ServiceProviderEntity? oldEntity = null)
    {
        using var trans = await _spRepository.BeginTransactionAsync();
        
        oldEntity ??= await _spRepository.GetByIdAsync(entity.Id)
                      ?? throw new AppException($"{nameof(ServiceProvider)} not found.", ValidationCode.MissingRequirementEntity);
        var serviceProvider = await _spRepository.UpdateAsync(entity);
        await _log.LogUpdateAsync(logInfo, serviceProvider, oldEntity);

        await trans.CommitAsync();

        return entity;
    }
    
    public async Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo)
    {
        using var trans = await _spRepository.BeginTransactionAsync();

        var entity = await _spRepository.GetByIdAsync(id)
                     ?? throw new AppException($"{nameof(ServiceProviderEntity)} not found.", ValidationCode.MissingRequirementEntity);
        var result = await _spRepository.DeleteAsync(id);
        await _log.LogDeleteAsync(logInfo, entity);

        await trans.CommitAsync();

        return result > 0;
    }
}