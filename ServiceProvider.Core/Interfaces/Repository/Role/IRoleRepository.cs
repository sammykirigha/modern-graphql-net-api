
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IRoleRepository : IRepositoryBase
{
    Task<Role?> GetByIdAsync(Guid id);
    IQueryable<Role> GetList();
    Task<Role> AddAsync(Role entity);
    Task<Role> UpdateAsync(Role entity);
    Task<int> DeleteAsync(Guid id);
}

