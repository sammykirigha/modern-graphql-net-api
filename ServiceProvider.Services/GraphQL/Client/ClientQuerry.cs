using HotChocolate.Authorization;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;
[Authorize]
[QueryType]
public static class ClientQuery
{
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<Client> GetClients(IClientService service) => service.GetList();
    
    
	[UsePaging]
	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public static IQueryable<ClientPaged> GetClientsPaged(IClientService service) => service.GetPagedList();
    
	[UseSingleOrDefault]
	public static async Task<Client?> GetClientById(IClientService service, Guid id) => await service.GetByIdAsync(id);
}