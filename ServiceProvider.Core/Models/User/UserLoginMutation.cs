using HotChocolate;
using HotChocolate.Types;

namespace ServiceProvider.Core.Models;

public record UserLoginMutationInput(
    
    [property: DefaultValue("")] Optional<string> Email,
    [property: DefaultValue("")] Optional<string> Password
);