using InventoryX_Transactional.Services;

namespace InventoryX_Transactional.API.Extensions;

public static class ServicesExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IClientService, ClientService>();

        return services;
    }
}
