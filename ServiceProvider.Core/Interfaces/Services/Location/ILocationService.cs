
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface ILocationService
{
	Task<Location?> GetByIdAsync(Guid id);
	IQueryable<Location> GetList();
	IQueryable<LocationPaged> GetPagedList();
	Task<Location> AddAsync(Location entity, EntityLogInfo logInfo);
	Task<Location> UpdateAsync(Location entity, EntityLogInfo logInfo, Location? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}