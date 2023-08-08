using System.Reflection;
using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;

namespace MapsterToolBug.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddExampleServices(this IServiceCollection services)
    {
        services.AddMappings();
        return services;
    }

    private static void AddMappings(this IServiceCollection services)
    {
        TypeAdapterConfig config = TypeAdapterConfig.GlobalSettings;
        config.Scan(Assembly.GetExecutingAssembly());

        services.AddSingleton(config);
        services.AddScoped<IMapper, ServiceMapper>();
    }
}