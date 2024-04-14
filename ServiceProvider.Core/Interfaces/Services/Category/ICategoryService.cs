using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface ICategoryService
{
	Task<Category?> GetByIdAsync(Guid id);
	IQueryable<Category> GetList();
	IQueryable<CategoryPaged> GetPagedList();
	Task<Category> AddAsync(Category entity, EntityLogInfo logInfo);
	Task<Category> UpdateAsync(Category entity, EntityLogInfo logInfo, Category? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}