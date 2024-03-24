
using System.Text.Json;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ServiceProvider.Data.Contexts.Configurations;

public static class ConfigurationExtensions
{
    public static PropertyBuilder<List<T>> AddEnumList<T>(this PropertyBuilder<List<T>> property, int maxLength)
    {
        property.HasMaxLength(maxLength);
        property.HasConversion(
            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
            v => JsonSerializer.Deserialize<List<T>>(v, JsonSerializerOptions.Default),
            new ValueComparer<List<T>>(
                (c1, c2) => c1 == null || c2 == null ? c1 == null && c2 == null : c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v != null ? v.GetHashCode() : default)),
                c => c));

        return property;
    }
    
    public static PropertyBuilder<List<string>?> AddStringList(this PropertyBuilder<List<string>?> property, int maxLength)
    {
        property.HasMaxLength(maxLength);
        property.HasConversion(
            v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
            v => JsonSerializer.Deserialize<List<string>>(v, JsonSerializerOptions.Default),
            new ValueComparer<List<string>>(
                (c1, c2) => c1 == null || c2 == null ? c1 == null && c2 == null : c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v != null ? v.GetHashCode() : default)),
                c => c));

        return property;
    }
}

