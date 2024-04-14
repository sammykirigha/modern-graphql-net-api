using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IServiceService
{
	Task<Service?> GetByIdAsync(Guid id);
	IQueryable<Service> GetList();
	IQueryable<ServicePaged> GetPagedList();
	Task<Service> AddAsync(Service entity, EntityLogInfo logInfo);
	Task<Service> UpdateAsync(Service entity, EntityLogInfo logInfo, Service? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}