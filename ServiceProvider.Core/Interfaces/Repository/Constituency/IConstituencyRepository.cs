using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces;

public interface IConstituencyRepository: IRepositoryBase
{
	Task<Constituency> AddAsync(Constituency user);
	IQueryable<Constituency> GetList();
	Task<Constituency?> GetByNameAsync(string Name);
	Task<Constituency?> GetByIdAsync(Guid id);
}