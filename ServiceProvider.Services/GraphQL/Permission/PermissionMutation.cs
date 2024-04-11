using System.Text.Json;

using HotChocolate.Authorization;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;

[Authorize]
[MutationType]
public static class PermissionMutation
{
    public static async Task<Permission> AddPermission(PermissionMutationInput permission, EntityLogInfo logInfo, IPermissionService service)
    {

        try
        {
            permission.Name.CheckRequired();
        
            var entity = PopulateEntity(new Permission(), permission);
            entity = await service.AddAsync(entity, logInfo);

            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }


    }
    
    public static async Task<Permission> UpdatePermission(PermissionMutationInput input, EntityLogInfo log, IPermissionService service)
    {
        try
        {
            input.Id.CheckRequired();
            var entity = await service.GetByIdAsync(input.Id.Value)
                         ?? throw new AppException($"{nameof(Permission)} not found.", ValidationCode.MissingRequirementEntity);
            var oldentity = JsonSerializer.Serialize(entity).Deserialize<Permission>();
            PopulateEntity(entity, input);

            entity = await service.UpdateAsync(entity, log, oldentity);
            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<bool> DeletePermission(Guid id, EntityLogInfo logInfo, IPermissionService service)
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
    private static Permission PopulateEntity(Permission entity, PermissionMutationInput input)
    {
        entity.Name = input.Name.CheckForValue(entity.Name);

        entity.DateCreated = input.DateCreated.CheckForValue(entity.DateCreated);
        entity.DateModified = DateTime.UtcNow;

        return entity;
    }
}

