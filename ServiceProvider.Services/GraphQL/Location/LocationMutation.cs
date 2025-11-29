using System.Text.Json;
using HotChocolate.Authorization;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using Location = ServiceProvider.Core.Models.Location;

namespace Graphql.Services.GraphQL;

[Authorize]
[MutationType]
public static class LocationMutation
{
    public static async Task<Location> AddLocation(LocationMutationInput Location, EntityLogInfo logInfo, ILocationService service)
    {
        try
        {
           var entity = PopulateEntity(new Location(), Location);
           entity = await service.AddAsync(entity, logInfo);

           return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }

    public static async Task<Location> UpdateLocation(LocationMutationInput input, EntityLogInfo log, ILocationService service)
    {
        try
        {
            input.Id.CheckRequired();
            var entity = await service.GetByIdAsync(input.Id.Value)
                         ?? throw new AppException($"{nameof(Location)} not found.", ValidationCode.MissingRequirementEntity);
            var oldentity = JsonSerializer.Serialize(entity).Deserialize<Location>();
            PopulateEntity(entity, input);

            entity = await service.UpdateAsync(entity, log, oldentity);
            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<bool> DeleteLocation(Guid id, EntityLogInfo logInfo, ILocationService service)
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
    private static Location PopulateEntity(Location entity, LocationMutationInput input)
    {
        entity.DateCreated = input.DateCreated.CheckForValue(entity.DateCreated);
        entity.DateModified = DateTime.UtcNow;

        return entity;
    }
}