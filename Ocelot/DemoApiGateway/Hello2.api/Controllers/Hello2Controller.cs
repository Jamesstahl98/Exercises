using Microsoft.AspNetCore.Mvc;

namespace Hello2.api.Controllers;

[Route("api/[controller]")]
public class Hello2Controller : Controller
{
    public IActionResult Get()
    {
        return Ok("Hello from Hello2 API!");
    }
}
