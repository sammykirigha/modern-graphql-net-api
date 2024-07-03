using Microsoft.AspNetCore.Http;
using ServiceProvider.Core.Interfaces;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Settings;
using Stripe;
using Plan = ServiceProvider.Core.Models.Plan;

namespace ServiceProvider.Services;

public class StripeGateWayService : IStripeGateWayService<PaymentIntent>
{
    private readonly StripeSettings _settings;

    public StripeGateWayService(
        StripeSettings settings
        )
    {
        _settings = settings ?? throw new ArgumentNullException(nameof(StripeSettings));
    }

    public async Task<PaymentIntent> CreatePaymentAsync(Plan? plan)
    {
        StripeConfiguration.ApiKey = _settings.SecretKey;
        var options = new PaymentIntentCreateOptions
        {
            Amount = (long)plan!.Price,
            Currency = "usd",
            Description = "Made payment through stripe",
            ReceiptEmail = "dkirigha18@gmail.com",
            PaymentMethodTypes = new List<string> { "card" },
        };

        var paymentIntentService = new PaymentIntentService();
        PaymentIntent paymentIntent = await paymentIntentService.CreateAsync(options);

        // Use a test token for card payment
        var testToken = "pm_card_visa"; // Test token simulating a Visa card

        // Confirm the PaymentIntent with the PaymentMethod ID
        var paymentIntentConfirmOptions = new PaymentIntentConfirmOptions
        {
            PaymentMethod = testToken,
        };

        PaymentIntent confirmedPaymentIntent = paymentIntentService.Confirm(paymentIntent.Id, paymentIntentConfirmOptions);

        Console.WriteLine($"PaymentIntent confirmed successfully(((((((()))))))): {confirmedPaymentIntent}");

        return confirmedPaymentIntent;
    }
}