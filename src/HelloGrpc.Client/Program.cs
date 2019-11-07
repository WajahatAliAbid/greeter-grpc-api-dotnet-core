using System;
using System.Threading.Tasks;
using Grpc.Core;
using HelloGrpc.Shared;

namespace HelloGrpc.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Calling SayHello Endpoint with name: 'World'");
            var channel = new Channel("https://localhost:5001",ChannelCredentials.Insecure);
            var client = new Greeter.GreeterClient(channel);
            var helloReply = await client.SayHelloAsync(new HelloRequest { Name = "World" });
            Console.WriteLine($"Response from server, '{helloReply.Message}'");

            var call = client.SayHelloStream(new HelloRequest {Name="World"});
            await foreach (var item in call.ResponseStream.ReadAllAsync())
            {
                Console.WriteLine($"Response from server, '{item.Message}'");
            }
            await channel.ShutdownAsync();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
