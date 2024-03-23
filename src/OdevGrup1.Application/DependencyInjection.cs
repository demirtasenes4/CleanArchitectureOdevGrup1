﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using OdevGrup1.Application.Behaviors;
using OdevGrup1.Domain.Entities;

namespace OdevGrup1.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssemblies(
                typeof(DependencyInjection).Assembly,
                typeof(AppUser).Assembly);

            configuration.AddOpenBehavior(typeof(ValidationBehavior<,>));
        });


        services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

        services.AddAutoMapper(typeof(DependencyInjection).Assembly);

        return services;
    }
}

