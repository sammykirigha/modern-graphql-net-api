
using ServiceProvider.Core.Attributes;
using HotChocolate;
using HotChocolate.Types;

namespace ServiceProvider.Core.Models;

public record ServiceMutationInput(
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id, 

    [property: DefaultValue("")] Optional<string> Name,
     [property: DefaultValue(0.00)] Optional<string> Price,

    Optional<Guid> LocationId,
    Optional<Guid> CategoryId,
    [property: DefaultDateValue] Optional<DateTime> DateCreated,
    [property: DefaultDateValue] Optional<DateTime> DateModified
);