using ServiceProvider.Core.Attributes;
using HotChocolate;
using HotChocolate.Types;

namespace ServiceProvider.Core.Models;

public record CostituencyMutationInput
(
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id, 

	[property: DefaultValue("")] Optional<string> ConstituencyName,
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> CountyId,
    
	[property: DefaultDateValue] Optional<DateTime> DateCreated,
	[property: DefaultDateValue] Optional<DateTime> DateModified
);