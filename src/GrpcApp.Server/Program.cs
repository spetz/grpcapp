using System;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcApp.Core;

namespace GrpcApp.Server
{
    class Program
    {
        static async Task Main(string[] args)
        {
            const string host = "localhost";
            const int port = 50000;

            Console.WriteLine("Starting a server...");

            var server = new Grpc.Core.Server
            {
                Services = { DemoService.BindService(new DemoServiceHost()) },
                Ports = {new ServerPort(host, port, ServerCredentials.Insecure)}
            };
            
            server.Start();

            Console.WriteLine($"Listening on port {port}...");
            Console.ReadKey();

            await server.ShutdownAsync();
        }
    }

    class DemoServiceHost : DemoService.DemoServiceBase
    {
        public override async Task<Empty> Send(Message request, ServerCallContext context)
        {
            await Task.CompletedTask;
            Console.WriteLine($"Received a message: {request.Content} from: {context.Peer}");
            
            return new Empty();
        }
    }
}
