using Microsoft.Extensions.DependencyInjection;
using SportStyle.Application.Repositories;

namespace SportStyle.Infrastructure.Repositories;

public static class ConfigureRepository
{
    public static IServiceCollection AddOlimpiadasRepository(this IServiceCollection services)
    {
        // Cada Repository que se crea, se tiene que agregar acá para que funcionen
        services.AddTransient<IClienteRepository, ClienteRepository>();

        return services;
    }
}
