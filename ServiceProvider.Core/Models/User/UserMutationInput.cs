
using ServiceProvider.Core.Attributes;
using ServiceProvider.Core.Enums;
using HotChocolate;
using HotChocolate.Types;

namespace ServiceProvider.Core.Models;

public record UserMutationInput(
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id, 
    [property: DefaultValue(UserAccessLevel.SuperAdmin)] Optional<UserAccessLevel> AccessLevel,
    [property: DefaultValue(UserAccessType.Full)] Optional<UserAccessLevel> AccessType,
    [property: DefaultValue(true)] Optional<bool> IsActive,

    [property: DefaultValue("")] Optional<string> FirstName,
    [property: DefaultValue("")] Optional<string> LastName,
    [property: DefaultValue("")] Optional<string> Email,
    Optional<Guid> RoleId,
    Optional<string> Phone,
    [property: DefaultDateValue] Optional<DateTime> DateCreated,
    [property: DefaultDateValue] Optional<DateTime> DateModified,
    [property: DefaultDateValue] Optional<DateTime> AdminLoginDate
);