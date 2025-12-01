using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;
using System.Text.Json;

namespace ServiceProvider.Data.Repositories.ProviderServicers;

public class ProviderServicesRepository(ServiceProviderContext Context): RepositoryBase(Context), IProviderServicesRepository
{
	public async Task<ProviderServices> AddAsync(ProviderServices entity)
	{
		var jsonString = JsonSerializer.Serialize(entity);
		var newentity = JsonSerializer.Deserialize<ProviderServices>(jsonString) ??
		                throw new AppException("Json conversion error for add County");
		newentity.Id = Guid.NewGuid();
		newentity.DateCreated = DateTime.UtcNow;
		newentity.DateModified = DateTime.UtcNow;

		Context.ProviderServices.Add(newentity);
		await Context.SaveChangesAsync();
		return newentity;
	}
	
	public async Task<ProviderServices> UpdateAsync(ProviderServices entity)
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
		var result = await Context.ProviderServices.Where(x => x.Id == id).ExecuteDeleteAsync();
		return result;
	}
}