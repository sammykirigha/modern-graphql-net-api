using ServiceProvider.Core.DTOs.ServiceListing;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Repositories;

public interface IServiceListingRepository : IRepositoryBase
{
	Task<ServiceListing?> GetByIdAsync(Guid id);
	IQueryable<ServiceListing> GetList();
	Task<ServiceListing> AddAsync(CreateServiceListingDto entity);
	Task<ServiceListing> GetByIdWithServicesAsync(Guid id);
	Task<ServiceListing> UpdateAsync(ServiceListing entity);
	Task<int> DeleteAsync(Guid id);
}