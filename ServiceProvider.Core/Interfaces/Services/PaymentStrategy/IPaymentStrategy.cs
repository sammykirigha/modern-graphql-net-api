using ServiceProvider.Core.DTOs.Payment;

namespace ServiceProvider.Core.Interfaces.Services.PaymentStrategy;

public interface IPaymentStrategy
{
	Task ProcessPayment(PaymentDto paymentDto);
}