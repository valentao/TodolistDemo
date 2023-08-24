using Microsoft.Extensions.Configuration;
using TodolistDemo.Application.Common.Interfaces;
using TodolistDemo.Infrastructure.Identity;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrasctrucureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IIdentityService, IdentityService>();

        return services;
    }
}