using InventoryX_Transactional.Services.Azure;
using Microsoft.AspNetCore.Mvc;

namespace InventoryX_Transactional.API.Controllers;

[ApiController]
[Route("[controller]s")]
public class TestController : ControllerBase
{
    private readonly IAzureFileService _azureFileService;

    public TestController(IAzureFileService azureFileService)
    {
        _azureFileService = azureFileService;
    }

    [HttpGet]
    [Route("BlobStorageObject")]
    public async Task<IActionResult> BlobObject([FromQuery] string container)
    {
        //return Ok(await _azureFileService.UploadFileAsync(container));
        return Ok();
    }
}
