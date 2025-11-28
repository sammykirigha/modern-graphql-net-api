using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repository.Medias;
using ServiceProvider.Core.Models.Medias;
using ServiceProvider.Data.Contexts;
using System.Text.Json;

namespace ServiceProvider.Data.Repositories.Medias;

public class MediaRepository(ServiceProviderContext context) 
	: RepositoryBase(context), IMediaRepository
{
	public IQueryable<Media> GetList() => from i in Context.Media select i;

	public async Task<Media> AddAsync(Media entity)
	{
		var jsonString = JsonSerializer.Serialize(entity);
		var newentity = JsonSerializer.Deserialize<Media>(jsonString) ??
		                throw new AppException("Json conversion error for add Role");
		newentity.Id = Guid.NewGuid();
		newentity.DateCreated = DateTime.UtcNow;
		newentity.DateModified = DateTime.UtcNow;

		Context.Media.Add(newentity);
		await Context.SaveChangesAsync();
		return newentity;
	}
	
	public async Task<Media> UpdateAsync(Media entity)
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
		var result = await Context.Roles.Where(x => x.Id == id).ExecuteDeleteAsync();
		return result;
	}
}