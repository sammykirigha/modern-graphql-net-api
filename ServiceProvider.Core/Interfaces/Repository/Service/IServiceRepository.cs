
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IServiceRepository : IRepositoryBase
{
    Task<Service?> GetByIdAsync(Guid id);
    IQueryable<Service> GetList();
    Task<Service> AddAsync(Service entity);
    Task<Service> UpdateAsync(Service entity);
    Task<int> DeleteAsync(Guid id);
}