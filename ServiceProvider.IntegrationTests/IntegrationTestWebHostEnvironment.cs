using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace ServiceProvider.IntegrationTests
{
	// hack to cope with new IWebHostEnvironment dependency in UserProfileService to create dev user
	public class IntegrationTestWebHostEnvironment : IWebHostEnvironment
	{
		string IWebHostEnvironment.WebRootPath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		IFileProvider IWebHostEnvironment.WebRootFileProvider { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		string IHostEnvironment.ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		IFileProvider IHostEnvironment.ContentRootFileProvider { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		string IHostEnvironment.ContentRootPath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		string IHostEnvironment.EnvironmentName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		private readonly bool isDevelopment = true;
		public bool IsDevelopment() => isDevelopment;

		private readonly bool isStaging = true;
		public bool IsStaging() => isStaging;
	}
}