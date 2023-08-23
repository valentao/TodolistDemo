using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrasctrucureServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}