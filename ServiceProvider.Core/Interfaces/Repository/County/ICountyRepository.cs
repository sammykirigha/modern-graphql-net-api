using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface ICountyRepository: IRepositoryBase
{
	Task<County> AddAsync(County user);
	IQueryable<County> GetList();
	Task<County?> GetByNameAsync(string Name);
	Task<County?> GetByIdAsync(Guid id);
}