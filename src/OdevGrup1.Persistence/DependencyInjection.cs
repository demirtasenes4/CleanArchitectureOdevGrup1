using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OdevGrup1.Domain.Repositories;
using OdevGrup1.Persistence.Context;

namespace OdevGrup1.Persistence;
public static class DependencyInjection
{
    public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
    {

        //var connectionString = configuration.GetConnectionString("SqlServer");

        services.AddScoped<IUnitOfWork>(sv => sv.GetRequiredService<AppDbContext>());
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseInMemoryDatabase("MyDb");
        });

        //services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
        //.AddEntityFrameworkStores<ApplicationDbContext>();
        //services.AddIdentity<AppUser, IdentityRole>()
        //.AddEntityFrameworkStores<AppDbContext>()
        //.AddDefaultTokenProviders();

        return services;
    }
}
