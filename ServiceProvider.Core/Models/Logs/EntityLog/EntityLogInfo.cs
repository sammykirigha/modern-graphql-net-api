

using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Interfaces.Models.Logs;

namespace ServiceProvider.Core.Models;

public class EntityLogInfo: IEntityLogInfo
{
    public LogCategory Category {get; set;}

    public string ChangeTrigger {get; set;}
    public string ChangeReason {get; set;}
    public Guid? UserId {get; set;}
    public string? UserName {get; set;}
}