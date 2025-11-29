using ServiceProvider.Core.Classes;
using HotChocolate.Authorization;
using ServiceProvider.Core.DTOs.User;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

using System.Text.Json;


namespace Graphql.Services.GraphQL;
[MutationType]
public static class ServiceProoviderEntityMutation
{
	[AllowAnonymous]
    public static async Task<ServiceProviderCreatedDto> AddServiceProviderEntity(ServiceProviderMutationInput serviceProvider, EntityLogInfo logInfo, IServiceProviderEntityService service)
    {
        try
        {
	        serviceProvider.Email.CheckRequired();
	        serviceProvider.FirstName.CheckRequired();
	        serviceProvider.LastName.CheckRequired();
	        serviceProvider.Phone.CheckRequired();
	        serviceProvider.BusinessName.CheckRequired();
	        serviceProvider.BusinessDescription.CheckRequired();
            var entity = PopulateEntity(new ServiceProviderEntity(), serviceProvider);
            
            await service.AddAsync(entity, logInfo);
            
            return new ServiceProviderCreatedDto()
            {
	            Message = "Service Provider created successfully. Please check your email to activate your account and set your password."
            };

        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
	[AllowAnonymous]
    public static async Task<ServiceProviderEntity> UpdateServiceProvider(ServiceProviderMutationInput input, EntityLogInfo logInfo, IServiceProviderEntityService service)
    {
        try
        {
	        input.Id.CheckRequired();
            var entity = await service.GetByIdAsync(input.Id.Value)
                         ?? throw new AppException($"{nameof(input)} not found.", ValidationCode.MissingRequirementEntity);
            var oldentity = JsonSerializer.Serialize(entity).Deserialize<ServiceProviderEntity>();
            PopulateEntity(entity, input);

            entity = await service.UpdateAsync(entity, logInfo, oldentity);
            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
	[AllowAnonymous]
    public static async Task<LoginUserDTO> ActivateAccountAndResetPassword(ResetPasswordInputDto input, IServiceProviderEntityService service)
    {
	    try
	    {
		    if (string.IsNullOrEmpty(input.Token))
			    throw new AppException("Email can not be null");

		    var result = await service.ActivateAccountAndResetPassword(input.Token, input.NewPassword, input.ConfirmPassword);
		    return  new LoginUserDTO()
		    {
			    Token = result
		    };
	    }
	    catch (Exception e)
	    {
		    Console.WriteLine(e);
		    throw;
	    }
    }
    
    public static async Task<bool> DeleteServiceProvider(Guid id, EntityLogInfo logInfo, IServiceProviderEntityService service)
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
    private static ServiceProviderEntity PopulateEntity(ServiceProviderEntity entity, ServiceProviderMutationInput input)
    {
        entity.Email = input.Email.CheckForValue(entity.Email);
        entity.FirstName = input.FirstName.CheckForValue(entity.FirstName);
        entity.LastName = input.LastName.CheckForValue(entity.LastName);
        entity.BusinessName = input.BusinessName.CheckForValue(entity.BusinessName);
        entity.BusinessDescription = input.BusinessDescription.CheckForValue(entity.BusinessDescription);
        entity.Phone = input.Phone.CheckForValue(entity.Phone);
		
        entity.DateCreated = input.DateCreated.CheckForValue(entity.DateCreated);
        entity.DateModified = DateTime.UtcNow;
        return entity;
    }
}

