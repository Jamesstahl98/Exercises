using Microsoft.AspNetCore.Mvc;

namespace Hello1.api.Controllers;

[Route("api/[controller]")]
public class Hello1Controller : Controller
{
    public IActionResult Get()
    {
        return Ok("Hello from Hello1 API!");
    }
}
