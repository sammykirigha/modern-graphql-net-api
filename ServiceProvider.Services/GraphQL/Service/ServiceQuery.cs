
using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;
[Authorize]
[QueryType]
public class ServiceQuery
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<Service> GetServices(IServiceService service)
		=> service.GetList();
    
    
	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<ServicePaged> GetServicesPaged(IServiceService service)
		=> service.GetPagedList();
    
	[UseSingleOrDefault]
	public static Task<Service?> GetServiceById(IServiceService service, Guid id)
		=> service.GetByIdAsync(id);
}