
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IPermissionRepository : IRepositoryBase
{
    Task<Permission?> GetByIdAsync(Guid id);
    IQueryable<Permission> GetList();
    Task<RolePermission> AddAsync(Permission entity);
    Task<Permission> UpdateAsync(Permission entity);
    Task<bool> DeleteAsync(Guid id);
}

