using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace Platform360.CIFTAY.Jobs.Infrastructure
{
    public class QueueOptions
    {
        public string Host { get; init; }
        public string queueName { get; init; }
    }
    
    public class QueueConfigurationSetup : IConfigureOptions<QueueOptions>
    {
        private const string SectionName = "QueueOptions";
        private readonly IConfiguration _configuration;

        public QueueConfigurationSetup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void Configure(QueueOptions options)
        {
            _configuration
                .GetSection(SectionName)
                .Bind(options);
        }
    }
}
