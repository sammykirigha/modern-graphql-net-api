using Graphql.Core.Models;
using ServiceProvider.Core.Models;

namespace Graphql.Core.Interfaces.Services;

public interface IUserPermissionService
{
	Task<UserPermission?> GetByIdAsync(Guid id);
	IQueryable<UserPermission> GetList();
	IQueryable<UserPermissionPaged> GetPagedList();
	Task<UserPermission> AddAsync(UserPermission entity, EntityLogInfo logInfo);
	Task<UserPermission> UpdateAsync(UserPermission entity, EntityLogInfo logInfo, UserPermission? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}