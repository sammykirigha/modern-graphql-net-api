using ServiceProvider.Core.Attributes;
using HotChocolate;
using HotChocolate.Types;
 
namespace ServiceProvider.Core.Models;
 
public record RolePermissionMutationInput(
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id,
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> UserId,
 
    Optional<Guid?> PermissionId,
 
    [property: DefaultDateValue] Optional<DateTime> DatedCreated,
    [property: DefaultDateValue] Optional<DateTime> DateModified
);