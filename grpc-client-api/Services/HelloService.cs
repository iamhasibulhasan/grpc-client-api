using Google.Protobuf.WellKnownTypes;
using grpc_client_api.GrpcClientFactory;
using HelloClient;

namespace grpc_client_api.Services;

public class HelloService
{
    private readonly IGrpcClientFactory _grpcClientFactory;

    public HelloService(IGrpcClientFactory grpcClientFactory)
    {
        _grpcClientFactory = grpcClientFactory;
    }

    public async Task<string> GetHelloMessage(string name)
    {
        var service = _grpcClientFactory.CreateHello();
        var response = await service.SayHelloAsync(new HelloMessageRequest { Name = name });
        return response.Message;
    }

    public async Task<TestReply> GetTest()
    {
        var service = _grpcClientFactory.CreateTest();
        var response = await service.SayTestAsync(new Empty());
        return response;
    }

    public async Task<List<CreateList>> GetList()
    {
        var service = _grpcClientFactory.CreateList();
        var response = await service.ShowListAsync(new Empty());
        return response.List.ToList(); // Access the 'List' property and convert it to a List<CreateList>
    }
}
