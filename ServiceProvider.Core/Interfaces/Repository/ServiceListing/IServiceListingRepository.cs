using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IServiceListingRepository : IRepositoryBase
{
	Task<ServiceListing?> GetByIdAsync(Guid id);
	IQueryable<ServiceListing> GetList();
	Task<ServiceListing> AddAsync(ServiceListing entity);
	Task<ServiceListing> UpdateAsync(ServiceListing entity);
	Task<int> DeleteAsync(Guid id);
}