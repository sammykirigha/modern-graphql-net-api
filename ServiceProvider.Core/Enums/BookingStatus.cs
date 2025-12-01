namespace ServiceProvider.Core.Enums;

public enum BookingStatus : byte
{
	Accepted = 0,
	Completed = 1,
	Cancelled = 2,
	Expired = 3,
	Pending = 4
}