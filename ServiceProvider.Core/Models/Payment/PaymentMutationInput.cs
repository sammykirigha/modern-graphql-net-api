using HotChocolate;
using HotChocolate.Types;
using ServiceProvider.Core.Attributes;
using ServiceProvider.Core.Enums;

namespace ServiceProvider.Core.Models;
 
public sealed record PlaymentMutationInput(
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id,
    [property: DefaultValue("")] Optional<string> TransactionCode,
    [property: DefaultValue("")] Optional<decimal> Amount,
    [property: DefaultValue("")] Optional<int> PaymentMethod,
    [property: DefaultValue("")] Optional<PaymentStatus> Status,
    [property: DefaultValue("")] Optional<Currency> Curreny,
    [property: DefaultValue("")] Optional<DateTime> PaymentDate,
 
     [property: DefaultDateValue] Optional<DateTime> DateCreated,
    [property: DefaultDateValue] Optional<DateTime> DateModified
);