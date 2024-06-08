using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface ISubscriptionPaymentsService
{
	Task<SubscriptionPayments?> GetByIdAsync(Guid id);
	IQueryable<SubscriptionPayments> GetList();
	IQueryable<SubscriptionPaymentsPaged> GetPagedList();
	Task<SubscriptionPayments> AddAsync(SubscriptionPayments entity, EntityLogInfo logInfo);
	Task<SubscriptionPayments> UpdateAsync(SubscriptionPayments entity, EntityLogInfo logInfo, SubscriptionPayments? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}