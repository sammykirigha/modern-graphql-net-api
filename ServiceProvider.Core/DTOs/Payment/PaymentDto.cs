using ServiceProvider.Core.Enums;

namespace ServiceProvider.Core.DTOs.Payment;

public class PaymentDto
{
	public float Amount { get; set; }
	public string Currency { get; set; } = string.Empty;
	public Guid PlanId { get; set; }
	public string UserId { get; set; } = string.Empty;
	public long Receiver { get; set; }
	public PaymentMethod PaymentMethod { get; set; }
}