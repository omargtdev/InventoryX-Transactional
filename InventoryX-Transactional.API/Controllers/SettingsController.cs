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
            IdentityApi = _configuration.GetValue<string>("Api:Identity"),
            ConnectionString = _configuration.GetConnectionString("InventoryxDb")
        });

    }

}
