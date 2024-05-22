using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces.Services;

public interface IPlanService
{
	Task<Plan?> GetByIdAsync(Guid id);
	IQueryable<Plan> GetList();
	IQueryable<PlanPaged> GetPagedList();
	Task<Plan> AddAsync(Plan entity, EntityLogInfo logInfo);
	Task<Plan> UpdateAsync(Plan entity, EntityLogInfo logInfo, Plan? oldEntity = null);
	Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo);
}