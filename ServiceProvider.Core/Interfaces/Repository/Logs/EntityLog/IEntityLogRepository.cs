
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;

public interface IEntityLogRepository : IRepositoryBase
{
    Task<EntityLog?> GetByIdAsync(Guid id);
    IQueryable<EntityLog> GetList();
    Task<EntityLog> AddAsync(EntityLog entity);
    Task<EntityLog> UpdateAsync(EntityLog entity);
    Task<bool> DeleteAsync(Guid id);
}