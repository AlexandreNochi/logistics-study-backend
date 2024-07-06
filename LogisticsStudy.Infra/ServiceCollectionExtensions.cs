using LogisticsStudy.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<MongoDbContext>();

        services.AddDbContext<LogisticsContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("Postgre")));

        return services;
    }
}