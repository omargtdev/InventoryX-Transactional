using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository;
using InventoryX_Transactional.Repository.Common;
using InventoryX_Transactional.Repository.UnitOfWork;

namespace InventoryX_Transactional.API.Extensions;

public static class RepositoriesExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IGenericRepository<Client>, GenericRepository<Client>>();
        services.AddScoped<IGenericRepository<Provider>, GenericRepository<Provider>>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IClientRepository, ClientRepository>();
        services.AddScoped<IProviderRepository, ProviderRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IWarehouseRepository, WarehouseRepository>();

        return services;
    }
}
