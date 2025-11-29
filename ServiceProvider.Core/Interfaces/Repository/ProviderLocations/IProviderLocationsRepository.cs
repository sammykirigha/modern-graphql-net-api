using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IProviderLocationsRepository: IRepositoryBase
{
	Task<ProviderLocations> AddAsync(ProviderLocations entity);
	Task<ProviderLocations> UpdateAsync(ProviderLocations entity);
	Task<int> DeleteAsync(Guid id);
}