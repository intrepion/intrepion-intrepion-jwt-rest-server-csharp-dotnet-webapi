using Microsoft.AspNetCore.Mvc;

namespace IntrepionApp.WebApi.HealthCheck;

[ApiController]
public class HealthCheckController : ControllerBase
{
    public IActionResult Get()
    {
        return Ok("");
    }
}
