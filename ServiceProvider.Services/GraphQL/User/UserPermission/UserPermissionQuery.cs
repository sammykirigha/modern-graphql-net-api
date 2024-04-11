using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace Graphql.Services.GraphQL;
[Authorize]
[QueryType]
public static class UserPermissionQuery
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<UserPermission> GetUserPermissions(IUserPermissionService service) => service.GetList();
    
	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<UserPermissionPaged> GetUserPermissionsPaged(IUserPermissionService service) => service.GetPagedList();
    
	[UseSingleOrDefault]
	public static Task<UserPermission?> GetUserPermissionById(IUserPermissionService service, Guid id) => service.GetByIdAsync(id);
    
}