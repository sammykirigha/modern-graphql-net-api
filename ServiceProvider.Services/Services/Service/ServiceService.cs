using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services;

public class ServiceService : IServiceService
{
    private readonly IServiceRepository _repository;
     private readonly IServiceLocationRepository _serviceLocationRepository;
	private readonly IServiceProviderEntityRepository _spRepository;
	private readonly IEntityLogService _log;
	private readonly ICategoryRepository _category;

	public ServiceService(
        IServiceRepository repository,
        IServiceLocationRepository serviceLocationRepository,
        IServiceProviderEntityRepository spRepository,
        ICategoryRepository categoryRepository,
        IEntityLogService log)
    {
        _repository = repository;
        _log = log;
        _serviceLocationRepository = serviceLocationRepository;
        _spRepository = spRepository;
        _category = categoryRepository;
    }


    // QUERIES
    public async Task<Service?> GetByIdAsync(Guid id)
    {
        var entity = await _repository.GetByIdAsync(id);

        return entity;
    }

    public IQueryable<Service> GetList()
    {
        var entity = _repository.GetList().AsNoTracking();
        return entity;
    }

    public IQueryable<ServicePaged> GetPagedList()
    {
        return (
            from u in _repository.GetList()
            select new ServicePaged
            {
                Service = u
            }
        ).AsNoTracking();
    }

    // MUTATIONS
    public async Task<Service> AddAsync(Service input, EntityLogInfo logInfo)
    {
        using var trans = await _repository.BeginTransactionAsync();

        var entity = await _repository.AddAsync(input);
        var serviceLocation = new ServiceLocation {
            ServiceId = entity.Id,
            LocationId = input.LocationId
        };
       
        await _serviceLocationRepository.AddAsync(serviceLocation);
        await _log.LogAddAsync(logInfo, entity);

        await trans.CommitAsync();

        return entity;
    }

    public async Task<Service> UpdateAsync(Service input, EntityLogInfo logInfo, Service? oldEntity = null)
    {
	    using var trans = await _repository.BeginTransactionAsync();

        oldEntity ??= await _repository.GetByIdAsync(input.Id)
                      ?? throw new AppException($"{nameof(Service)} not found.", ValidationCode.MissingRequirementEntity);
        var entity = await _repository.UpdateAsync(input);
        await _log.LogUpdateAsync(logInfo, entity, oldEntity);

        await trans.CommitAsync();

        return entity;
    }

    public async Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo)
    {
        using var trans = await _repository.BeginTransactionAsync();

        var entity = await _repository.GetByIdAsync(id)
                     ?? throw new AppException($"{nameof(Service)} not found.", ValidationCode.MissingRequirementEntity);
        var result = await _repository.DeleteAsync(id);
        await _log.LogDeleteAsync(logInfo, entity);

        await trans.CommitAsync();

        return result > 0;
    }
}