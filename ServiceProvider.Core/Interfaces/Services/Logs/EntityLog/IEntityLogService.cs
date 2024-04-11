using ServiceProvider.Core.Interfaces.Models;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IEntityLogService
{
	Task<EntityLog> LogChangeAsync(EntityLog log);
	Task<ICollection<EntityLog>> LogChangesAsync(ICollection<EntityLog> logs);


	// INFO
	Task<EntityLog> LogInfoAsync<T>(EntityLogInfo info, T newEntity, UserProfile? user = null)
		where T : IEntity?;

	Task<ICollection<EntityLog>> LogInfoListAsync<T>(EntityLogInfo info, ICollection<T> newEntityList, UserProfile? user = null)
		where T : IEntity?;


	// ADD
	Task<EntityLog> LogAddAsync<T>(EntityLogInfo info, T newEntity, UserProfile? user = null)
		where T : IEntity?;

	Task<ICollection<EntityLog>> LogAddListAsync<T>(EntityLogInfo info, ICollection<T> newEntityList, UserProfile? user = null)
		where T : IEntity?;

	// UPDATE
	Task<EntityLog> LogUpdateAsync<T>(EntityLogInfo info, T newEntity, T oldEntity, UserProfile? user = null)
		where T : IEntity?;

	Task<ICollection<EntityLog>> LogUpdateListAsync<T>(EntityLogInfo info, ICollection<EntityLogUpdatedItem<T>> updateEntityList, UserProfile? user = null)
		where T : IEntity?;

	ICollection<EntityLogUpdatedItem<T>> BuildUpdateEntityList<T>(ICollection<T> newEntityList, ICollection<T> oldEntityList)
		where T : IEntity?;


	// DELETE
	Task<EntityLog> LogDeleteAsync<T>(EntityLogInfo info, T deletedEntity, UserProfile? user = null)
		where T : IEntity?;

	Task<ICollection<EntityLog>> LogDeleteListAsync<T>(EntityLogInfo info, ICollection<T> deletedEntityList, UserProfile? user = null)
		where T : IEntity?;


	// ENTITY LOG INFO
	//Task<EntityLogInfo> PopulateEmployeeInfoAsync(EntityLogInfo logInfo, Guid employeeId);

	//Task<EntityLogInfo> PopulateDependentInfoAsync(EntityLogInfo logInfo, Guid dependentId);


	// QUERIES
	Task<EntityLog?> GetByIdAsync(Guid id);

	IQueryable<EntityLog> GetList();

	IQueryable<EntityLogPaged> GetPagedList();
}