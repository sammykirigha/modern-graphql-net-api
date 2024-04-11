using ServiceProvider.Core.Models;


namespace ServiceProvider.Core.Interfaces.Services;

public interface IPermissionService
{
	Task<Permission?> GetByIdAsync(Guid id);
	IQueryable<Permission> GetList();
	IQueryable<PermissionPaged> GetPagedList();
	Task<Permission> AddAsync(Permission entity, EntityLogInfo logInfo);
	Task<Permission> UpdateAsync(Permission entity, EntityLogInfo logInfo, Permission? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}