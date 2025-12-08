using HotChocolate.Authorization;
using ServiceProvider.Core.DTOs.ServiceListing;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.GraphQL;
[Authorize]
[MutationType]
public static class ServiceListingsMutation
{
	public static async Task<ServiceListing> AddServiceListing(CreateServiceListingDto serviceListing, EntityLogInfo logInfo, IServiceListingService service)
	{
		try
		{
			var entity = await service.AddAsync(serviceListing, logInfo);
			return entity;
		}
		catch (AppException ex)
		{
			throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
		}
	}

}