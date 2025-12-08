using ServiceProvider.Core.Enums;

namespace ServiceProvider.Core.DTOs.ServiceListing;

public class CreateServiceListingDto
{
	public double? BasePrice { get; set; } = 0.00;
	public ICollection<Guid> ServiceIds { get; set; } = new List<Guid>();
	public Guid? ServiceProviderId { get; set; }
	public string BusinessName { get; set; } = string.Empty;
	public string BusinessDescription { get; set; } = string.Empty;
	public Guid? CustomServiceId { get; set; }
	public PaymentModes PaymentMode { get; set; }
}