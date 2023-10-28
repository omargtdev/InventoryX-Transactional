using InventoryX_Transactional.Services.DTOs.Provider;

namespace InventoryX_Transactional.Services;

public interface IProviderService
{
    Task<List<ProviderDTO>> GetProviders();
    Task<ProviderDTO> GetProviderById(Guid guid);
    Task<ProviderDTO> CreateProvider(NewProviderDTO provider);
    Task<ProviderDTO> UpdateProvider(UpdateProviderDTO provider);
    Task DeleteProvider(Guid guid);
}
