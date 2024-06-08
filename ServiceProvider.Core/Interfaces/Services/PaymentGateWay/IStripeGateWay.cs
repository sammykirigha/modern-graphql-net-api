using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Interfaces;

public interface IStripeGateWayService<T> {
    Task<T> CreatePaymentAsync(Plan? plan);
}