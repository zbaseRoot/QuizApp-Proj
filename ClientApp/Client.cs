using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Network;

namespace ClientApp
{
    public class Client
    {
        private TcpClient _client;
        private NetworkStream _stream;
        private CancellationTokenSource _cts;
        public event EventHandler<EventArgs> ClientConnected;
        public event EventHandler<MessageReceivedEventArgs> MessageReceive;
        public string IpAddress { get; set; } = "127.0.0.1";
        public int Port { get; set; } = 7895;
        public Client() 
        {
            _cts = new CancellationTokenSource();
            _client = new TcpClient();
        }

        public async Task ConnectAsync()
        {
            await _client.ConnectAsync(IpAddress, Port, _cts.Token);
            _stream = _client.GetStream();
        }

        private async Task SendMessage(string m)
        {
            byte[] sendBuffer = Encoding.UTF8.GetBytes(m);
            if (_stream == null)
                return;

            await _stream.WriteAsync(sendBuffer, 0, sendBuffer.Length);
        }



        public async Task ReceiveMessagesAsync()
        {
            byte[] buffer = new byte[5000];

            while (!_cts.Token.IsCancellationRequested)
            {
                int bytesRead = await _stream.ReadAsync(buffer.AsMemory(), _cts.Token);
                if (bytesRead == 0)
                    break;
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                MessageReceive?.Invoke(this, new MessageReceivedEventArgs { Message = response });
            }
        }


        public async Task SendPacketAsync<T>(T packet) where T : class
        {
            if (_stream == null || !_client.Connected)
                return;
            string innerJson = JsonSerializer.Serialize(packet);
            var wrapper = new PacketWrapper
            {
                PacketType = typeof(T).Name,
                JsonData = innerJson
            };
            string finalJson = JsonSerializer.Serialize(wrapper);
            await SendMessage(finalJson + "\n");
        }


        public void CloseConnection()
        {
            _cts.Cancel(); 
            _stream?.Close();
            _client?.Close();
        } 

    }
}
