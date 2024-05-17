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
public static class ClientMutation
{
    public static async Task<Client> AddClient(ClientMutationInput Client, EntityLogInfo logInfo, IClientService service)
    {
        try
        {
	        Client.Email.CheckRequired();
	        Client.FirstName.CheckRequired();
	        Client.LastName.CheckRequired();
	        Client.Phone.CheckRequired();
            Client.LocationId.CheckRequired();
            var entity = PopulateEntity(new Client(), Client);
            entity = await service.AddAsync(entity, logInfo);
            return entity;

        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<Client> UpdateClient(ClientMutationInput Client, EntityLogInfo logInfo, IClientService service)
    {
        try
        {
	        Client.Id.CheckRequired();
            var entity = await service.GetByIdAsync(Client.Id.Value)
                         ?? throw new AppException($"{nameof(Client)} not found.", ValidationCode.MissingRequirementEntity);
            var oldentity = JsonSerializer.Serialize(entity).Deserialize<Client>();
            PopulateEntity(entity, Client);

            entity = await service.UpdateAsync(entity, logInfo, oldentity);
            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<bool> DeleteClient(Guid id, EntityLogInfo logInfo, IClientService service)
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
    private static Client PopulateEntity(Client entity, ClientMutationInput input)
    {
        entity.Email = input.Email.CheckForValue(entity.Email);
        entity.FirstName = input.FirstName.CheckForValue(entity.FirstName);
        entity.LastName = input.LastName.CheckForValue(entity.LastName);
        entity.Phone = input.Phone.CheckForValue(entity.Phone);
        entity.LocationId = input.LocationId.CheckForValue(entity.LocationId);
		
        entity.DateCreated = input.DateCreated.CheckForValue(entity.DateCreated);
        entity.DateModified = DateTime.UtcNow;
        return entity;
    }

}

