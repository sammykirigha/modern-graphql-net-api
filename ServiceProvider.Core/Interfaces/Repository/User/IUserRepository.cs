
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IUserRepository : IRepositoryBase
{
    Task<User?> GetByIdAsync(Guid id);
    IQueryable<User> GetList();
    Task<User> AddAsync(User entity);
    Task<User> UpdateAsync(User entity);
    Task<bool> DeleteAsync(Guid id);
}

