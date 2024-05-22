
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IPlanRepository : IRepositoryBase
{
    Task<Plan?> GetByIdAsync(Guid id);
    IQueryable<Plan> GetList();
    Task<Plan> AddAsync(Plan entity);
    Task<Plan> UpdateAsync(Plan entity);
    Task<int> DeleteAsync(Guid id);
}

