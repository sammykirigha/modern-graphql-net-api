
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IRolePermissionService
{
	Task<RolePermission?> GetByIdAsync(Guid id);
	IQueryable<RolePermission> GetList();
	IQueryable<RolePermissionPaged> GetPagedList();
	Task<RolePermission> AddAsync(RolePermission entity, EntityLogInfo logInfo);
	Task<RolePermission> UpdateAsync(RolePermission entity, EntityLogInfo logInfo, RolePermission? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}