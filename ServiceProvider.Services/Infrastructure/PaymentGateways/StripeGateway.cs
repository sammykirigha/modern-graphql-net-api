using ServiceProvider.Core.DTOs.Payment;
using ServiceProvider.Core.Interfaces.Services.PaymentStrategy;

namespace ServiceProvider.Services.Infrastructure;

public class StripeGateway : IPaymentStrategy
{
	public Task ProcessPayment(PaymentDto paymentDto)
	{
		// Implement Stripe payment processing logic here
		Console.WriteLine($"Processing Stripe payment of amount: {paymentDto.Amount}");
		
		return Task.CompletedTask;
	}
}