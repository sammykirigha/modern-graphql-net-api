using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services.ProviderServices;

public interface IProviderServicesInterface
{
	Task<ProviderLocations?> GetByIdAsync(Guid id);
	IQueryable<ProviderLocations> GetList();
	Task<ProviderLocations> AddAsync(ProviderLocations entity, EntityLogInfo logInfo);
	Task<ProviderLocations> UpdateAsync(ProviderLocations entity, EntityLogInfo logInfo, ProviderLocations? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}