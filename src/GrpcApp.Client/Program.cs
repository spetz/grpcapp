using System;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcApp.Core;

namespace GrpcApp.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            const string host = "localhost";
            const int port = 50000;

            var channel = new Channel($"{host}:{port}", ChannelCredentials.Insecure);
            var client = new DemoService.DemoServiceClient(channel);

            Console.WriteLine("Client has started...");

            while (true)
            {
                Console.ReadKey();
                await client.SendAsync(new Message
                {
                    Id = Guid.NewGuid().ToString("N"),
                    User = "user #1",
                    Content = "hello",
                    Attachments =
                    {
                        new Attachment
                        {
                            Name = "Attachment #1"
                        }
                    }
                });
                Console.WriteLine("Message sent");
            }
        }
    }
}
