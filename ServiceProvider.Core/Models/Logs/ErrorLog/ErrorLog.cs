using ServiceProvider.Core.Interfaces.Models.Logs;
using System.Text.Json.Serialization;

namespace ServiceProvider.Core.Models;

public class ErrorLog : IEntityLog
{
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
    public string Message { get; set; } = "";
    public string Type { get; set; } = "";
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
    /// Full error stack
    /// </summary>
    public string? Data { get; set; }
    /// <summary>
    /// Name of logged in user
    /// </summary>
    public string? LoggedInUserName { get; set; }
    
    [JsonIgnore] public virtual User? LoggedInUser { get; set; }
    [JsonIgnore] public virtual User? ActiveUser { get; set; }
}

