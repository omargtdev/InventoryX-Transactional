using AutoMapper;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository;
using InventoryX_Transactional.Services.DTOs.Client;
using InventoryX_Transactional.Services.Exceptions;
using InventoryX_Transactional.Services.Exceptions.Client;
using Microsoft.Extensions.Logging;

namespace InventoryX_Transactional.Services;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;
    public ClientService(IClientRepository clientRepository, IMapper mapper, ILogger<Client> logger)
    {
        _clientRepository = clientRepository;
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
        var clientFound = await _clientRepository.GetByIdAsync(client.ClientId);
        if(clientFound == null)
            throw new ResourceNotFoundException("Client cannot be found.");

        ValidateDocumentTypeWhenClientIsLegal(client);
        ValidateDocumentTypeLength(client.DocumentType, client.DocumentNumber);

        _logger.LogInformation("ClientID: {clientIdFromDto}", client.ClientId);
        var clientByEmail = (await _clientRepository.GetByConditionAsync(c => c.Email == client.Email && c.ClientId != client.ClientId)).FirstOrDefault();
        if(clientByEmail != null)
            throw new EmailAlreadyExistForClientException("The email has already been taken.");

        var clientToUpdate = _mapper.Map<Client>(client);
        clientToUpdate.CreatedBy = clientFound.CreatedBy;
        clientToUpdate.CreatedAt = clientFound.CreatedAt;
        clientToUpdate.ModifiedBy = client.ActionBy;

        var clientUpdated = _clientRepository.Update(clientToUpdate);
        await _clientRepository.SaveAsync();

        return _mapper.Map<ClientDTO>(clientUpdated);
    }

    public async Task<ClientDTO> CreateClient(NewClientDTO client)
    {
        ValidateDocumentTypeWhenClientIsLegal(client);
        ValidateDocumentTypeLength(client.DocumentType, client.DocumentNumber);
        
        var clientByEmail = (await _clientRepository.GetByConditionAsync(c => c.Email == client.Email)).FirstOrDefault();
        if(clientByEmail != null)
            throw new EmailAlreadyExistForClientException("The email has already been taken.");

        var clientToCreate  = _mapper.Map<Client>(client);
        clientToCreate.CreatedBy = ""; // For now

        var clientCreated = await _clientRepository.AddAsync(clientToCreate);
        await _clientRepository.SaveAsync();

        return _mapper.Map<ClientDTO>(clientCreated);
    }

    public async Task DeleteClient(Guid guid)
    {
        var result = _clientRepository.Delete(guid);
        if(result == RepositoryOperation.Failed)
            throw new ResourceNotFoundException("Client cannot be found.");
        await _clientRepository.SaveAsync();
    }

    private void ValidateDocumentTypeWhenClientIsLegal(NewClientDTO client)
    {
        if(client.IsLegal && client.DocumentType != DocumentTypeClient.RUC)
            throw new InvalidDocumentTypeForLegalClientException("Invalid document type for legal client");

    }

    private void ValidateDocumentTypeWhenClientIsLegal(UpdateClientDTO client)
    {
        if(client.IsLegal && client.DocumentType != DocumentTypeClient.RUC)
            throw new InvalidDocumentTypeForLegalClientException("Invalid document type for legal client");

    }

    private void ValidateDocumentTypeLength(DocumentTypeClient documentTypeClient, string documentNumber)
    {
        switch (documentTypeClient)
        {
            case DocumentTypeClient.DNI:
                if(documentNumber.Length != 8)
                    throw new InvalidDocumentNumberException(
                        $"The {DocumentTypeClient.DNI} needs a length of 8."
                    );
                return;
            case DocumentTypeClient.RUC: 
                if(documentNumber.Length != 11)
                    throw new InvalidDocumentNumberException(
                        $"The {DocumentTypeClient.RUC} needs a length of 11."
                    );
                return;
            case DocumentTypeClient.ImmigrationCard: 
                if(documentNumber.Length != 15)
                    throw new InvalidDocumentNumberException(
                        $"The {DocumentTypeClient.ImmigrationCard} needs a length of 15."
                    );
                return;
            default:
                throw new ArgumentOutOfRangeException($"Not valid value for {nameof(documentTypeClient)}.");
        }
    }
}
