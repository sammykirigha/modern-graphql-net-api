
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;

public interface IEntityLogRepository : IRepositoryBase
{
    Task<EntityLog?> GetByIdAsync(Guid id);
    IQueryable<EntityLog> GetList();
    Task<EntityLog> AddAsync(EntityLog entity);
    Task<ICollection<EntityLog>> AddListAsync(ICollection<EntityLog> list);
    Task<EntityLog> UpdateAsync(EntityLog entity);
    Task<int> DeleteAsync(Guid id);
}