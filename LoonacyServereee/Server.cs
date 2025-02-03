using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LoonacyServer
{
    public class Server
    {
        private TcpListener _server;
        private List<ClientHandler> _clients = new List<ClientHandler>();
        private GameLogic _gameLogic = new GameLogic();
        private const int MaxPlayers = 4;

        public async Task StartAsync(int port)
        {
            _server = new TcpListener(IPAddress.Any, port);
            _server.Start();
            Console.WriteLine("Server started.");

            while (true)
            {
                var acceptedClient = await _server.AcceptTcpClientAsync();
                var acceptedClientHandler = new ClientHandler(acceptedClient, this);
                _clients.Add(acceptedClientHandler);
                Console.WriteLine($"New client connected. Total clients: {_clients.Count}");

                _ = acceptedClientHandler.HandleClientAsync();

                
            }
        }

        public void BroadcastMessage(string message, ClientHandler sender)
        {
            foreach (var client in _clients)
            {
                if (client != sender)
                {
                    client.SendMessage(message);
                }
            }
        }

        public void BroadcastMessageToAll(string message)
        {
            foreach (var client in _clients)
            {
                client.SendMessage(message);
            }
        }

        public void RemoveClient(ClientHandler client)
        {
            _clients.Remove(client);
            Console.WriteLine($"Client disconnected. Total clients: {_clients.Count}");
            _gameLogic.ProcessMessage($"LEAVE|{client.Nickname}", client);

            if (_clients.Count == 0)
            {
                RestartServer();
            }
        }

        public void ProcessMessage(string message, ClientHandler sender)
        {
            _gameLogic.ProcessMessage(message, sender);
        }

        private async void RestartServer()
        {
            _gameLogic.Reset();
            BroadcastMessageToAll("RESET_GAME");
            Console.WriteLine("Игра была перезапущена.");
        }
    }
}