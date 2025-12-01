using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services;

public class ServiceListingService: IServiceListingService
{
	private readonly IServiceListingRepository _repository;
	private readonly IEntityLogService _log;

	public ServiceListingService(
		IServiceListingRepository repository,
        IServiceProviderEntityRepository spRepository,
        ICategoryRepository categoryRepository,
        IEntityLogService log)
    {
        _repository = repository;
        _log = log;
    }


    // QUERIES
    public async Task<ServiceListing?> GetByIdAsync(Guid id)
    {
        var entity = await _repository.GetByIdAsync(id);

        return entity;
    }

    public IQueryable<Core.Models.ServiceListing> GetList()
    {
        var entity = _repository.GetList().AsNoTracking();
        return entity;
    }

    // MUTATIONS
    public async Task<ServiceListing> AddAsync(ServiceListing input, EntityLogInfo logInfo)
    {
        using var trans = await _repository.BeginTransactionAsync();

        var entity = await _repository.AddAsync(input);
       
        await _log.LogAddAsync(logInfo, entity);

        await trans.CommitAsync();

        return entity;
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