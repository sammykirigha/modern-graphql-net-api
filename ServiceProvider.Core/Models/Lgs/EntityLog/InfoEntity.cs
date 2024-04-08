
using ServiceProvider.Core.Interface.Models;

namespace ServiceProvider.Core.Models;

public class InfoEntity: IEntity
{
    /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Information to log
    /// </summary>
    public string Info { get; set; } = "";
    
    /// <summary>
    /// Extra data that pertains to this info entity in json format
    /// </summary>
    public string? Data { get; set; }
    /// <summary>
    /// Date/time record created
    /// </summary>
    public DateTime DateCreated { get; set; }
    /// <summary>
    /// Date/time record created
    /// </summary>
    public DateTime DateModified { get; set; }
    
}