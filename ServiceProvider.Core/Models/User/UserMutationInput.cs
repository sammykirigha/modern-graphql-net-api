
using ServiceProvider.Core.Attributes;
using ServiceProvider.Core.Enums;
using HotChocolate;
using HotChocolate.Types;

namespace ServiceProvider.Core.Models;

public record UserMutationInput(
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id, 
    
    [property: DefaultValue("")] Optional<string> FirstName,
    [property: DefaultValue("")] Optional<string> LastName,
    [property: DefaultValue("")] Optional<string> Email,
    [property: DefaultValue("")] Optional<string> Password,

    [property: DefaultValue(true)] Optional<bool> IsActive
);