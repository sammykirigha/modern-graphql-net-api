
using System.Reflection;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;

namespace ServiceProvider.Core.Attributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
public sealed class DefaultDateValueAttribute : DescriptorAttribute
{
    public DefaultDateValueAttribute()
    {
        Value = DateTime.UtcNow;
    }

    public object? Value { get; }

    protected override void TryConfigure(
        IDescriptorContext context,
        IDescriptor descriptor,
        ICustomAttributeProvider element)
    {
        if (descriptor is IArgumentDescriptor arg)
        {
            arg.DefaultValue(Value);
        }

        if (descriptor is IDirectiveArgumentDescriptor darg)
        {
            darg.DefaultValue(Value);
        }

        if (descriptor is IInputFieldDescriptor field)
        {
            field.DefaultValue(Value);
        }
    }
}

