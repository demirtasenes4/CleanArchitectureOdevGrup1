using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevGrup1.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssemblies(
                typeof(DependencyInjection).Assembly);

            //configuration.AddOpenBehavior(typeof(ValidationBehavior<,>));
        });

        services.AddAutoMapper(typeof(DependencyInjection).Assembly);

        return services;
    }
}

