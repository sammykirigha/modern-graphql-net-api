
using HotChocolate;
using HotChocolate.Types;
using ServiceProvider.Core.Attributes;
using ServiceProvider.Core.Enums;

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
    [property: DefaultDateValue] Optional<DateTime> CreatedAt,
    [property: DefaultDateValue] Optional<DateTime> ModifiedAt,
    [property: DefaultDateValue] Optional<DateTime> AdminLoginDate
);

