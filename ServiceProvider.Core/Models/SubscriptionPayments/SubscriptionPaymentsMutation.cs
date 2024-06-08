using HotChocolate;
using HotChocolate.Types;
using ServiceProvider.Core.Attributes;

namespace ServiceProvider.Core.Models;
 
public sealed record SubscriptionPaymentsMutationInput(
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id,
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> SubscriptionId,
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> PaymentId,
    [property: DefaultValue(0.0)] Optional<decimal> PaymentAmount,
 
     [property: DefaultDateValue] Optional<DateTime> DateCreated,
    [property: DefaultDateValue] Optional<DateTime> DateModified
);