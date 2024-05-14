using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IServiceLocationRepository : IRepositoryBase
{
    Task<ServiceLocation?> GetByIdAsync(Guid id);
    IQueryable<ServiceLocation> GetList();
    Task<ServiceLocation> AddAsync(ServiceLocation entity);
    Task<ServiceLocation> UpdateAsync(ServiceLocation entity);
    Task<int> DeleteAsync(Guid id);
}