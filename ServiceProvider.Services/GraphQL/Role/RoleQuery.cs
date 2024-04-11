
using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;

[Authorize]
[QueryType]
public static class RoleQuery
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<Role> GetRoles(IRoleService service) => service.GetList();
    
	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<RolePaged> GetRolesPaged(IRoleService service) => service.GetPagedList();
    
	[UseSingleOrDefault]
	public static Task<Role?> GetRoleById(IRoleService service, Guid id)
		=> service.GetByIdAsync(id);
}