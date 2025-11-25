
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IUserRepository : IRepositoryBase
{
    Task<User?> GetByIdAsync(Guid id);
    Task<User?> GetByEmailAsync(string email);
    IQueryable<User> GetList();
    Task<User> AddAsync(User entity);
    Task<User> UpdateAsync(User entity);
    Task<int> DeleteAsync(Guid id);
}

