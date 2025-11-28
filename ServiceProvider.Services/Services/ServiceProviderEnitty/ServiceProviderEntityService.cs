using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.EmailService;
using ServiceProvider.Core.Interfaces.Passwords;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using ServiceProvider.Core.Models.ServiceProvider;


namespace ServiceProvider.Services;

public class ServiceProviderEntityService :  IServiceProviderEntityService
{
    private readonly  IServiceProviderEntityRepository  _spRepository;
    private readonly  IUserRepository  _userRepository;
    private readonly IEmailService _emailService;
    private readonly  IRoleRepository  _roleRepository;
    private readonly IPasswordResetTokenService _tokenService;
    private readonly IEntityLogService _log;
    
    public ServiceProviderEntityService(
	    IServiceProviderEntityRepository spRepository, 
	    IUserRepository  userRepository, 
	    IRoleRepository  roleRepository,
	    IPasswordResetTokenService tokenService, 
	    IEmailService emailService,
        IEntityLogService log)
    {
	    _spRepository = spRepository;
	    _userRepository = userRepository;
	    _tokenService = tokenService;
	    _roleRepository = roleRepository;
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
        
        //check if the  user is already registered as normal using the email provided
        var user = await _userRepository.GetByEmailAsync(entity.Email);
        
        if(user == null)
		{
			var newUser = new User
			{
				Email = entity.Email,
				FirstName = entity.FirstName,
				LastName = entity.LastName,
				Password = $"ServiceProvider@2025!".HashPassword(), 
			};
			user = await _userRepository.AddAsync(newUser);
			await _log.LogAddAsync(logInfo, user);
			
			//send email to user with password reset link
			var token = _tokenService.GenerateResetToken(entity.Email);
			var url = $"http://localhost:3000/reset-password?token={token}";

			await _emailService.SendEmailAsync(user.Email, "Account Creation, Reset Password",
				"Check your account has been created as a service provider. Please reset your password. This is the system password ServiceProvider@2025!, click the link to reset your password: " + url);
		}
        
        //if found update the role to service-provider
        var serviceProviderId =await _roleRepository.GetList()
	        .Where(r => r.Name == "User")
	        .Select(r => r.Id)
	        .FirstOrDefaultAsync();
        
        //update the user role to service provider
        user.RoleId = serviceProviderId;
        await _userRepository.UpdateAsync(user);
        
        //create the service provider with the details
        entity.UserId = user.Id;
        var serviceProvider = await _spRepository.AddAsync(entity);
        await _log.LogAddAsync(logInfo, serviceProvider);

        await trans.CommitAsync();
        return serviceProvider;
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