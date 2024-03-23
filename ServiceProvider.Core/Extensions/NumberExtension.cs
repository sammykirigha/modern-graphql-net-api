namespace ServiceProvider.Core.Extensions;

public static class NumberExtensions
{
    	public static string AsOrdinal(this int number)
	{
		return (number % 100) switch
		{
			11 or 12 or 13 => number + "th",
			_ => (number % 10) switch
			{
				1 => number + "st",
				2 => number + "nd",
				3 => number + "rd",
				_ => number + "th",
			},
		};
	}

	public static byte IsZero(this byte? number, byte defaultValue)
	{
		return (number.HasValue && number != 0 ? number.Value : defaultValue);
	}
	public static short IsZero(this short? number, short defaultValue)
	{
		return (number.HasValue && number != 0 ? number.Value : defaultValue);
	}
	public static int IsZero(this int? number, int defaultValue)
	{
		return (number.HasValue && number != 0 ? number.Value : defaultValue);
	}
	public static long IsZero(this long? number, long defaultValue)
	{
		return (number.HasValue && number != 0 ? number.Value : defaultValue);
	}
	public static float IsZero(this float? number, float defaultValue)
	{
		return (number.HasValue && number != 0 ? number.Value : defaultValue);
	}
	public static double IsZero(this double? number, double defaultValue)
	{
		return (number.HasValue && number != 0 ? number.Value : defaultValue);
	}
	public static decimal IsZero(this decimal? number, decimal defaultValue)
	{
		return (number.HasValue && number != 0 ? number.Value : defaultValue);
	}

	public static byte IsZero(this byte number, byte defaultValue)
	{
		return (number != 0 ? number : defaultValue);
	}
	public static short IsZero(this short number, short defaultValue)
	{
		return (number != 0 ? number : defaultValue);
	}
	public static int IsZero(this int number, int defaultValue)
	{
		return (number != 0 ? number : defaultValue);
	}
	public static long IsZero(this long number, long defaultValue)
	{
		return (number != 0 ? number : defaultValue);
	}
	public static float IsZero(this float number, float defaultValue)
	{
		return (number != 0 ? number : defaultValue);
	}
	public static double IsZero(this double number, double defaultValue)
	{
		return (number != 0 ? number : defaultValue);
	}
	public static decimal IsZero(this decimal number, decimal defaultValue)
	{
		return (number != 0 ? number : defaultValue);
	}
}