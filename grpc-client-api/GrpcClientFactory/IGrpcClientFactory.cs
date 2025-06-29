using HelloClient;

namespace grpc_client_api.GrpcClientFactory
{
    public interface IGrpcClientFactory
    {
        Hello.HelloClient CreateHello();
        Hello.HelloClient CreateTest();
        Hello.HelloClient CreateList();

    }
}
