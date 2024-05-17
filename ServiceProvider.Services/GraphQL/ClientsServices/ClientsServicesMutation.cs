using ServiceProvider.Core.Classes;
using HotChocolate.Authorization;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using System.Text.Json;


namespace Graphql.Services.GraphQL;
[Authorize]
[MutationType]
public static class ClientsServicesMutation
{
    public static async Task<ClientsServices> AddClientsServices(ClientsServicesMutationInput cs, EntityLogInfo logInfo, IClientsServicesService service)
    {
        try
        {
	        cs.ServiceId.CheckRequired();
	        cs.ClientId.CheckRequired();
            var entity = PopulateEntity(new ClientsServices(), cs);
            entity = await service.AddAsync(entity, logInfo);
            return entity;

        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<ClientsServices> UpdateClientsServices(ClientsServicesMutationInput cs, EntityLogInfo logInfo, IClientsServicesService service)
    {
        try
        {
	        cs.Id.CheckRequired();
            var entity = await service.GetByIdAsync(cs.Id.Value)
                         ?? throw new AppException($"{nameof(ClientsServices)} not found.", ValidationCode.MissingRequirementEntity);
            var oldentity = JsonSerializer.Serialize(entity).Deserialize<ClientsServices>();
            PopulateEntity(entity, cs);

            entity = await service.UpdateAsync(entity, logInfo, oldentity);
            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<bool> DeleteClientsServices(Guid id, EntityLogInfo logInfo, IClientsServicesService service)
    {
        try
        {
            var result = await service.DeleteAsync(id, logInfo);
            return result;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    [GraphQLIgnore]
    private static ClientsServices PopulateEntity(ClientsServices entity, ClientsServicesMutationInput input)
    {
        entity.ClientId = input.ClientId.CheckForValue(entity.ClientId);
        entity.ServiceId = input.ServiceId.CheckForValue(entity.ServiceId);
		
        entity.DateCreated = input.DateCreated.CheckForValue(entity.DateCreated);
        entity.DateModified = DateTime.UtcNow;
        return entity;
    }

}

