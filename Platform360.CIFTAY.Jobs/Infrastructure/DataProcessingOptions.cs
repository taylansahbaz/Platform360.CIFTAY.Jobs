using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Platform360.CIFTAY.Jobs.Infrastructure
{
	public class DataProcessingOptions
    {
		public bool isActive { get; init; }
		public int intervalMinutes { get; init; }
	}
	public class DataProcessingConfigurationSetup : IConfigureOptions<DataProcessingOptions>
	{
		private const string SectionName = "DataProcessingOptions";
		private readonly IConfiguration _configuration;
		public DataProcessingConfigurationSetup(IConfiguration configuration)
		{
			_configuration = configuration;
		}
		public void Configure(DataProcessingOptions options)
		{
			_configuration
				.GetSection(SectionName)
				.Bind(options);
		}
	}
}
