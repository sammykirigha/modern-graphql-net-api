using HotChocolate;
using HotChocolate.Types;
using ServiceProvider.Core.Attributes;
using ServiceProvider.Core.Enums;

namespace ServiceProvider.Core.Models;
 
public sealed record PlanMutationInput(
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id,
    [property: DefaultValue("")] Optional<string> Name,
    [property: DefaultValue("")] Optional<decimal> Price,
    [property: DefaultValue("")] Optional<int> Duration,
    [property: DefaultValue("")] Optional<PlanTime> Time,
 
     [property: DefaultDateValue] Optional<DateTime> DateCreated,
    [property: DefaultDateValue] Optional<DateTime> DateModified
);