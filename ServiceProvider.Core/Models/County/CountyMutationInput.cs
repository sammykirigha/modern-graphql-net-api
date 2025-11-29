using HotChocolate;
using HotChocolate.Types;
using ServiceProvider.Core.Attributes;

namespace ServiceProvider.Core.Models;

public record CountyMutationInput(
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id, 

	[property: DefaultValue("")] Optional<string> CountyName,
    
	[property: DefaultDateValue] Optional<DateTime> DateCreated,
	[property: DefaultDateValue] Optional<DateTime> DateModified);