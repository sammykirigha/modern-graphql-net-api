
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;
public interface ICustomServicesInterface: IRepositoryBase
{
	Task<CustomService?> GetByIdAsync(Guid id);
	IQueryable<CustomService> GetList();
	Task<CustomService> AddAsync(CustomService entity);
	Task<CustomService> UpdateAsync(CustomService entity);
	Task<int> DeleteAsync(Guid id);
}