# gRPC implementation using .net core
## What is gRPC

gRPC (gRPC Remote Procedure Calls) is an open source remote procedure call (RPC) system initially developed at Google. It uses HTTP/2 for transport, Protocol Buffers as the interface description language, and provides features such as authentication, bidirectional streaming and flow control, blocking or nonblocking bindings, and cancellation and timeouts.

You can read more about grpc [here](https://grpc.io)
## Introduction
It's a basic Hello World grpc Api where we have a [server](./src/HelloGrpc.Server) and a [client](./src/HelloGrpc.Client). To run the application, first boot up the server by running the command 
```bash
    dotnet run -p ./src/HelloGrpc.Server/HelloGrpc.Server.csproj
```
Open another instance of terminal and run the following command
```
    dotnet run -p ./src/HelloGrpc.Client/HelloGrpc.Client.csproj
```