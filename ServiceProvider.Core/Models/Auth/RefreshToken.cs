using ServiceProvider.Core.Interfaces.Models;
using System.Text.Json.Serialization;

namespace ServiceProvider.Core.Models.Auth;

public partial class RefreshToken : IEntity
{
	public Guid Id { get; set; }
	public string Token { get; set; }
	public DateTime Expires { get; set; }
	public bool IsExpired => DateTime.UtcNow >= Expires;
	public DateTime? Revoked { get; set; }
	public bool IsActive => Revoked == null && !IsExpired;
	public Guid UserId { get; set; }
	public DateTime DateCreated { get; set; } = DateTime.UtcNow;
	public DateTime DateModified { get; set; } = DateTime.UtcNow;
	
	[JsonIgnore] public virtual User? User { get; set; }
}