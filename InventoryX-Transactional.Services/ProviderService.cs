using InventoryX_Transactional.Repository;

namespace InventoryX_Transactional.Services;

public class ProviderService
{
    private readonly IProviderRepository _providerRepository;
    public ProviderService(IProviderRepository providerRepository)
    {
        _providerRepository = providerRepository;
    }
}
