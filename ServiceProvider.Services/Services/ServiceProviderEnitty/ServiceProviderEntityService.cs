using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using ServiceProvider.Core.Models.ServiceProvider;


namespace ServiceProvider.Services;

public class ServiceProviderEntityService :  IServiceProviderEntityService
{
    private readonly  IServiceProviderEntityRepository  _repository;
    private readonly IEntityLogService _log;
    
    public ServiceProviderEntityService(
	    IServiceProviderEntityRepository repository,
        IEntityLogService log)
    {
        _repository = repository;
        _log = log;
    }
    
    // QUERIES
    public async Task<ServiceProviderEntity?> GetByIdAsync(Guid id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity;
    }
    
    public IQueryable<ServiceProviderEntity> GetList()
    {
        return _repository.GetList().AsNoTracking();
    }
    
    public IQueryable<ServiceProviderEntityPaged> GetPagedList()
    {
        return (
            from u in _repository.GetList()
            select new ServiceProviderEntityPaged
            {
                ServiceProvider = u
            }
        ).AsNoTracking();
    }
    
    // MUTATIONS
    public async Task<ServiceProviderEntity> AddAsync(ServiceProviderEntity input, EntityLogInfo logInfo)
    {
        using var trans = await _repository.BeginTransactionAsync();
        
        var entity = await _repository.AddAsync(input);
        await _log.LogAddAsync(logInfo, entity);

        await trans.CommitAsync();
        
        return entity;
    }

    public async Task<ServiceProviderEntity> UpdateAsync(ServiceProviderEntity input, EntityLogInfo logInfo, ServiceProviderEntity? oldEntity = null)
    {
        using var trans = await _repository.BeginTransactionAsync();
        
        oldEntity ??= await _repository.GetByIdAsync(input.Id)
                      ?? throw new AppException($"{nameof(ServiceProvider)} not found.", ValidationCode.MissingRequirementEntity);
        var entity = await _repository.UpdateAsync(input);
        await _log.LogUpdateAsync(logInfo, entity, oldEntity);

        await trans.CommitAsync();

        return entity;
    }
    
    public async Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo)
    {
        using var trans = await _repository.BeginTransactionAsync();

        var entity = await _repository.GetByIdAsync(id)
                     ?? throw new AppException($"{nameof(ServiceProviderEntity)} not found.", ValidationCode.MissingRequirementEntity);
        var result = await _repository.DeleteAsync(id);
        await _log.LogDeleteAsync(logInfo, entity);

        await trans.CommitAsync();

        return result > 0;
    }
}