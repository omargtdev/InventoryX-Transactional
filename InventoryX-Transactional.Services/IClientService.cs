using InventoryX_Transactional.Services.DTOs.Client;

namespace InventoryX_Transactional.Services;
public interface IClientService
{
    Task<List<ClientDTO>> GetClients();
    Task<ClientDTO> GetClientById(Guid guid);
    Task<ClientDTO> CreateClient(NewClientDTO client);
    Task<ClientDTO> UpdateClient(UpdateClientDTO client);
    Task DeleteClient(Guid guid);
}
