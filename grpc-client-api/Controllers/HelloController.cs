using grpc_client_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace grpc_client_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly HelloService _helloService;

        public HelloController(HelloService helloService)
        {
            _helloService = helloService;
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetHelloMessage(string name)
        {
            return Ok(await _helloService.GetHelloMessage(name));
        }

        [HttpGet("test")]
        public async Task<IActionResult> GetTest()
        {
            return Ok(await _helloService.GetTest());
        }
    }
}
