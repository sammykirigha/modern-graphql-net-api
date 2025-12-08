using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces.Repositories.Auth;
using ServiceProvider.Core.Models.Auth;
using ServiceProvider.Data.Contexts;
using System.Text.Json;

namespace ServiceProvider.Data.Repositories.Auth;

public class RefreshTokenRepository(ServiceProviderContext Context): RepositoryBase(Context), IRefreshTokenRepository
{
	public async Task<RefreshToken> AddAsync(RefreshToken entity)
	{
		var jsonString = JsonSerializer.Serialize(entity);
		var newentity = JsonSerializer.Deserialize<RefreshToken>(jsonString) ??
		                throw new AppException("Json conversion error for add RefreshToken");
		newentity.Id = Guid.NewGuid();
		newentity.DateCreated = DateTime.UtcNow;
		newentity.DateModified = DateTime.UtcNow;

		Context.RefreshTokens.Add(newentity);
		await Context.SaveChangesAsync();
		return newentity;
	}
	
	public async Task<RefreshToken?> GetByTokenAsync(string token)
	{
		var entity = await Context.RefreshTokens.FindAsync(token);
		return entity;
	}
}