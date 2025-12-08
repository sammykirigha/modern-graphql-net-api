using ServiceProvider.Core.Models.Auth;

namespace ServiceProvider.Core.Interfaces.Services.Auth;

public interface IRefreshTokenService
{
	Task<RefreshToken> AddAsync(RefreshToken entity);
}