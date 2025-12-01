using ServiceProvider.Core.Classes;
using HotChocolate.Authorization;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Models;
using System.Text.Json;
using ServiceProvider.Core.DTOs.User;
using ServiceProvider.Core.Interfaces.Services.Users;


namespace Graphql.Services.GraphQL;

[MutationType]
public static class UserMutation
{
    [AllowAnonymous]
    public static async Task<CreateUserDto> AddUser(UserMutationInput user, EntityLogInfo logInfo, IUserService service)
    {
        try
	        {
	            user.Email.CheckRequired();
	            user.FirstName.CheckRequired();
	            user.LastName.CheckRequired();
	            user.Password.CheckRequired();

	            var entity = PopulateEntity(new CreateUserDto(), user);

	            entity = await service.AddAsync(entity, logInfo);

	            return entity;
	        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }

    [AllowAnonymous]
    public static async Task<LoginUserDTO> LoginUser(UserLoginMutationInput user, IUserService service)
    {
        try
        {
            user.Email.CheckRequired();
            user.Password.CheckRequired();

            var token = await service.LoginAsync(user.Email, user.Password);
            var userToken = new LoginUserDTO { Token = token };
            return userToken;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    [AllowAnonymous]
    public static async Task<ForgetPasswordResponseDto> ForgetPassword(ForgetPasswordInputDto input, IUserService service)
    {
	    try
	    {
		    if (string.IsNullOrEmpty(input.Email))
			    throw new AppException("Email can not be null");

		    var result = await service.ForgetPassword(input.Email);

		    return  new ForgetPasswordResponseDto
		    {
			    Message = result
		    };
	    }
	    catch (Exception e)
	    {
		    Console.WriteLine(e);
		    throw;
	    }
    }
    
    [AllowAnonymous]
    public static async Task<ResetPasswordResponseDto> ResetPassword(ResetPasswordInputDto input, IUserService service)
    {
	    try
	    {
		    if (string.IsNullOrEmpty(input.Token))
			    throw new AppException("Email can not be null");

		    var result = await service.ResetPassword(input.Token, input.NewPassword, input.ConfirmPassword);

		    return new ResetPasswordResponseDto
		    {
			    Success = result, Message = result ? "Password reset successful" : "Password reset failed"
		    };
	    }
	    catch (Exception e)
	    {
		    Console.WriteLine(e);
		    throw;
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

    public static async Task<bool> ActivateAccount(string token, IUserService service)
	{
		try
		{
			var result = await service.ActivateAccount(token);
			return result;
		}
		catch (AppException ex)
		{
			throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
		}
	}
    [GraphQLIgnore]
    private static T PopulateEntity<T>(T entity, UserMutationInput input) where T : class, IUserInput
    {
        entity.Email = input.Email.CheckForValue(entity.Email);
        entity.FirstName = input.FirstName.CheckForValue(entity.FirstName);
        entity.LastName = input.LastName.CheckForValue(entity.LastName);
        entity.Password = input.Password.CheckForValue(entity.Password);
        
        return entity;
    }

}

