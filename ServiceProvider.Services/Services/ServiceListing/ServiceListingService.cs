using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.DTOs.ServiceListing;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using System.Security.Claims;

namespace ServiceProvider.Services;

public class ServiceListingService: IServiceListingService
{
	private readonly IServiceListingRepository _repository;
	private readonly IServiceProviderEntityRepository _spRepository;
	private readonly IServiceListingsServicesRepository _serviceListingsRepository;
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly IEntityLogService _log;

	public ServiceListingService(
		IServiceListingRepository repository,
		IServiceListingsServicesRepository slsRepository,
		IServiceProviderEntityRepository spRepository,
		IHttpContextAccessor httpContextAccessor,
        IEntityLogService log)
    {
        _repository = repository;
        _httpContextAccessor = httpContextAccessor;
        _spRepository = spRepository;
        _serviceListingsRepository = slsRepository;
        _log = log;
    }


    // QUERIES
    public async Task<ServiceListing?> GetByIdAsync(Guid id)
    {
        var entity = await _repository.GetByIdAsync(id);

        return entity;
    }

    public IQueryable<ServiceListing> GetList()
    {
        var entity = _repository.GetList().AsNoTracking();
        return entity;
    }

    // MUTATIONS
    public async Task<ServiceListing> AddAsync(CreateServiceListingDto input, EntityLogInfo logInfo)
    {
	    using var trans = await _repository.BeginTransactionAsync();
	    
	    if (!_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
		    throw new AppException($"You are not authorised to perform this");
	    
	    var  email = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Email);
		
	    var sperviceProviderd = await _spRepository.GetList().Where(sp => sp.Email == email).Select(sp => sp.Id)
		    .FirstOrDefaultAsync();
	    
	    //only a max of three service listings per service provider
	    var numberOfListings = await _repository.GetList().CountAsync();

	    if (numberOfListings >= 3)
		    throw new AppException($"Maximum number of service listings reached.");
        
        var newEntity = new CreateServiceListingDto()
        {
	        PaymentMode = input.PaymentMode,
	        ServiceProviderId = sperviceProviderd,
	        BasePrice = input.BasePrice,
	        BusinessName = input.BusinessName,
	        BusinessDescription = input.BusinessDescription,
	        CustomServiceId = input.CustomServiceId
        };

        var entity = await _repository.AddAsync(newEntity);
        
        var serviceListingsServicesEntities = new List<ServiceListingsServices>();
        
        foreach (var serviceId in input.ServiceIds)
        {
	        var newSLS = new ServiceListingsServices()
	        {
		        ServiceListingId = entity.Id,
		        ServiceId = serviceId
	        };
	        serviceListingsServicesEntities.Add(newSLS);
        }
         
		 await _serviceListingsRepository.AddRangeAsync(serviceListingsServicesEntities);
        await _log.LogAddAsync(logInfo, entity);
        
        var returnedEntity = await _repository.GetByIdWithServicesAsync(entity.Id);
        await trans.CommitAsync();

        return returnedEntity;
    }

    public async Task<ServiceListing> UpdateAsync(ServiceListing input, EntityLogInfo logInfo, ServiceListing? oldEntity = null)
    {
	    using var trans = await _repository.BeginTransactionAsync();

        oldEntity ??= await _repository.GetByIdAsync(input.Id)
                      ?? throw new AppException($"{nameof(ServiceListing)} not found.", ValidationCode.MissingRequirementEntity);
        var entity = await _repository.UpdateAsync(input);
        await _log.LogUpdateAsync(logInfo, entity, oldEntity);

        await trans.CommitAsync();

        return entity;
    }

    public async Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo)
    {
        using var trans = await _repository.BeginTransactionAsync();

        var entity = await _repository.GetByIdAsync(id)
                     ?? throw new AppException($"{nameof(ServiceListing)} not found.", ValidationCode.MissingRequirementEntity);
        var result = await _repository.DeleteAsync(id);
        await _log.LogDeleteAsync(logInfo, entity);

        await trans.CommitAsync();

        return result > 0;
    }
}