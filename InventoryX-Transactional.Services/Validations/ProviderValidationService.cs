using System.Text.RegularExpressions;
using AutoMapper;
using InventoryX_Transactional.Data.Models;
using InventoryX_Transactional.Extensions;
using InventoryX_Transactional.Repository.Common;
using InventoryX_Transactional.Services.DTOs.Provider;
using Microsoft.IdentityModel.Tokens;

namespace InventoryX_Transactional.Services.Validations;

public class ProviderValidationService
{
    private readonly IGenericRepository<Provider> _providerRepository;

    public ProviderValidationService(IGenericRepository<Provider> providerRepository)
    {
        _providerRepository = providerRepository;
    }

    public async Task<NewProviderDTO> ValidateForCreate(NewProviderDTO provider)
    {
        if(provider.RUC.Length != 11)
            throw new InvalidDocumentNumberException("The RUC needs to be 11 numbers.");
            
        if(!Regex.Match(provider.RUC, @"^20\d{9}$").Success)
            throw new InvalidDocumentNumberException($"The RUC {provider.RUC} is invalid for a provider.");

        if(provider.BusinessName.IsLessThan3Characters())
            throw new EntityRuleException("Invalid business name for provider.");

        var providerFound = (await _providerRepository.GetByConditionAsync(p => p.RUC == provider.RUC)).FirstOrDefault();
            
        if(providerFound is not null)
            throw new DuplicateEntityException("RUC already exists for provider.");

        return provider;
    }
}
