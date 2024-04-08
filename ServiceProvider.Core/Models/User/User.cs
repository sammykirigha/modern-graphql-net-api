using System.Text.Json.Serialization;
using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Interface.Models;

namespace ServiceProvider.Core.Models;

public partial class User : IEntity
{
    /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Acces level for the user
    /// </summary>
    public UserAccessLevel AccessLevel { get; set; }

    /// <summary>
    /// Acces type for the user
    /// </summary>
    public UserAccessType AccessType { get; set; }

    /// <summary>
    /// Enabled/Disabled
    /// </summary>
    public bool IsActive { get; set; }

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
    /// Id of role (foreign key)
    /// </summary>
    public Guid? RoleId { get; set; }

    /// <summary>
    /// Primary phone number of user
    /// </summary>
    public string? Phone { get; set; }
    /// <summary>
    /// Date/time record created
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    /// <summary>
    /// Last date/time record changed
    /// </summary>
    public DateTime DateModified { get; set; } = DateTime.UtcNow;
    /// <summary>
    /// Last admin login date
    /// </summary>
    public DateTime? AdminLoginDate { get; set; }
    /// <summary>
    /// Allow access to global settings
    /// </summary>
    public bool AccessGlobalSettings { get; set; }
    
    public DateTime? DateModified { get; set; } = DateTime.UtcNow;
    
    [JsonIgnore] public virtual Role? Role { get; set; }
    
    [JsonIgnore] public virtual ICollection<ErrorLog> ErrorLogsActive { get; set; } = new List<ErrorLog>();
    
    [JsonIgnore] public virtual ICollection<ErrorLog> ErrorLogsLoggedIn { get; set; } = new List<ErrorLog>();
    [JsonIgnore] public virtual ICollection<EntityLog> EntityLogsActive { get; set; } = new List<EntityLog>();
    [JsonIgnore] public virtual ICollection<EntityLog> EntityLogsLoggedIn { get; set; } = new List<EntityLog>();
    
    [JsonIgnore] public virtual ICollection<LoginLog> LoginLogs { get; set; } = new List<LoginLog>();
    [JsonIgnore] public virtual ICollection<UserPermission> Permissions { get; set; } = new List<UserPermission>();

}