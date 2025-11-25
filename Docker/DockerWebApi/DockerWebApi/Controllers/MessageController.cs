using Microsoft.AspNetCore.Mvc;

namespace DockerWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IConfiguration _config;

        public MessageController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public string Get()
        {
            return _config["Message"];
        }
    }
}