using LomaNegra.Domain;
using LomaNegra.Infrastructure.Repositories;
using FluentValidation;

namespace LomaNegra.DIP;

public static class DependencyInjection
{
    /**
     * Repository Sector. 
     */
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.AddScoped<IBursatil, BursatilRepository>();

        return services;
    }

    /**    
     *  Application Sector
     */
    public static IServiceCollection AddApplication(
        this IServiceCollection services
    )
    {
        var assembly = typeof(DependencyInjection).Assembly;

        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(assembly));

        services.AddValidatorsFromAssembly(assembly);

        return services;
    }
}
