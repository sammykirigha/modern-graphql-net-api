using System.Text.Json.Serialization;
using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Interfaces.Models.Logs;

namespace ServiceProvider.Core.Models;

public class EntityLog: IEntityLog
{
    /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Date/time record created
    /// </summary>
    public DateTime CreatedAt { get; set; }
    /// <summary>
    /// Name of entity (should match class name)
    /// </summary>
    public string Entity { get; set; } = "";
    /// <summary>
    /// Id of entity
    /// </summary>
    public Guid? PrimaryKey { get; set; }
    /// <summary>
    /// Area of site where change happened
    /// </summary>
    public LogCategory Category { get; set; }
    /// <summary>
    /// Type of change
    /// </summary>
    public LogChangeType ChangeType { get; set; }
    /// <summary>
    /// What process triggered the change
    /// </summary>
    public string? ChangeTrigger { get; set; }
    /// <summary>
    /// User entered reason for the change
    /// </summary>
    public string? ChangeReason { get; set; }
    /// <summary>
    /// Entity state before the change
    /// </summary>
    public string? OldData { get; set; }
    /// <summary>
    /// Entity state after the change
    /// </summary>
    public string? NewData { get; set; }
    /// <summary>
    /// List of changes made
    /// </summary>
    public string? Changes { get; set; }
    /// <summary>
    /// Id of active/impersonated user (foreign key)
    /// </summary>
    public Guid? ActiveUserId { get; set; }
    /// <summary>
    /// Name of active/impersonated user
    /// </summary>
    public string? ActiveUserName { get; set; }

    /// <summary>
    /// Id of logged in user (foreign key)
    /// </summary>
    public Guid? LoggedInUserId { get; set; }
    /// <summary>
    /// Name of logged in user
    /// </summary>
    public string? LoggedInUserName { get; set; }
    
    [JsonIgnore] public virtual User? ActiveUser { get; set; }
    [JsonIgnore] public virtual User? LoggedInUser { get; set; }
}