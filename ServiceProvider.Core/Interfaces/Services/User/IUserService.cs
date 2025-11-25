
using ServiceProvider.Core.DTOs.User;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IUserService
{
	Task<User?> GetByIdAsync(Guid id);
	Task<string> LoginAsync(string email, string password);
	IQueryable<User> GetList();
	IQueryable<UserPaged> GetListPaged();
	Task<User> AddAsync(User input, EntityLogInfo logInfo);
	Task<User> UpdateAsync(User input, EntityLogInfo logInfo, User? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}