using AutoMapper;
using InventoryX_Transactional.API.ViewModels;
using InventoryX_Transactional.API.ViewModels.Client;
using InventoryX_Transactional.Services;
using InventoryX_Transactional.Services.DTOs.Client;
using InventoryX_Transactional.Services.Exceptions;
using InventoryX_Transactional.Services.Exceptions.Client;
using Microsoft.AspNetCore.Mvc;

namespace InventoryX_Transactional.API;


[ApiController]
[Route("[controller]s")]
public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;
    private readonly IMapper _mapper;

    public ClientController(IClientService clientService, IMapper mapper)
    {
        _clientService = clientService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<ClientViewModel>>> GetClients()
    {
        var clients = await _clientService.GetClients();
        return Ok(clients.Select(c => _mapper.Map<ClientViewModel>(c)));
    }

    [HttpGet]
    [Route("{clientId}")]
    public async Task<ActionResult<ClientViewModel>> GetClientById(Guid clientId)
    {
        try
        {
            var client = await _clientService.GetClientById(clientId);
            
            return Ok(_mapper.Map<ClientViewModel>(client));
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
    public async Task<IActionResult> CreateClient([FromBody] NewClientViewModel newClient)
    {
        try
        {
            if(!ModelState.IsValid)    
                return BadRequest(ModelState.Values.SelectMany(v => v.Errors));
            
            var client = await _clientService.CreateClient(_mapper.Map<NewClientDTO>(newClient));
            return CreatedAtAction(null, client);
        }
        catch (Exception ex)
        {
            return ex switch
            {
                InvalidDocumentTypeForLegalClientException or 
                InvalidDocumentNumberLengthException or 
                EmailAlreadyExistForClientException => BadRequest(_mapper.Map<ResponseErrorViewModel>(ex)),
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
    [Route("{clientId}")]
    public async Task<IActionResult> UpdateClient(Guid clientId, [FromBody] UpdateClientViewModel clientToUpdate)
    {
        try
        {
            if(!ModelState.IsValid)    
                return BadRequest(ModelState.Values.SelectMany(v => v.Errors));
            
            var clientMapped =_mapper.Map<UpdateClientDTO>(clientToUpdate); 
            clientMapped.ClientId = clientId;
            var client = await _clientService.UpdateClient(clientMapped);
            
            return Ok(client);
        }
        catch (Exception ex)
        {
            return ex switch
            {
                ResourceNotFoundException or
                InvalidDocumentTypeForLegalClientException or 
                InvalidDocumentNumberLengthException or 
                EmailAlreadyExistForClientException => BadRequest(_mapper.Map<ResponseErrorViewModel>(ex)),
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
    [Route("{clientId}")]
    public async Task<IActionResult> DeleteClient(Guid clientId)
    {
        try
        {
            await _clientService.DeleteClient(clientId);
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
