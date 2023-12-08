using AutoMapper;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository;
using InventoryX_Transactional.Services.DTOs.Client;
using InventoryX_Transactional.Services.Exceptions;
using Microsoft.Extensions.Logging;

namespace InventoryX_Transactional.Services;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;
    private readonly ClientValidationService _validator;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;

    public ClientService(
        IClientRepository clientRepository,
        IMapper mapper, 
        ILogger<Client> logger,
        ClientValidationService validator)
    {
        _clientRepository = clientRepository;
        _validator = validator;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<ClientDTO> GetClientById(Guid guid)
    {
        var client = await _clientRepository.GetByIdAsync(guid)
            ?? throw new ResourceNotFoundException("Client cannot be found.");

        return _mapper.Map<ClientDTO>(client);
    }

    public async Task<List<ClientDTO>> GetClients()
    {
        var clients = await _clientRepository.GetByConditionAsync(c => true);
        return clients.Select(c => _mapper.Map<ClientDTO>(c)).ToList();
    }

    public async Task<ClientDTO> UpdateClient(UpdateClientDTO client)
    {
        var clientFound = await _clientRepository.GetByIdAsync(client.ClientId) 
            ?? throw new ResourceNotFoundException("Client cannot be found.");

        var clientValidated = await _validator.ValidateForUpdateAsync(client);

        _logger.LogInformation("ClientID: {clientIdFromDto}", client.ClientId);

        var clientToUpdate = _mapper.Map<Client>(clientValidated);
        clientToUpdate.CreatedBy = clientFound.CreatedBy;
        clientToUpdate.CreatedAt = clientFound.CreatedAt;
        clientToUpdate.ModifiedBy = "System";
        clientToUpdate.ModifiedAt = DateTime.UtcNow;

        var clientUpdated = _clientRepository.Update(clientToUpdate);
        await _clientRepository.SaveAsync();

        return _mapper.Map<ClientDTO>(clientUpdated);
    }

    public async Task<ClientDTO> CreateClient(NewClientDTO client)
    {
        var clientValidated = await _validator.ValidateForCreateAsync(client);

        var clientToCreate  = _mapper.Map<Client>(clientValidated);
        clientToCreate.CreatedBy = "System";
        clientToCreate.CreatedAt = DateTime.UtcNow;

        var clientCreated = await _clientRepository.AddAsync(clientToCreate);
        await _clientRepository.SaveAsync();

        return _mapper.Map<ClientDTO>(clientCreated);
    }

    public async Task DeleteClient(Guid guid)
    {
        var result = _clientRepository.Delete(guid);
        if(result == RepositoryOperation.Failed)
        {
            throw new ResourceNotFoundException("Client cannot be found.");
        }

        await _clientRepository.SaveAsync();
    }

}
