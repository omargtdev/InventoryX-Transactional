using System.Diagnostics;
using AutoMapper;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Repository;
using InventoryX_Transactional.Services.DTOs.Provider;
using InventoryX_Transactional.Services.Exceptions;
using Microsoft.Extensions.Logging;

namespace InventoryX_Transactional.Services;

public class ProviderService : IProviderService
{
    private readonly IProviderRepository _providerRepository;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;
    public ProviderService(IProviderRepository providerRepository, IMapper mapper, ILogger<ProviderService> logger)
    {
        _providerRepository = providerRepository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<ProviderDTO> GetProviderById(Guid guid)
    {
        var provider = await _providerRepository.GetByIdAsync(guid)
            ?? throw new ResourceNotFoundException("Provider cannot be found.");

        return _mapper.Map<ProviderDTO>(provider);
    }

    public async Task<List<ProviderDTO>> GetProviders()
    {
        var clients = await _providerRepository.GetByConditionAsync(c => true);
        return clients.Select(c => _mapper.Map<ProviderDTO>(c)).ToList();
    }

    public async Task<ProviderDTO> CreateProvider(NewProviderDTO provider)
    {
        await ValidateRUC(provider);

        var providerToCreate  = _mapper.Map<Provider>(provider);
        providerToCreate.CreatedBy = ""; // For now

        var providerCreated = await _providerRepository.AddAsync(providerToCreate);
        await _providerRepository.SaveAsync();

        return _mapper.Map<ProviderDTO>(providerCreated);
    }

    public async Task<ProviderDTO> UpdateProvider(UpdateProviderDTO provider)
    {

        var providerFound = await _providerRepository.GetByIdAsync(provider.ProviderId) ?? throw new ResourceNotFoundException("Provider cannot be found.");

        await ValidateRUC(provider);

        var providerToUpdate = _mapper.Map<Provider>(provider);
        providerToUpdate.CreatedBy = providerFound!.CreatedBy;
        providerToUpdate.CreatedAt = providerFound.CreatedAt;
        providerToUpdate.ModifiedBy = provider.ActionBy;

        var clientUpdated = _providerRepository.Update(providerToUpdate);
        await _providerRepository.SaveAsync();

        return _mapper.Map<ProviderDTO>(clientUpdated);
    }

    public async Task DeleteProvider(Guid guid)
    {
        var result = _providerRepository.Delete(guid);
        if(result == RepositoryOperation.Failed)
            throw new ResourceNotFoundException("Provider cannot be found.");
        await _providerRepository.SaveAsync();
    }

    private async Task ValidateRUC(NewProviderDTO provider)
    {
        if(provider.RUC.Length != 11)
            throw new InvalidDocumentNumberException("The RUC needs to be 11 characters");

        var providerFound = (await _providerRepository.GetByConditionAsync(p => p.RUC == provider.RUC)).FirstOrDefault();
            
        if(providerFound != null)
            throw new RUCAlreadyExistsForProviderException("RUC already exists for provider");
    }

    private async Task ValidateRUC(UpdateProviderDTO provider)
    {
        if(provider.RUC.Length != 11)
            throw new InvalidDocumentNumberException("The RUC needs to be 11 characters");

        var providerFound = (await _providerRepository.GetByConditionAsync(p => p.RUC == provider.RUC && p.ProviderId != provider.ProviderId)).FirstOrDefault();

        if(providerFound != null)
            throw new RUCAlreadyExistsForProviderException("RUC already exists for provider");

    }

}
