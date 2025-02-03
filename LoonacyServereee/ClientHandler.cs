using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LoonacyServer
{
    public class ClientHandler
    {
        private TcpClient _client;
        private Server _server;
        private StreamReader _reader;
        private StreamWriter _writer;
        public string Nickname { get; private set; }

        public ClientHandler(TcpClient client, Server server)
        {
            _client = client;
            _server = server;
            _reader = new StreamReader(_client.GetStream(), Encoding.UTF8);
            _writer = new StreamWriter(_client.GetStream(), Encoding.UTF8) { AutoFlush = true };
        }

        public async Task HandleClientAsync()
        {
            try
            {
                while (true)
                {
                    string message = await _reader.ReadLineAsync();
                    if (string.IsNullOrEmpty(message)) break;

                    Console.WriteLine($"Received: {message}");
                    _server.ProcessMessage(message, this);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                _server.RemoveClient(this);
                _client.Close();
            }
        }

        public void SendMessage(string message)
        {
            _writer.WriteLine(message);
        }

        public void SetNickname(string nickname)
        {
            Nickname = nickname;
        }
    }
}