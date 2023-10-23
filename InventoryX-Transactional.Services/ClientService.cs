
using InventoryX_Transactional.Repository;

namespace InventoryX_Transactional.Services;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;
    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<dynamic> GetClients()
    {
        return await _clientRepository.GetByConditionAsync(c => true);
    }
}
