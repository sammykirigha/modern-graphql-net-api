using HotChocolate;
using HotChocolate.Types;
using ServiceProvider.Core.Attributes;
using ServiceProvider.Core.Enums;

namespace ServiceProvider.Core.Models;
 
public sealed record PaymentMutationInput(
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id,
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> UserId,
    [property: DefaultValue("")] Optional<string> TransactionCode,
    Optional<decimal> Amount,
    Optional<PaymentMethod> PaymentMethod,
    Optional<PaymentStatus> Status,
    Optional<Currency> Currency,
    Optional<DateTime> PaymentDate,
 
     [property: DefaultDateValue] Optional<DateTime> DateCreated,
    [property: DefaultDateValue] Optional<DateTime> DateModified
);