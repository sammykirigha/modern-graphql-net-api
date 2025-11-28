using System.Text.Json.Serialization;
using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Interfaces.Models;
using ServiceProvider.Core.Interfaces.Services.Users;

namespace ServiceProvider.Core.Models;

public partial class User : IEntity, IUserInput
{
    /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Enabled/Disabled
    /// </summary>
    public bool IsActive { get; set; } = false;
    /// <summary>
	/// First name of user
	/// </summary>
	public string FirstName { get; set; } = "";
    /// <summary>
    /// Last name of user
    /// </summary>
    public string LastName { get; set; } = "";
    /// <summary>
    /// Primary email of user
    /// </summary>
    public string Email { get; set; } = "";
    /// <summary>
    /// Primary Password of user
    /// </summary>
    public string Password { get; set; } = "";
    /// <summary>
    /// Id of role (foreign key)
    /// </summary>
    public Guid? RoleId { get; set; }
    /// <summary>
    /// Date/time record created
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    /// <summary>
    /// Last date/time record changed
    /// </summary>
    public DateTime DateModified { get; set; } = DateTime.UtcNow;

    [JsonIgnore] public virtual Role? Role { get; set; }
    [JsonIgnore] public virtual ICollection<Review>? Reviews { get; set; } = new List<Review>();
    [JsonIgnore] public virtual ICollection<ErrorLog> ErrorLogsActive { get; set; } = new List<ErrorLog>();
    [JsonIgnore] public virtual ICollection<ErrorLog> ErrorLogsLoggedIn { get; set; } = new List<ErrorLog>();
    [JsonIgnore] public virtual ICollection<EntityLog> EntityLogsActive { get; set; } = new List<EntityLog>();
    [JsonIgnore] public virtual ICollection<EntityLog> EntityLogsLoggedIn { get; set; } = new List<EntityLog>();
    
    [JsonIgnore] public virtual ICollection<LoginLog> LoginLogs { get; set; } = new List<LoginLog>();
    [JsonIgnore] public virtual ICollection<UserPermission> Permissions { get; set; } = new List<UserPermission>();

}