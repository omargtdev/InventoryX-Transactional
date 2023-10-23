using InventoryX_Transactional.Services;
using Microsoft.AspNetCore.Mvc;

namespace InventoryX_Transactional.API;


[ApiController]
[Route("[controller]s")]
public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;

    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpGet]
    public async Task<IActionResult> GetClients()
    {
        var clients = await _clientService.GetClients();
        return Ok(clients);
    }

}
