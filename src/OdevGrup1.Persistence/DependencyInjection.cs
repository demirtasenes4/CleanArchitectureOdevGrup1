using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OdevGrup1.Domain.Entities;
using OdevGrup1.Domain.Repositories;
using OdevGrup1.Persistence.Context;
using Scrutor;

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

        services.AddIdentityCore<AppUser>(cfr =>
        {
            cfr.Password.RequireNonAlphanumeric = false;
            cfr.Password.RequiredLength = 1;
            cfr.Password.RequireDigit = false;
            cfr.Password.RequireNonAlphanumeric = false;
            cfr.Password.RequireUppercase = false;
            cfr.Password.RequireLowercase = false;
        }).AddEntityFrameworkStores<AppDbContext>();

        services.AddScoped<IUnitOfWork>(sv => sv.GetRequiredService<AppDbContext>());

        services.Scan(selector => selector
            .FromAssemblies(
                typeof(DependencyInjection).Assembly)
            .AddClasses(publicOnly: false)
            .UsingRegistrationStrategy(RegistrationStrategy.Skip)
            .AsMatchingInterface()
            .WithScopedLifetime());

        services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

        services.AddAutoMapper(typeof(DependencyInjection).Assembly);

        

        return services;
    }
}
