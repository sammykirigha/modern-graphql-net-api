using Microsoft.AspNetCore.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;

[Authorize]
[QueryType]
public static class EntityLogQuery
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<EntityLog> GetEntityLogs(IEntityLogService service)
		=> service.GetList();
    
	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<EntityLogPaged> GetEntityLogsPaged(IEntityLogService service)
		=> service.GetPagedList();
    
	[UseSingleOrDefault]
	public static Task<EntityLog?> GetEntityLogById(IEntityLogService service, Guid id)
		=> service.GetByIdAsync(id);
}