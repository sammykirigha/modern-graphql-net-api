using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;

[Authorize]
[QueryType]
public static class ErrorLogQuery
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<ErrorLog> GetErrorLogs(IErrorLogService service)
		=> service.GetList();

	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<ErrorLogPaged> GetErrorLogsPaged(IErrorLogService service)
		=> service.GetPagedList();
    
	[UseSingleOrDefault]
	public static Task<EntityLog?> GetEntityLogById(IEntityLogService service, Guid id)
		=> service.GetByIdAsync(id);
}