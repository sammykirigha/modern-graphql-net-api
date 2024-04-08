
using ServiceProvider.Core.Interfaces.Models.Logs;
using System.Text.Json.Serialization;

namespace ServiceProvider.Core.Models;

public class LoginLog : IEntityLog
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public bool Valid { get; set; }
    public Guid? UserId { get; set; }
    public string? Reason { get; set; }
    public DateTime DateCreated { get; set; }
    [JsonIgnore] public virtual User? User { get; set; }
}

