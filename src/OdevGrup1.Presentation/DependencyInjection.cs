﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OdevGrup1.Application;
using OdevGrup1.Persistence;

namespace OdevGrup1.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddApplication();
        services.AddPersistance(configuration);

        return services;
    }
}
