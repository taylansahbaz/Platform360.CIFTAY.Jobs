using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Platform360.CIFTAY.Jobs;

var builder = WebApplication.CreateBuilder(args);

// Startup s�n�f�n� kullanarak servisleri ve middleware'leri yap�land�r�n
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Startup s�n�f�n� olu�turun ve yap�land�rma i�lemlerini yap�n
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Middleware yap�land�rmas�n� uygulay�n
startup.Configure(app, app.Environment);

app.Run();
