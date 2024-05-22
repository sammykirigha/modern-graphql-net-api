
using ServiceProvider.Core.Attributes;
using HotChocolate;
using HotChocolate.Types;

namespace ServiceProvider.Core.Models;

public record ServiceMutationInput(
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id, 
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> CategoryId,
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> ClientId,
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> LocationId,

    [property: DefaultValue("")] Optional<string> Name,
     [property: DefaultValue(0.00)] Optional<decimal> Price,

    [property: DefaultDateValue] Optional<DateTime> DateCreated,
    [property: DefaultDateValue] Optional<DateTime> DateModified
);