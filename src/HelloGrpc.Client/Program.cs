using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using HelloGrpc.Server;

namespace HelloGrpc.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Calling SayHello Endpoint with name: 'World'");

            var channel = GrpcChannel.ForAddress("http://localhost:5000");
            var client = new Greeter.GreeterClient(channel);
            var helloReply = await client.SayHelloAsync(new HelloRequest { Name = "World" });
            Console.WriteLine($"Response from server, '{helloReply.Message}'");
        }
    }
}
