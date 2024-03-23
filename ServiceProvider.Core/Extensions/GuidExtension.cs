namespace ServiceProvider.Core.Extensions;

public static class GuidExtension
{
    public static Guid? ToNullIfDefault(this Guid uuid) => uuid == Guid.Empty ? null : uuid;
}