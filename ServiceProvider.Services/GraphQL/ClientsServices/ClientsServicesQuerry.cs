using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;
[Authorize]
[QueryType]
public class ClientsServicesQuery
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<ClientsServices> GetClientsServices(IClientsServicesService service)
		=> service.GetList();
    
    
	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<ClientPaged> GetClientsServicesPaged(IClientService service)
		=> service.GetPagedList();
    
	[UseSingleOrDefault]
	public static Task<ClientsServices?> GetClientsServicesById(IClientsServicesService service, Guid id)
		=> service.GetByIdAsync(id);
}