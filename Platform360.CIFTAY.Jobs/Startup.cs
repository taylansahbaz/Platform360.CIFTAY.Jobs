using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Platform360.CIFTAY.Jobs.Application.Services;
using Platform360.CIFTAY.Jobs.Data;
using Platform360.CIFTAY.Jobs.Infrastructure;
using Platform360.CIFTAY.Jobs.Services;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {

        services.Configure<DataProcessingOptions>(Configuration.GetSection("DataProcessingOptions"));
        services.Configure<QueueOptions>(Configuration.GetSection("QueueOptions"));

        services.AddDbContext<ciftayContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        

        services.AddSingleton<IConfigureOptions<DataProcessingOptions>, DataProcessingConfigurationSetup>();
        services.AddSingleton<IConfigureOptions<QueueOptions>, QueueConfigurationSetup>();
        services.AddSingleton<IQueueService>(provider =>
        {
            var options = provider.GetRequiredService<IOptions<QueueOptions>>().Value;
            return new QueueService(options.Host, options.queueName);
        });
        
        services.AddScoped<IDataProcessingService, DataProcessingService>();
        services.AddScoped<ICalculatedDataService, CalculatedDataService>();
        services.AddHostedService<DataProcessingJobService>();

        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
        });
        
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
