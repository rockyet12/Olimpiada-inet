using Microsoft.EntityFrameworkCore;
using SportStyle.Infrastructure;
using SportStyle.Infrastructure.Repositories;
using SportStyle.Infrastructure.Services;
using SportStyle.Presentation.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddApiVersioning();
builder.Services.AddControllers();

// Se agregan los servicios y repositorios creados
builder.Services.AddOlimpiadasRepository();
builder.Services.AddOlimpiadasService();

builder.Services.AddHttpClient(); // Agrega esta línea para registrar IHttpClientFactory

var connectionString = builder.Configuration.GetConnectionString("Olimpiadas");
var allowedOriginsConfig = builder.Configuration.GetSection("AllowedOrigins").Get<string[]>();

builder.Services.AddDbContext<OlimpiadasDbContext>(options =>
    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 33))));


// Configura HttpClient para ignorar errores de certificado
builder.Services.AddHttpClient("apiClient", client =>
{
    // Configura HttpClient con una BaseAddress válida
    client.BaseAddress = new Uri("http://localhost:5141");
})
.ConfigurePrimaryHttpMessageHandler(() =>
{
    var handler = new HttpClientHandler();
    handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
    return handler;
});


// Configura CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("OlimpiadasPolicy",
        builder => builder.WithOrigins(allowedOriginsConfig!)
                   .AllowAnyHeader()
                   .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseCors("OlimpiadasPolicy");
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapControllers();

app.Run();
