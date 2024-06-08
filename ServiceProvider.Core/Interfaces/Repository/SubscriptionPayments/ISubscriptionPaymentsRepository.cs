
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface ISubscriptionPaymentsRepository : IRepositoryBase
{
    Task<SubscriptionPayments?> GetByIdAsync(Guid id);
    IQueryable<SubscriptionPayments> GetList();
    Task<SubscriptionPayments> AddAsync(SubscriptionPayments entity);
    Task<SubscriptionPayments> UpdateAsync(SubscriptionPayments entity);
    Task<int> DeleteAsync(Guid id);
}