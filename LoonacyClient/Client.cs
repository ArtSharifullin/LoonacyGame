using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace LoonacyClient
{
    public class Client
    {
        private TcpClient _client;
        private StreamReader _reader;
        private StreamWriter _writer;

        public event EventHandler<string> OnMessageReceived;

        public Client(string ipAddress, int port)
        {
            try
            {
                _client = new TcpClient(ipAddress, port);
                _reader = new StreamReader(_client.GetStream(), Encoding.UTF8);
                _writer = new StreamWriter(_client.GetStream(), Encoding.UTF8) { AutoFlush = true };

                _ = ReceiveMessagesAsync();
            }
            catch (SocketException ex)
            {
                Console.WriteLine($"Connection failed: {ex.Message}");
                OnMessageReceived?.Invoke(this, "JOIN|ERROR|Connection failed.");
            }
        }

        
        

        public void SendMessage(string message)
        {
            if (_client.Connected)
            {
                _writer.WriteLine(message);
            }
        }

        private async Task ReceiveMessagesAsync()
        {
            try
            {
                while (true)
                {
                    string message = await _reader.ReadLineAsync();
                    if (string.IsNullOrEmpty(message)) break;

                    OnMessageReceived?.Invoke(this, message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                _client.Close();
            }
        }
    }
}