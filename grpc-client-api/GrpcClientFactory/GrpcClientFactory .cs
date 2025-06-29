using Grpc.Net.Client;
using HelloClient;

namespace grpc_client_api.GrpcClientFactory;

public class GrpcClientFactory : IGrpcClientFactory
{
    private readonly IConfiguration _config;

    public GrpcClientFactory(IConfiguration config)
    {
        _config = config;
    }


    public Hello.HelloClient CreateHello()
    {
        var channel = GrpcChannel.ForAddress(_config["GrpcServer"]);
        return new Hello.HelloClient(channel);
    }

    public Hello.HelloClient CreateList()
    {
        var channel = GrpcChannel.ForAddress(_config["GrpcServer"]);
        return new Hello.HelloClient(channel);
    }

    public Hello.HelloClient CreateTest()
    {
        var channel = GrpcChannel.ForAddress(_config["GrpcServer"]);
        return new Hello.HelloClient(channel);
    }


}
