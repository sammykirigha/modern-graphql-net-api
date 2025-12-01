using HotChocolate;
using ServiceProvider.Core.Attributes;
using System.ComponentModel;

namespace ServiceProvider.Core.Models;

public record ProviderServicesMutationInput(
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> Id, 
	
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> ServiceProviderId,
	[property: DefaultValue("00000000-0000-0000-0000-000000000000")] Optional<Guid> ServiceId,    
	[property: DefaultDateValue] Optional<DateTime> DateCreated,
	[property: DefaultDateValue] Optional<DateTime> DateModified
	);