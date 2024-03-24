

using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IRolePermissionRepository : IRepositoryBase
{
    Task<RolePermission?> GetByIdAsync(Guid id);
    IQueryable<RolePermission> GetList();
    Task<RolePermission> AddAsync(RolePermission entity);
    Task<RolePermission> UpdateAsync(RolePermission entity);
    Task<bool> DeleteAsync(Guid id);
}

