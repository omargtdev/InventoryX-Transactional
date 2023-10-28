using InventoryX_Transactional.API.MapperProfiles;
using InventoryX_Transactional.Services;

namespace InventoryX_Transactional.API.Extensions;

public static class ServicesExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(DTOMapperProfile), typeof(ViewModelMapperProfile));

        services.AddScoped<IClientService, ClientService>();
        services.AddScoped<IProviderService, ProviderService>();

        return services;
    }
}
