using Microsoft.Extensions.DependencyInjection;
using SportStyle.Application.Services;

namespace SportStyle.Infrastructure.Services;

public static class ConfigureService
{
    public static IServiceCollection AddOlimpiadasService(this IServiceCollection services)
    {
        // Cada service que se crea, se tiene que agregar acá para que funcionen
        services.AddScoped<IClienteService, ClienteService>();

        return services;
    }
}
