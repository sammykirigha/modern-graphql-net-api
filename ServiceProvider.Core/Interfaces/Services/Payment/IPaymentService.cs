using ServiceProvider.Core.Models;
namespace ServiceProvider.Core.Interfaces.Services;

public interface IPaymentService
{
	Task<Payment?> GetByIdAsync(Guid id);
	IQueryable<Payment> GetList();
	IQueryable<PaymentPaged> GetPagedList();
	Task<Payment> AddAsync(Guid planId, EntityLogInfo logInfo);
	Task<Payment> UpdateAsync(Payment entity, EntityLogInfo logInfo, Payment? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}