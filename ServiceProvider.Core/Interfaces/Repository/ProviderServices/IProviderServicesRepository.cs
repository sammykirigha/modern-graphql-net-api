using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IProviderServicesRepository: IRepositoryBase
{
	Task<ProviderServices> AddAsync(ProviderServices entity);
	Task<ProviderServices> UpdateAsync(ProviderServices entity);
	Task<int> DeleteAsync(Guid id);
}