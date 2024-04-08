
using ServiceProvider.Core.Models;

namespace Graphql.Core.Interfaces.Services;

public interface IRoleService
{
	Task<Role?> GetByIdAsync(Guid id);
	IQueryable<Role> GetList();
	IQueryable<RolePaged> GetPagedList();
	Task<Role> AddAsync(Role entity, EntityLogInfo logInfo);
	Task<Role> UpdateAsync(Role entity, EntityLogInfo logInfo, Role? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}