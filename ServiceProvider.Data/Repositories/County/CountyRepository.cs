using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts;
using System.Text.Json;

namespace ServiceProvider.Data.Repositories;

public class CountyRepository(ServiceProviderContext context): RepositoryBase(context), ICountyRepository
{
	public async Task<County?> GetByIdAsync(Guid id)
	{
		var entity = await Context.Counties.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
		return entity;
	}	
	
	public async Task<County?> GetByNameAsync(string Name)
	{
		var entity = await Context.Counties.AsNoTracking().FirstOrDefaultAsync(x => x.CountyName == Name);
		return entity;
	}

	public IQueryable<County> GetList() => from i in Context.Counties select i;

	public async Task<County> AddAsync(County entity)
	{
		var jsonString = JsonSerializer.Serialize(entity);
		var newentity = JsonSerializer.Deserialize<County>(jsonString) ??
		                throw new AppException("Json conversion error for add County");
		newentity.Id = Guid.NewGuid();
		newentity.DateCreated = DateTime.UtcNow;
		newentity.DateModified = DateTime.UtcNow;

		Context.Counties.Add(newentity);
		await Context.SaveChangesAsync();
		return newentity;
	}
}