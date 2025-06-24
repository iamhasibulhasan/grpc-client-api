using Grpc.Net.Client;
using GrpcClient;

namespace grpc_client_api.Services;
public class GrpcGreeterClient
{
    private readonly Greeter.GreeterClient _client;

    public GrpcGreeterClient(IConfiguration configuration)
    {
        // Get the server address from configuration
        var serverAddress = configuration["GrpcServer"];

        // Create gRPC channel and client
        var channel = GrpcChannel.ForAddress(serverAddress);
        _client = new Greeter.GreeterClient(channel);
    }

    public async Task<string> SayHello(string name)
    {
        var reply = await _client.SayHelloAsync(new HelloRequest { Name = name });
        return reply.Message;
    }

    public async Task<IEnumerable<WeatherForecast>> GetWeather(string location, int days)
    {
        var reply = await _client.GetWeatherAsync(new WeatherRequest
        {
            Location = location,
            Days = days
        });

        return reply.Forecasts.Select(f => new WeatherForecast
        {
            Date = f.Date,
            TemperatureC = f.TemperatureC,
            Summary = f.Summary
        });
    }
}

