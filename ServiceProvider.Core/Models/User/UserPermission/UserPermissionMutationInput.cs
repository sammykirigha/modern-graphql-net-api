
using ServiceProvider.Core.Attributes;
using HotChocolate;
using HotChocolate.Types;
 
namespace ServiceProvider.Core.Models;
 
public record UserPermissionMutationInput(
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id,
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> UserId,
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> PermissionId,
 
    [property: DefaultDateValue] Optional<DateTime> DateCreated,
    [property: DefaultDateValue] Optional<DateTime> DateModified
);