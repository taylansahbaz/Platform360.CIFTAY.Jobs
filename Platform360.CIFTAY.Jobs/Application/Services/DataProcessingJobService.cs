using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using System;
using Platform360.CIFTAY.Jobs.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Platform360.CIFTAY.Jobs.Infrastructure;
using Microsoft.Extensions.Options;

public class DataProcessingJobService : BackgroundService
{
    private readonly ILogger<DataProcessingJobService> _logger;
    private readonly IServiceProvider _serviceProvider;
    private readonly DataProcessingOptions _options;
    
    public DataProcessingJobService(IServiceProvider serviceProvider, ILogger<DataProcessingJobService> logger,IOptions<DataProcessingOptions> options)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
        _options = options.Value;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while(!stoppingToken.IsCancellationRequested)
        {
            if (_options.isActive)
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var dataProcessingService = scope.ServiceProvider.GetRequiredService<IDataProcessingService>();

                    try
                    {
                        await dataProcessingService.ProcessDataAsync();
                        _logger.LogInformation("job calisti");
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "job calismiyor");
                    }
                }
            }
                await Task.Delay(TimeSpan.FromMinutes(_options.intervalMinutes), stoppingToken);
        }
    }
}