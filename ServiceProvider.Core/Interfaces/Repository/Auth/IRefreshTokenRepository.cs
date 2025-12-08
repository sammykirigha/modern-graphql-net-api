using ServiceProvider.Core.Models.Auth;

namespace ServiceProvider.Core.Interfaces.Repositories.Auth;

public interface IRefreshTokenRepository : IRepositoryBase
{
	Task<RefreshToken> AddAsync(RefreshToken entity);
	Task<RefreshToken?> GetByTokenAsync(string token);
}