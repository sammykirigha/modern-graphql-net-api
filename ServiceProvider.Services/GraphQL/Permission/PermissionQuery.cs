
using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;

[Authorize]
[QueryType]
public static class PermissionQuery
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<Permission> GetPermissions(IPermissionService service) => service.GetList();
    
	[UsePaging]
	[UseProjection]
	[UseSorting]
	public static IQueryable<PermissionPaged> GetPermissionsPaged(IPermissionService service) => service.GetPagedList();
    
	[UseSingleOrDefault]
	public static async Task<Permission> GetPermissionById(IPermissionService service, Guid id) => await service.GetByIdAsync(id);
}