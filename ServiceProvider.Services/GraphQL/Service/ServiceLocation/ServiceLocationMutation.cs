using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using System.Text.Json;


namespace Graphql.Services.GraphQL;

public static class ServiceLocationMutation
{
    public static async Task<ServiceLocation> AddServiceLocation(ServiceLocationMutationInput srv, EntityLogInfo logInfo, IServiceLocationService service)
    {
        try
        {
            srv.ServiceId.CheckRequired();
            srv.LocationId.CheckRequired();

            var entity = PopulateEntity(new ServiceLocation(), srv);
            entity = await service.AddAsync(entity, logInfo);
            return entity;

        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<ServiceLocation> UpdateServiceLocation(ServiceLocationMutationInput srv, EntityLogInfo logInfo, IServiceLocationService service)
    {
        try
        {
            srv.Id.CheckRequired();
            var entity = await service.GetByIdAsync(srv.Id.Value)
                         ?? throw new AppException($"{nameof(ServiceLocation)} not found.", ValidationCode.MissingRequirementEntity);
            var oldentity = JsonSerializer.Serialize(entity).Deserialize<ServiceLocation>();
            PopulateEntity(entity, srv);

            entity = await service.UpdateAsync(entity, logInfo, oldentity);
            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<bool> DeleteServiceLocation(Guid id, EntityLogInfo logInfo, IServiceLocationService service)
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
    private static ServiceLocation PopulateEntity(ServiceLocation entity, ServiceLocationMutationInput input)
    {
        entity.ServiceId = input.ServiceId.CheckForValue(entity.ServiceId);
        entity.LocationId = input.LocationId.CheckForValue(entity.LocationId);
		
        entity.DateCreated = input.DateCreated.CheckForValue(entity.DateCreated);
        entity.DateModified = DateTime.UtcNow;
        return entity;
    }

}

