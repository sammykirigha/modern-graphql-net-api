
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface ISubscriptionRepository : IRepositoryBase
{
    Task<Subscription?> GetByIdAsync(Guid id);
    IQueryable<Subscription> GetList();
    Task<Subscription> AddAsync(Subscription entity);
    Task<Subscription> UpdateAsync(Subscription entity);
    Task<List<Subscription>> UpdateListAsync(List<Subscription>? entityList);
    Task<int> DeleteAsync(Guid id);
}