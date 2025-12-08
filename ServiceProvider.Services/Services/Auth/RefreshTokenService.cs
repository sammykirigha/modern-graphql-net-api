using ServiceProvider.Core.Interfaces.Repositories.Auth;
using ServiceProvider.Core.Interfaces.Services.Auth;
using ServiceProvider.Core.Models.Auth;

namespace ServiceProvider.Services.Auth;

public class RefreshTokenService : IRefreshTokenService
{
	private readonly IRefreshTokenRepository _refreshTokenRepository;
	public RefreshTokenService(IRefreshTokenRepository refreshTokenRepository)
	{
		_refreshTokenRepository = refreshTokenRepository;
	}
	
	public async Task<RefreshToken> AddAsync(RefreshToken entity)
	{
		return await _refreshTokenRepository.AddAsync(entity);
	}
}