namespace ServiceProvider.Core.Enums;

public enum PaymentStatus : byte
{
    COMPLETED = 0,
    PENDING = 1,
    FAILED = 3,
    SUCCEEDED = 4,
    REQUIRES_PAYMENT_METHOD = 5,
}