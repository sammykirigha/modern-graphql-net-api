
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface ICategoryRepository : IRepositoryBase
{
    Task<Category?> GetByIdAsync(Guid id);
    IQueryable<Category> GetList();
    Task<Category> AddAsync(Category entity);
    Task<Category> UpdateAsync(Category entity);
    Task<int> DeleteAsync(Guid id);
}