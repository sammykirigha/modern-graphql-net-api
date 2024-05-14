using ServiceProvider.Core.Attributes;
using HotChocolate;
using HotChocolate.Types;
 
namespace ServiceProvider.Core.Models;
 
public record ClientServiceMutationInput(
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id,
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> ServiceId,
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> ClientId,
 
    [property: DefaultDateValue] Optional<DateTime> DateCreated,
    [property: DefaultDateValue] Optional<DateTime> DateModified
);