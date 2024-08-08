using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Platform360.CIFTAY.Jobs;

var builder = WebApplication.CreateBuilder(args);

// Startup sýnýfýný kullanarak servisleri ve middleware'leri yapýlandýrýn
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Startup sýnýfýný oluþturun ve yapýlandýrma iþlemlerini yapýn
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Middleware yapýlandýrmasýný uygulayýn
startup.Configure(app, app.Environment);

app.Run();
