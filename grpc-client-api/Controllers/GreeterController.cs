using grpc_client_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace grpc_client_api.Controllers;

[ApiController]
[Route("[controller]")]
public class GreeterController : ControllerBase
{
    private readonly GrpcGreeterClient _grpcClient;

    public GreeterController(GrpcGreeterClient grpcClient)
    {
        _grpcClient = grpcClient;
    }

    [HttpGet("hello/{name}")]
    public async Task<ActionResult<string>> SayHello(string name)
    {
        return await _grpcClient.SayHello(name);
    }

    [HttpGet("weather/{location}/{days}")]
    public async Task<ActionResult<IEnumerable<WeatherForecast>>> GetWeather(string location, int days)
    {
        return Ok(await _grpcClient.GetWeather(location, days));
    }
}