using System;
using System.Threading.Tasks;

namespace LoonacyServer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Server server = new Server();
            await server.StartAsync(5000);
        }
    }
}