
using System.Text.Json;
using HotChocolate.Authorization;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.GraphQL;


[Authorize]
[QueryType]
public static class UserPermissionMutation
{
    public static async Task<UserPermission> AddUserPermission(UserPermissionMutationInput userPermission, IUserPermissionService service, EntityLogInfo logInfo)
    {
        try
        {
            userPermission.Id.CheckRequired();
            userPermission.UserId.CheckRequired();
            userPermission.PermissionId.CheckRequired();
        
            var entity = PopulateEntity(new UserPermission(), userPermission);
            entity = await service.AddAsync(entity, logInfo);
            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }

    }
    
    public static async Task<UserPermission> UpdateUserPermission(UserPermissionMutationInput userPermission, IUserPermissionService service, EntityLogInfo logInfo)
    {
        try
        {
            userPermission.Id.CheckRequired();
            userPermission.UserId.CheckRequired();
            userPermission.PermissionId.CheckRequired();
        
            var entity = await service.GetByIdAsync(userPermission.Id.Value)
                         ?? throw new AppException($"{nameof(UserPermission)} not found.", ValidationCode.MissingRequirementEntity);
            var oldentity = JsonSerializer.Serialize(entity).Deserialize<UserPermission>();
            PopulateEntity(entity, userPermission);
        
            entity = await service.UpdateAsync(entity, logInfo, oldentity);
            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }

    }
    
    public static async Task<bool> DeleteUserPermission(Guid id, EntityLogInfo logInfo, IUserPermissionService service)
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
    private static UserPermission PopulateEntity(UserPermission entity, UserPermissionMutationInput input)
    {
        entity.UserId = input.UserId.CheckForValue(entity.UserId);
        entity.PermissionId = input.PermissionId.CheckForValue(entity.PermissionId);
		
        entity.DateCreated = input.DateCreated.CheckForValue(entity.DateCreated);
        entity.DateModified = DateTime.UtcNow;
        return entity;
    }
    
}

