using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;
using System.Text.Json;

namespace ServiceProvider.Data.Repositories.CustomServices;

public class CustomServicesRepository(ServiceProviderContext context) 
	: RepositoryBase(context), ICustomServicesInterface
{
	public async Task<CustomService?> GetByIdAsync(Guid id)
	{
		var entity = await Context.CustomServices.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
		return entity;
	}

	public IQueryable<CustomService> GetList() => from i in Context.CustomServices select i;

	public async Task<CustomService> AddAsync(CustomService entity)
	{
		var jsonString = JsonSerializer.Serialize(entity);
		var newentity = JsonSerializer.Deserialize<CustomService>(jsonString) ??
		                throw new AppException("Json conversion error for add CustomService");
		newentity.Id = Guid.NewGuid();
		newentity.DateCreated = DateTime.UtcNow;
		newentity.DateModified = DateTime.UtcNow;

		Context.CustomServices.Add(newentity);
		await Context.SaveChangesAsync();
		return newentity;
	}

	public async Task<CustomService> UpdateAsync(CustomService entity)
	{
		if (entity.Id == Guid.Empty)
			throw new AppException("Id missing for CustomService update");
		Context.Entry(entity).State = EntityState.Modified;
		entity.DateModified = DateTime.UtcNow;
		await Context.SaveChangesAsync();

		return entity;
	}

	public async Task<int> DeleteAsync(Guid id)
	{
		var result = await Context.CustomServices.Where(x => x.Id == id).ExecuteDeleteAsync();
		return result;
	}
}