using Graphql.Core.Attributes;
using HotChocolate;
using HotChocolate.Types;
 
namespace Graphql.Core.Models;
 
public sealed record RoleMutationInput(
    [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id,
    [property: DefaultValue("")] Optional<string> Name,
 
     [property: DefaultDateValue] Optional<DateTime> DateCreated,
    [property: DefaultDateValue] Optional<DateTime> DateModified
);