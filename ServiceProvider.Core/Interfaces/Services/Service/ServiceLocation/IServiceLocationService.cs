using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IServiceLocationService
{
	Task<ServiceLocation?> GetByIdAsync(Guid id);
	IQueryable<ServiceLocation> GetList();
	IQueryable<ServiceLocationPaged> GetPagedList();
	Task<ServiceLocation> AddAsync(ServiceLocation entity, EntityLogInfo logInfo);
	Task<ServiceLocation> UpdateAsync(ServiceLocation entity, EntityLogInfo logInfo, ServiceLocation? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}