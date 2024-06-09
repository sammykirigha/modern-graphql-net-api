using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface ISubscriptionService
{
	Task<Subscription?> GetByIdAsync(Guid id);
	IQueryable<Subscription> GetList();
	IQueryable<SubscriptionPaged> GetPagedList();
	Task<Subscription> AddAsync(Subscription entity,  EntityLogInfo logInfo);
	Task<Subscription> UpdateAsync(Subscription entity, EntityLogInfo logInfo, Subscription? oldEntity = null);
	Task<List<Subscription>> UpdateListAsync(List<Subscription>? oldEntities = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}