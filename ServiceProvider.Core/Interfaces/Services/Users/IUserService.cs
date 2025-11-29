using ServiceProvider.Core.DTOs.User;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services.Users;
public interface IUserService
{
	Task<User?> GetByIdAsync(Guid id);
	Task<string> LoginAsync(string email, string password);
	IQueryable<User> GetList();
	IQueryable<UserPaged> GetListPaged();
	Task<CreateUserDto> AddAsync(CreateUserDto input, EntityLogInfo logInfo);
	Task<User> UpdateAsync(User input, EntityLogInfo logInfo, User? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
	Task<string> ForgetPassword(string email);
	Task<bool> ResetPassword(string token, string  newpassword, string confirmPassword);
	Task<bool> ActivateAccount(string token);
}