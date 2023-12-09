using InventoryX_Transactional.API.MapperProfiles;
using InventoryX_Transactional.Services;
using InventoryX_Transactional.Services.Azure;
using InventoryX_Transactional.Services.Validations;

namespace InventoryX_Transactional.API.Extensions;

public static class ServicesExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(DTOMapperProfile), typeof(ViewModelMapperProfile));

        services.AddScoped<ProductValidationService>();
        services.AddScoped<ProviderValidationService>();
        services.AddScoped<ReceiptValidationService>();
        services.AddScoped<ClientValidationService>();
        services.AddScoped<IssueValidationService>();

        services.AddScoped<IClientService, ClientService>();
        services.AddScoped<IProviderService, ProviderService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IWarehouseService, WarehouseService>();
        services.AddScoped<IReceiptService, ReceiptService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IReceiptService, ReceiptService>();
        services.AddScoped<IIssueService, IssueService>();


        services.AddScoped<IAzureFileService, AzureFileService>();

        return services;
    }
}
