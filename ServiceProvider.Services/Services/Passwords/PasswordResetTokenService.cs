using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ServiceProvider.Core.Interfaces.Passwords;
using ServiceProvider.Core.Settings;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ServiceProvider.Services.Services.EmailService;
public class PasswordResetTokenService : IPasswordResetTokenService
{
	private readonly string _secret;

	public PasswordResetTokenService(IOptions<JwtSettings> jwtsettings)
	{
		_secret = jwtsettings.Value.ResetSecret;
		if (string.IsNullOrWhiteSpace(_secret))
			throw new InvalidOperationException("ResetSecret is missing or empty in configuration");
	}

	public string GenerateResetToken(string email)
	{
		var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secret));
		var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

		var token = new JwtSecurityToken(
			claims: new []
			{
				new Claim("email", email),
				new Claim("purpose", "password-reset")
			},
			expires: DateTime.UtcNow.AddHours(5),
			signingCredentials: creds
		);

		return new JwtSecurityTokenHandler().WriteToken(token);
	}
		
	public string DecodeResetToken(string token)
	{
		var handler = new JwtSecurityTokenHandler();
		var key = Encoding.UTF8.GetBytes(_secret);
			
		handler.ValidateToken(token, new TokenValidationParameters
		{
			ValidateIssuer = false,
			ValidateAudience = false,
			ValidateIssuerSigningKey = true,
			IssuerSigningKey = new SymmetricSecurityKey(key),
			ValidateLifetime = true,
			ClockSkew = TimeSpan.Zero
		}, out SecurityToken validatedToken);
			
		var jwtToken = (JwtSecurityToken)validatedToken;

		return jwtToken.Claims.First(c => c.Type == "email").Value;
	}
}