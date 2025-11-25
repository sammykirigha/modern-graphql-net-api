
using ServiceProvider.Core.Interfaces.Models;
using ServiceProvider.Core.Models;
using System.Text.Json.Serialization;

public class Booking: IEntity
{
    public Guid Id { get; set; }
    public Guid ServiceId { get; set; }
    public Guid ServiceProviderId { get; set; }
    public Guid CustomerId { get; set; }
    public DateTime BookingDate { get; set; }
    public DateTime AcceptedAt { get; set; }
    public DateTime CompletedAt { get; set; }
    public DateTime CancelledAt { get; set; }
    public string CancellationReason { get; set; } = "";
    public string Status { get; set; } = "";
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    [JsonIgnore] public virtual Service? Service { get; set; }
    [JsonIgnore] public virtual ServiceProviderEntity? ServiceProvider { get; set; }
    [JsonIgnore] public virtual User? User { get; set; }
}