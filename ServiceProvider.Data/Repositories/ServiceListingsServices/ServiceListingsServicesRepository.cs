using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;
using System.Text.Json;

namespace ServiceProvider.Data.Repositories;

public class ServiceListingsServicesRepository(ServiceProviderContext Context): RepositoryBase(Context), IServiceListingsServicesRepository
{
	public async Task<ServiceListingsServices> AddAsync(ServiceListingsServices entity)
	{
		var jsonString = JsonSerializer.Serialize(entity);
		var newentity = JsonSerializer.Deserialize<ServiceListingsServices>(jsonString) ??
		                throw new AppException("Json conversion error for add County");
		newentity.Id = Guid.NewGuid();
		newentity.DateCreated = DateTime.UtcNow;
		newentity.DateModified = DateTime.UtcNow;

		Context.ServiceListingsServices.Add(newentity);
		await Context.SaveChangesAsync();
		return newentity;
	}
	
	public async 	Task<ICollection<ServiceListingsServices>> AddRangeAsync(ICollection<ServiceListingsServices> entities)
	{
		var newEntities = new List<ServiceListingsServices>();
		foreach (var entity in entities)
		{
			var jsonString = JsonSerializer.Serialize(entity);
			var newentity = JsonSerializer.Deserialize<ServiceListingsServices>(jsonString) ??
			                throw new AppException("Json conversion error for add ServiceListingsServices");
			newentity.Id = Guid.NewGuid();
			newentity.DateCreated = DateTime.UtcNow;
			newentity.DateModified = DateTime.UtcNow;
			newEntities.Add(newentity);
		}

		await Context.ServiceListingsServices.AddRangeAsync(newEntities);
		await Context.SaveChangesAsync();
		return newEntities;
	}
	
	public async Task<ServiceListingsServices> UpdateAsync(ServiceListingsServices entity)
	{
		if (entity.Id == Guid.Empty)
			throw new AppException("Id missing for Role update");
		Context.Entry(entity).State = EntityState.Modified;
		entity.DateModified = DateTime.UtcNow;
		await Context.SaveChangesAsync();

		return entity;
	}

	public async Task<int> DeleteAsync(Guid id)
	{
		var result = await Context.ServiceListingsServices.Where(x => x.Id == id).ExecuteDeleteAsync();
		return result;
	}
}