using Microsoft.AspNetCore.Mvc;

namespace OpenShift.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetOpenShift")]
        public string Get()
        {
            return "Hola Mundo OpenShift";
        }
    }
}
