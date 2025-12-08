
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IServiceListingsServicesRepository : IRepositoryBase
{
	Task<ServiceListingsServices> AddAsync(ServiceListingsServices entity);
	Task<ICollection<ServiceListingsServices>> AddRangeAsync(ICollection<ServiceListingsServices> entities);
	Task<ServiceListingsServices> UpdateAsync(ServiceListingsServices entity);
	Task<int> DeleteAsync(Guid id);
}