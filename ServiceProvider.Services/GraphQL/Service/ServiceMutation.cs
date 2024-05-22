using HotChocolate.Authorization;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using System.Text.Json;


namespace Graphql.Services.GraphQL;

[Authorize]
[MutationType]
public static class ServiceMutation
{
    public static async Task<Service> AddService(ServiceMutationInput srv, EntityLogInfo logInfo, IServiceService service)
    {
        try
        {
            srv.Name.CheckRequired();
            srv.Price.CheckRequired();
            srv.CategoryId.CheckRequired();
            srv.ClientId.CheckRequired();
            

            var entity = PopulateEntity(new Service(), srv);
            entity = await service.AddAsync(entity, logInfo);
            return entity;

        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<Service> UpdateService(ServiceMutationInput srv, EntityLogInfo logInfo, IServiceService service)
    {
        try
        {
            srv.Id.CheckRequired();
            var entity = await service.GetByIdAsync(srv.Id.Value)
                         ?? throw new AppException($"{nameof(Service)} not found.", ValidationCode.MissingRequirementEntity);
            var oldentity = JsonSerializer.Serialize(entity).Deserialize<Service>();
            PopulateEntity(entity, srv);

            entity = await service.UpdateAsync(entity, logInfo, oldentity);
            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<bool> DeleteService(Guid id, EntityLogInfo logInfo, IServiceService service)
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
    private static Service PopulateEntity(Service entity, ServiceMutationInput input)
    {
        entity.Name = input.Name.CheckForValue(entity.Name);
        entity.Price = input.Price.CheckForValue(entity.Price);
        entity.ClientId = input.ClientId.CheckForValue(entity.ClientId);
        entity.CategoryId = input.CategoryId.CheckForValue(entity.CategoryId);
        entity.LocationId = input.LocationId.CheckForValue(entity.LocationId);
		
        entity.DateCreated = input.DateCreated.CheckForValue(entity.DateCreated);
        entity.DateModified = DateTime.UtcNow;
        return entity;
    }

}

