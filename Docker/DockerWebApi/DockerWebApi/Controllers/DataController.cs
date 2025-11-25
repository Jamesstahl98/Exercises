using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace DockerWebApi.Controllers
{
    [Route("[controller]")]
    public class DataController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public DataController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Info()
        {
            var filePath = Path.Combine(_env.ContentRootPath, "data", "info.txt");
            if (!System.IO.File.Exists(filePath))
                return NotFound("info.txt not found.");

            var content = await System.IO.File.ReadAllTextAsync(filePath);
            return Content(content, "text/plain; charset=utf-8");
        }
    }
}
