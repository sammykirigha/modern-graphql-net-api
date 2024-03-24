

using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IUserPermissionRepository : IRepositoryBase
{
    Task<UserPermission?> GetByIdAsync(Guid id);
    IQueryable<UserPermission> GetList();
    Task<UserPermission> AddAsync(UserPermission entity);
    Task<UserPermission> UpdateAsync(UserPermission entity);
    Task<bool> DeleteAsync(Guid id);
}

