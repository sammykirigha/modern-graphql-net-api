using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using Subscription = ServiceProvider.Core.Models.Subscription;

namespace ServiceProvider.Services;

public class SubscriptionService: ISubscriptionService
{
  private readonly ISubscriptionRepository _repository;
    private readonly IEntityLogService _log;

    public SubscriptionService(
        ISubscriptionRepository repository,
        IEntityLogService log)
    {
        _repository = repository;
        _log = log;
    }

    // QUERIES
    public async Task<Subscription?> GetByIdAsync(Guid id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity;
    }

    public IQueryable<Subscription> GetList()
    {
        return _repository.GetList().AsNoTracking();
    }

    public IQueryable<SubscriptionPaged> GetPagedList()
    {
        return (
            from u in _repository.GetList()
            select new SubscriptionPaged
            {
                Subscription = u
            }
        ).AsNoTracking();
    }


    // MUTATIONS
    public async Task<Subscription> AddAsync(Subscription entity,  EntityLogInfo logInfo)
    {
        using var trans = await _repository.BeginTransactionAsync();
        await _log.LogAddAsync(logInfo, entity);

        await trans.CommitAsync();

        return entity;
    }

    public async Task<Subscription> UpdateAsync(Subscription input, EntityLogInfo logInfo, Subscription? oldEntity = null)
    {
	    using var trans = await _repository.BeginTransactionAsync();

        oldEntity ??= await _repository.GetByIdAsync(input.Id)
                      ?? throw new AppException($"{nameof(Subscription)} not found.", ValidationCode.MissingRequirementEntity);
        var entity = await _repository.UpdateAsync(input);
        await _log.LogUpdateAsync(logInfo, entity, oldEntity);

        await trans.CommitAsync();

        return entity;
    }

    public async Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo)
    {
        using var trans = await _repository.BeginTransactionAsync();

        var entity = await _repository.GetByIdAsync(id)
                     ?? throw new AppException($"{nameof(Subscription)} not found.", ValidationCode.MissingRequirementEntity);
        var result = await _repository.DeleteAsync(id);
        await _log.LogDeleteAsync(logInfo, entity);

        await trans.CommitAsync();

        return result > 0;
    }
}