using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace TestClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HubConnection hubcon = new HubConnectionBuilder()
                .WithUrl("https://localhost:5101/hub/empty")
                .Build();

            await hubcon.StartAsync();
            Console.WriteLine("Connected");

            Console.Read();
        }
    }
}
