using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Extensions;
using InventoryX_Transactional.Repository.Common;
using InventoryX_Transactional.Services.DTOs.Client;

namespace InventoryX_Transactional.Services;

public class ClientValidationService
{
    private readonly IGenericRepository<Client> _clientRepository;

    public ClientValidationService(IGenericRepository<Client> clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<NewClientDTO> ValidateForCreateAsync(NewClientDTO client)
    {
        if(client.Name.IsNullOrEmptyOrWhiteSpace())
        {
            throw new EntityRuleException($"The {nameof(client.Name)} cannot be empty.");
        }

        if(!client.Email.IsValidEmail())
        {
            throw new EntityRuleException($"The {nameof(client.Email)} is invalid.");
        }

        if(client.DocumentNumber.IsNullOrEmptyOrWhiteSpace() || !client.DocumentNumber.HasOnlyNumbers())
        {
            throw new EntityRuleException($"The {nameof(client.DocumentNumber)} is invalid.");
        }

        ValidateDocumentTypeLength(client.DocumentType, client.DocumentNumber);

        if(!client.Phone.IsValidPhoneNumber())
        {
            throw new EntityRuleException($"The {nameof(client.Phone)} is invalid");
        }

        if(client.IsLegal)
        {
            ValidateDocumentForLegalClient(client.DocumentType, client.DocumentNumber);
        }

        if(await DocumentNumberAlreadyExistAsync(client.DocumentNumber))
        {
            throw new EntityRuleException($"The document number '{client.DocumentNumber}' has already been taken.");
        }

        if(await EmailAlreadyExistAsync(client.Email))
        {
            throw new EntityRuleException($"The email '{client.Email}' has already been taken.");
        }

        if(await PhoneNumberAlreadyExistAsync(client.Phone))
        {
            throw new EntityRuleException($"The phone '{client.Phone}' has already been taken.");
        }

        return client;
    }


    // TODO: Remove duplicate code for validation
    public async Task<UpdateClientDTO> ValidateForUpdateAsync(UpdateClientDTO client)
    {
        if(client.Name.IsNullOrEmptyOrWhiteSpace())
        {
            throw new EntityRuleException($"The {nameof(client.Name)} cannot be empty.");
        }

        if(!client.Email.IsValidEmail())
        {
            throw new EntityRuleException($"The {nameof(client.Email)} is invalid.");
        }

        if(client.DocumentNumber.IsNullOrEmptyOrWhiteSpace() || !client.DocumentNumber.HasOnlyNumbers())
        {
            throw new EntityRuleException($"The {nameof(client.DocumentNumber)} is invalid.");
        }

        ValidateDocumentTypeLength(client.DocumentType, client.DocumentNumber);

        if(!client.Phone.IsValidPhoneNumber())
        {
            throw new EntityRuleException($"The {nameof(client.Phone)} is invalid");
        }

        if(client.IsLegal)
        {
            ValidateDocumentForLegalClient(client.DocumentType, client.DocumentNumber);
        }

        if(await DocumentNumberAlreadyExistAsync(client.DocumentNumber, client.ClientId))
        {
            throw new EntityRuleException($"The document number '{client.DocumentNumber}' has already been taken.");
        }

        if(await EmailAlreadyExistAsync(client.Email, client.ClientId))
        {
            throw new EntityRuleException($"The email '{client.Email}' has already been taken.");
        }

        if(await PhoneNumberAlreadyExistAsync(client.Phone, client.ClientId))
        {
            throw new EntityRuleException($"The phone '{client.Phone}' has already been taken.");
        }

        return client;
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
                break;
            case DocumentTypeClient.RUC: 
                if(documentNumber.Length != 11)
                    throw new InvalidDocumentNumberException(
                        $"The {DocumentTypeClient.RUC} needs a length of 11."
                    );
                break;
            case DocumentTypeClient.ImmigrationCard: 
                if(documentNumber.Length != 15)
                    throw new InvalidDocumentNumberException(
                        $"The {DocumentTypeClient.ImmigrationCard} needs a length of 15."
                    );
                break;
            default:
                throw new ArgumentOutOfRangeException($"Not valid value for {nameof(documentTypeClient)}.");
        }
    }

    private void ValidateDocumentForLegalClient(DocumentTypeClient documentType, string documentNumber)
    {
        if(documentType != DocumentTypeClient.RUC)
        {
            throw new EntityRuleException($"A legal client must have a ruc document begins with 20");
        }

        if(!documentNumber.StartsWith("20"))
        {
            throw new EntityRuleException($"A legal client must have a ruc document begins with 20");
        }
    }

    private async Task<bool> DocumentNumberAlreadyExistAsync(string documentNumber, Guid? excludeId = null)
    {
        IEnumerable<Client> clients;

        if(excludeId is not null)
        {
            clients = await _clientRepository.GetByConditionAsync(
                c => c.DocumentNumber == documentNumber &&
                     c.ClientId != excludeId
            );
        }
        else
        {
            clients = await _clientRepository.GetByConditionAsync(
                c => c.DocumentNumber == documentNumber
            );
        }


        return clients.FirstOrDefault() is not null;
    }

    private async Task<bool> EmailAlreadyExistAsync(string email, Guid? excludeId = null)
    {
        IEnumerable<Client> clients;

        if(excludeId is not null)
        {
            clients = await _clientRepository.GetByConditionAsync(
                c => c.Email == email &&
                     c.ClientId != excludeId
            );
        }
        else
        {
            clients = await _clientRepository.GetByConditionAsync(
                c => c.Email == email 
            );
        }

        return clients.FirstOrDefault() is not null;
    }

    private async Task<bool> PhoneNumberAlreadyExistAsync(string phoneNumber, Guid? excludeId = null)
    {
        IEnumerable<Client> clients;

        if(excludeId is not null)
        {
            clients = await _clientRepository.GetByConditionAsync(
                c => c.Phone == phoneNumber &&
                     c.ClientId != excludeId
            );
        }
        else
        {
            clients = await _clientRepository.GetByConditionAsync(
                c => c.Phone == phoneNumber
            );
        }

        return clients.FirstOrDefault() is not null;
    }
}
