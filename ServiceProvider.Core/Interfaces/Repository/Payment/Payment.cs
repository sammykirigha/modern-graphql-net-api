using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IPaymentRepository : IRepositoryBase
{
    Task<Payment?> GetByIdAsync(Guid id);
    IQueryable<Payment> GetList();
    Task<Payment> AddAsync(Payment entity);
    Task<Payment> UpdateAsync(Payment entity);
    Task<int> DeleteAsync(Guid id);
}