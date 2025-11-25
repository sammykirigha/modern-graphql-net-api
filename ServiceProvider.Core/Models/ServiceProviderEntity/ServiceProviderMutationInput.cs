using ServiceProvider.Core.Attributes;
using HotChocolate;
using HotChocolate.Types;

namespace ServiceProvider.Core.Models;

public record ServiceProviderMutationInput(
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id, 
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> LocationId, 

	[property: DefaultValue("")] Optional<string> FirstName,
	[property: DefaultValue("")] Optional<string> LastName,
	[property: DefaultValue("")] Optional<string> Email,
	Optional<string> Phone,
	[property: DefaultDateValue] Optional<DateTime> DateCreated,
	[property: DefaultDateValue] Optional<DateTime> DateModified
);