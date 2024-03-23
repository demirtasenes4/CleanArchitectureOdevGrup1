using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OdevGrup1.Persistence.Context;

namespace OdevGrup1.Persistence;
public static class DependencyInjection
{
    public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
    {

        //var connectionString = configuration.GetConnectionString("SqlServer");
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseInMemoryDatabase("MyDb");
        });

        return services;
    }
}
