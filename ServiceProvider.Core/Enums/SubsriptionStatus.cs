namespace ServiceProvider.Core.Enums;

public enum SubscriptionStatus : byte
{
    Active = 0,
    Cancelled = 1,
    Expired = 2,
    Failed = 3,
    Pending =3,
    Inactive = 4,
}