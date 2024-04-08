
using ServiceProvider.Core.Enums;
namespace ServiceProvider.Core.Interfaces.Models.Logs;

public interface IEntityLogInfo
{
    LogCategory Category { get; set; }
    string ChangeTrigger { get; set; }
    string? ChangeReason { get; set; }
 
    Guid? UserId { get; set; }
    string? UserName { get; set; }
}