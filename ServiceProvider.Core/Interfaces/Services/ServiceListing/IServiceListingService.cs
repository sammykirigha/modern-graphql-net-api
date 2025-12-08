using ServiceProvider.Core.DTOs.ServiceListing;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IServiceListingService
{
	Task<ServiceListing?> GetByIdAsync(Guid id);
	IQueryable<ServiceListing> GetList();
	Task<ServiceListing> AddAsync(CreateServiceListingDto entity, EntityLogInfo logInfo);
	Task<ServiceListing> UpdateAsync(ServiceListing entity, EntityLogInfo logInfo, ServiceListing? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}