using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;
using ServiceProvider.Core.Settings;

namespace ServiceProvider.Core.Utilities
{
	public class AppVersionTelemetryInitializer : ITelemetryInitializer
	{
		public void Initialize(ITelemetry telemetry)
		{
			if (telemetry is RequestTelemetry requestTelemetry)
			{
				requestTelemetry.Properties.Add("ContainerTag", VersionSettings.ContainerTag);
				requestTelemetry.Properties.Add("Branch", VersionSettings.Branch);
			}
		}
	}
}