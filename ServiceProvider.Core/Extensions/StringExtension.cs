using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace ServiceProvider.Core.Extensions;

public static class StringExtensions
{
    public static bool IsEmpty(this string value)
    {
        return string.IsNullOrEmpty(value);
    }
    
    public static string IsEMpty(this string value, string replace)
    {
        if (string.IsNullOrEmpty(value))
            return replace;
        else
            return value;
    }
    
    public static Guid ToGuid(this string value, Guid? defaultValue = null, bool throwError = false)
    {
        Guid guidval;
        
        if (throwError)
            guidval = new Guid(value);
        else if (!Guid.TryParse(value, out guidval))
            guidval = defaultValue ?? Guid.Empty;
        
        return guidval;
    }
    
    public static byte ToByte(this string value, byte? defaultValue = null, bool throwError = false)
    {
        byte byteval;
        
        if (throwError)
            byteval = Convert.ToByte(value);
        else if (!byte.TryParse(value, out byteval))
            byteval = defaultValue ?? 0;
        
        return byteval;
    }
    
    public static int ToInt(this string value, int? defaultValue = null, bool throwError = false)
    {
        int intval;
        
        if (throwError)
            intval = Convert.ToInt32(value);
        else if (!int.TryParse(value, out intval))
            intval = defaultValue ?? 0;
        
        return intval;
    }
    
    public static decimal ToDecimal(this string value, decimal? defaultValue = null, bool throwError = false)
    {
        decimal decval;
        
        if (throwError)
            decval = Convert.ToDecimal(value);
        else if (!decimal.TryParse(value, out decval))
            decval = defaultValue ?? 0;
        
        return decval;
    }
    
    public static bool ToBool(this string value, bool? defaultValue = null, bool throwError = false)
    {
        bool boolval;
        
        if (throwError)
            boolval = Convert.ToBoolean(value);
        else if (!bool.TryParse(value, out boolval))
            boolval = defaultValue ?? false;
        
        return boolval;
    }
    
    public static DateTime ToDateTime(this string value, DateTime? defaultDate = null, bool throwError = false)
    {
        DateTime dateval;
        
        if (throwError)
            dateval = Convert.ToDateTime(value);
        else if (!DateTime.TryParse(value, out dateval))
            dateval = defaultDate ?? DateTime.MinValue;
        
        return dateval;
    }
    
    public static List<string?> ToList(this string? value, string delimiter = ",", bool trim = false, StringSplitOptions options = StringSplitOptions.None)
    {
        if (value == null)
            return [];

        return value.Split(new string[] { delimiter }, options).Select(x => (string?)(trim ? x.Trim() : x)).ToList();
    }
    
    public static DateTime ToDynamicDate(this string? value)
	{
		if (string.IsNullOrWhiteSpace(value))
			value = "Current Date";

		var operand = "";
		var amount = 0;

		if (value.IndexOf('+') > -1)
		{
			operand = "+";
			amount = value[(value.IndexOf('+') + 1)..].Trim().ToInt();
			value = value[..value.IndexOf('+')].Trim();
		}
		else if (value.IndexOf('-') > -1)
		{
			operand = "-";
			amount = value[(value.IndexOf('-') + 1)..].Trim().ToInt();
			value = value[..value.IndexOf('-')].Trim();
		}

		DateTime date;
		switch (value)
		{
			case "Current Date":
				date = DateTime.Today;
				break;
			case "Prior Month Begin":
				date = DateTime.Today.AddMonths(-1);
				date = date.AddDays(-(date.Day - 1));
				break;
			case "Prior Month End":
				date = DateTime.Today;
				date = date.AddDays(-(date.Day));
				break;
			case "Current Month Begin":
				date = DateTime.Today;
				date = date.AddDays(-(date.Day - 1));
				break;
			case "Current Month End":
				date = DateTime.Today.AddMonths(1);
				date = date.AddDays(-(date.Day));
				break;
			case "Next Month Begin":
				date = DateTime.Today.AddMonths(1);
				date = date.AddDays(-(date.Day - 1));
				break;
			case "Next Month End":
				date = DateTime.Today.AddMonths(2);
				date = date.AddDays(-(date.Day));
				break;
			case "6 Months Begin":
				date = DateTime.Today.AddMonths(6);
				date = date.AddDays(-(date.Day - 1));
				break;
			case "6 Months End":
				date = DateTime.Today.AddMonths(7);
				date = date.AddDays(-(date.Day));
				break;
			case "Prior Year Begin":
				date = DateTime.Parse($"1/1/{DateTime.Today.AddYears(-1).Year}", CultureInfo.InvariantCulture);
				break;
			case "Prior Year End":
				date = DateTime.Parse($"12/31/{DateTime.Today.AddYears(-1).Year}", CultureInfo.InvariantCulture);
				break;
			case "Current Year Begin":
				date = DateTime.Parse($"1/1/{DateTime.Today.Year}", CultureInfo.InvariantCulture);
				break;
			case "Current Year End":
				date = DateTime.Parse($"12/31/{DateTime.Today.Year}", CultureInfo.InvariantCulture);
				break;
			case "Next Year Begin":
				date = DateTime.Parse($"1/1/{DateTime.Today.AddYears(1).Year}", CultureInfo.InvariantCulture);
				break;
			case "Next Year End":
				date = DateTime.Parse($"12/31/{DateTime.Today.AddYears(1).Year}", CultureInfo.InvariantCulture);
				break;
			default:
				date = DateTime.Parse(value, CultureInfo.InvariantCulture);
				break;
		}
		if (operand == "+")
		{
			date = date.AddDays(amount);
		}
		else if (operand == "-")
		{
			date = date.AddDays(-(amount));
		}

		return date;
	}
    
    public static T? ToNullable<T>(this string? value) where T : struct
	{
		if (string.IsNullOrWhiteSpace(value))
			return null;
		
		return (T)Convert.ChangeType(value, typeof(T));
	}

	public static string UrlBasePath(this string value)
	{
		var uri = new Uri(value);
		return $"{uri.Scheme}://{uri.Host}";
	}
	
	public static string MaxLength(this string value, int length, string suffix = "...")
	{
		if (value.Length <= length)
			return value;
		else
			return value.Substring(0, length) + suffix;
	}
	
	public static string? MaxLengthOrNull(this string? value, int maxLength)
	{
		if (string.IsNullOrEmpty(value))
			return value;
		return value.MaxLength(maxLength);
	}

	public static string HashPassword(this string password)
	{
		var salt = Guid.NewGuid().ToString();
		using (var pbkdf2 = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(salt), 10000, HashAlgorithmName.SHA256))
		{
			var hash = pbkdf2.GetBytes(32);
			return $"{Convert.ToBase64String(hash)}:{salt}";
		}
	}

	public static bool VerifyPassword(this string password, string hashedPassword)
	{
		var parts = hashedPassword.Split(':');
		if (parts.Length != 2) return false;
		var hash = Convert.FromBase64String(parts[0]);
		var salt = parts[1];
		using (var pbkdf2 = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(salt), 10000, HashAlgorithmName.SHA256))
		{
			var computedHash = pbkdf2.GetBytes(32);
			return hash.SequenceEqual(computedHash);
		}
	}
}