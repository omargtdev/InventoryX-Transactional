using AutoMapper;
using InventoryX_Transactional.API.ViewModels;
using InventoryX_Transactional.API.ViewModels.Provider;
using InventoryX_Transactional.Services;
using InventoryX_Transactional.Services.DTOs.Provider;
using InventoryX_Transactional.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace InventoryX_Transactional.API.Controllers;

[ApiController]
[Route("[controller]s")]
public class ProviderController : ControllerBase
{
    private readonly IProviderService _providerService;
    private readonly IMapper _mapper;

    public ProviderController(IProviderService providerService, IMapper mapper)
    {
        _providerService = providerService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<ProviderViewModel>>> GetProviders()
    {
        var providers = await _providerService.GetProviders();
        return Ok(providers.Select(p => _mapper.Map<ProviderViewModel>(p)));
    }

    [HttpGet]
    [Route("{providerId}")]
    public async Task<ActionResult<ProviderViewModel>> GetProviderById(Guid providerId)
    {
        try
        {
            var provider = await _providerService.GetProviderById(providerId);
            return Ok(_mapper.Map<ProviderViewModel>(provider));
        }
        catch (Exception ex)
        {
            return ex switch
            {
                ResourceNotFoundException => NotFound(_mapper.Map<ResponseErrorViewModel>(ex)),
                _ => StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ResponseErrorViewModel
                    {
                        Type = "ServerError",
                        Message = ex.Message
                    }
                ),
            };
        }
    }

    [HttpPost]
    public async Task<IActionResult> CreateProvider([FromBody] NewProviderViewModel newProvider)
    {
        try
        {
            if(!ModelState.IsValid)    
                return BadRequest(ModelState.Values.SelectMany(v => v.Errors));
            
            var provider = await _providerService.CreateProvider(_mapper.Map<NewProviderDTO>(newProvider));
            return CreatedAtAction(null, provider);
        }
        catch (Exception ex)
        {
            return ex switch
            {
                InvalidDocumentNumberLengthException or 
                RUCAlreadyExistsForProviderException => BadRequest(_mapper.Map<ResponseErrorViewModel>(ex)),
                _ => StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ResponseErrorViewModel
                    {
                        Type = "ServerError",
                        Message = ex.Message
                    }
                ),
            };
        }
    }

    [HttpPut]
    [Route("{providerId}")]
    public async Task<IActionResult> UpdateProvider(Guid providerId, [FromBody] UpdateProviderViewModel providerToUpdate)
    {
        try
        {
            if(!ModelState.IsValid)    
                return BadRequest(ModelState.Values.SelectMany(v => v.Errors));
            
            var providerMapped =_mapper.Map<UpdateProviderDTO>(providerToUpdate); 
            providerMapped.ProviderId = providerId;
            var provider = await _providerService.UpdateProvider(providerMapped);
            
            return Ok(provider);
        }
        catch (Exception ex)
        {
            return ex switch
            {
                ResourceNotFoundException or
                RUCAlreadyExistsForProviderException or 
                InvalidDocumentNumberLengthException => BadRequest(_mapper.Map<ResponseErrorViewModel>(ex)),
                _ => StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ResponseErrorViewModel
                    {
                        Type = "ServerError",
                        Message = ex.Message
                    }
                ),
            };
        }
    }

    [HttpDelete]
    [Route("{providerId}")]
    public async Task<IActionResult> DeleteProvider(Guid providerId)
    {
        try
        {
            await _providerService.DeleteProvider(providerId);
            return NoContent();
        }
        catch (Exception ex)
        {
            return ex switch
            {
                ResourceNotFoundException => BadRequest(_mapper.Map<ResponseErrorViewModel>(ex)),
                _ => StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ResponseErrorViewModel
                    {
                        Type = "ServerError",
                        Message = ex.Message
                    }
                ),
            };
        }
    }
}
