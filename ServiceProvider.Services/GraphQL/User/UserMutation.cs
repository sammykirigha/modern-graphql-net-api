﻿using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using System.Text.Json;


namespace Graphql.Services.GraphQL;

public static class UserMutation
{
    public static async Task<User> AddUser(UserMutationInput user, EntityLogInfo logInfo, IUserService service)
    {
        try
        {
            user.Email.CheckRequired();
            user.FirstName.CheckRequired();
            user.LastName.CheckRequired();
            user.Phone.CheckRequired();
            var entity = PopulateEntity(new User(), user);
            entity = await service.AddAsync(entity, logInfo);
            return entity;

        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<User> UpdateUser(UserMutationInput user, EntityLogInfo logInfo, IUserService service)
    {
        try
        {
            user.Id.CheckRequired();
            var entity = await service.GetByIdAsync(user.Id.Value)
                         ?? throw new AppException($"{nameof(User)} not found.", ValidationCode.MissingRequirementEntity);
            var oldentity = JsonSerializer.Serialize(entity).Deserialize<User>();
            PopulateEntity(entity, user);

            entity = await service.UpdateAsync(entity, logInfo, oldentity);
            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<bool> DeleteUser(Guid id, EntityLogInfo logInfo, IUserService service)
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
    private static User PopulateEntity(User entity, UserMutationInput input)
    {
        entity.Email = input.Email.CheckForValue(entity.Email);
        entity.FirstName = input.FirstName.CheckForValue(entity.FirstName);
        entity.LastName = input.LastName.CheckForValue(entity.LastName);
        entity.Phone = input.Phone.CheckForValue(entity.Phone);
		
        entity.DateCreated = input.DateCreated.CheckForValue(entity.DateCreated);
        entity.DateModified = DateTime.UtcNow;
        return entity;
    }

}
