using ServiceProvider.Core.Attributes;
using HotChocolate;
using HotChocolate.Types;
 
namespace ServiceProvider.Core.Models;
 
public record PermissionMutationInput(
  [property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id,
  Optional<string> Name,
 
  [property: DefaultDateValue] Optional<DateTime> DateCreated,
  [property: DefaultDateValue] Optional<DateTime> DatedModified
);