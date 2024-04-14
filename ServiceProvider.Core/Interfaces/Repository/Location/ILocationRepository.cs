using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface ILocationRepository : IRepositoryBase
{
    Task<Location?> GetByIdAsync(Guid id);
    IQueryable<Location> GetList();
    Task<Location> AddAsync(Location entity);
    Task<Location> UpdateAsync(Location entity);
    Task<int> DeleteAsync(Guid id);
}
