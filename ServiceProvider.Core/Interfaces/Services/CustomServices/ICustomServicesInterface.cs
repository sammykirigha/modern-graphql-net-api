using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services.CustomServices;

public interface ICustomServicesInterface
{
	Task<CustomService?> GetByIdAsync(Guid id);
	IQueryable<CustomService> GetList();
	Task<CustomService> AddAsync(CustomService entity, EntityLogInfo logInfo);
	Task<CustomService> UpdateAsync(CustomService entity, EntityLogInfo logInfo, CustomService? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}