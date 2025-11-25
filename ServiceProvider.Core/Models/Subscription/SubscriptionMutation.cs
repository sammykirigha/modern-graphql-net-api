using HotChocolate;
using HotChocolate.Types;
using ServiceProvider.Core.Attributes;
using ServiceProvider.Core.Enums;

namespace ServiceProvider.Core.Models;
 
public sealed record SubscriptionMutationInput(
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id,
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> PlanId,
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> ServiceProviderId,
    [property: DefaultValue("")] Optional<RenewalType> RenewalType,
    [property: DefaultValue("")] Optional<SubscriptionStatus> Status,
     [property: DefaultDateValue] Optional<DateTime> StartDate,
    [property: DefaultDateValue] Optional<DateTime> EndDate,
 
     [property: DefaultDateValue] Optional<DateTime> DateCreated,
    [property: DefaultDateValue] Optional<DateTime> DateModified
);