using ServiceProvider.Core.Enums;

namespace ServiceProvider.Core.Interfaces.Models.Logd;

public interface IEntityLogInfo
{
    public LogCategory Category { get; set; }
    public string ChangeTrigger { get; set; }
    public string? ChangeReason { get; set; }
    
    public Guid? UserId { get; set; }
    public string? UserName { get; set; }
}

