using System.Text.Json;

namespace ServiceProvider.Core.Extensions;

public static class JsonExtension
{
    public static string Serialize<T>(this T obj)
    {
        return JsonSerializer.Serialize(obj);
    }

    public static T? Deserialize<T>(this string serialzed)
    {
        return JsonSerializer.Deserialize<T>(serialzed);
    }

    public static bool IsJsonEmpty(this string value)
    {
        return string.IsNullOrEmpty(value) || value == "{}" || value == "{ }";
    }

    public static bool IsJsonValid(this string value)
    {
        if(string.IsNullOrWhiteSpace(value))
        return false;

        try
        {
            using var obj = JsonDocument.Parse(value);
            return obj!= null;
        }
        catch
        {
            return false;
        }
    }
}