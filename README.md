# gRPC Client API (.NET 8)

This project is a gRPC client built with .NET 8 that communicates with a gRPC server using Protocol Buffers. It demonstrates how to consume gRPC services from a .NET client, including sending requests and handling responses.

> 🔗 Client Repo: [grpc-client-api](https://github.com/iamhasibulhasan/grpc-client-api)  
> 🔗 Server Repo: [grpc-server-api](https://github.com/iamhasibulhasan/grpc-server-api)

---

## 🚀 Features

- **SayHello**: Sends a name and receives a greeting message.
- **SayTest**: Requests a test reply containing an ID, name, and company.
- **ShowList**: Retrieves a list of items, each with an ID, name, and company.

---

## 🧰 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Access to and running instance of the gRPC Server:
  [grpc-server-api](https://github.com/iamhasibulhasan/grpc-server-api)

---

## 📦 Required NuGet Packages

Install the following packages:

```bash
dotnet add package Grpc.Net.Client
dotnet add package Google.Protobuf
dotnet add package Grpc.Tools
```
