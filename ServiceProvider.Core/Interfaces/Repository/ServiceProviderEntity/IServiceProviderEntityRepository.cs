
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IServiceProviderEntityRepository : IRepositoryBase
{
    Task<ServiceProviderEntity?> GetByIdAsync(Guid id);
    IQueryable<ServiceProviderEntity> GetList();
    Task<ServiceProviderEntity> AddAsync(ServiceProviderEntity entity);
    Task<ServiceProviderEntity> UpdateAsync(ServiceProviderEntity entity);
    Task<int> DeleteAsync(Guid id);
}