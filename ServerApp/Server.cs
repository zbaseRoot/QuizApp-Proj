using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Network;

namespace ServerApp
{
    public class Server
    {
        private TcpListener _listener;
        private CancellationTokenSource _cts;

        public event Action<ConnectedPlayer> OnClientConnected;
        public event Action<ConnectedPlayer, string> OnMessageReceived;

        public List<ConnectedPlayer> Players { get; private set; } = new List<ConnectedPlayer>();
        public string IpAddress { get; set; } = "127.0.0.1";
        public int Port { get; set; } = 7895;

        public void Start()
        {
            _cts = new CancellationTokenSource();
            _listener = new TcpListener(IPAddress.Parse(IpAddress), Port);
            _listener.Start();
            _ = AcceptClientsAsync();
        }

        private async Task AcceptClientsAsync()
        {
            while (!_cts.Token.IsCancellationRequested)
            {
                try
                {
                    TcpClient client = await _listener.AcceptTcpClientAsync();
                    _ = HandleClientAsync(client);
                }
                catch { }
            }
        }

        private async Task HandleClientAsync(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            ConnectedPlayer player = new ConnectedPlayer { Client = client, Stream = stream };

            OnClientConnected?.Invoke(player);

            try
            {
                byte[] buffer = new byte[5000];
                while (!_cts.Token.IsCancellationRequested)
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, _cts.Token);
                    if (bytesRead == 0) break;

                    string msg = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    OnMessageReceived?.Invoke(player, msg);
                }
            }
            catch { }
            finally
            {
                Players.Remove(player);
                stream?.Close();
                client?.Close();
            }
        }

        public async Task BroadcastPacketAsync<T>(T packet) where T : class
        {
            foreach (var player in Players.ToArray())
            {
                await SendPacketAsync(packet, player);
            }
        }

        public async Task SendPacketAsync<T>(T packet, ConnectedPlayer player) where T : class
        {
            try
            {
                string innerJson = JsonSerializer.Serialize(packet);
                PacketWrapper wrapper = new PacketWrapper { PacketType = typeof(T).Name, JsonData = innerJson };
                string finalJson = JsonSerializer.Serialize(wrapper);
                byte[] buffer = Encoding.UTF8.GetBytes(finalJson + "\n");

                await player.Stream.WriteAsync(buffer, 0, buffer.Length);
            }
            catch { }
        }

        public void Stop()
        {
            _cts?.Cancel();
            _listener?.Stop();
            foreach (var p in Players)
            {
                p.Stream?.Close();
                p.Client?.Close();
            }
            Players.Clear();
        }
    }
}