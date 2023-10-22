using Microsoft.AspNetCore.Mvc;

namespace InventoryX_Transactional.API.Controllers;

[ApiController]
[Route("[controller]")]
public class SettingsController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public SettingsController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    public IActionResult Settings()
    {
       return Ok(new 
       {
        LoggingLogLevel = _configuration.GetValue<string>("Logging:LogLevel:Default"),
        Mode = _configuration.GetValue<string>("MyMode")
       });

    }

}
