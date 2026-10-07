using System.Net.Sockets;

namespace ServerApp
{
    public class ConnectedPlayer
    {
        public TcpClient Client { get; set; }
        public NetworkStream Stream { get; set; }
        public string Name { get; set; }
        public int TotalScore { get; set; }
        public string LastAnswer { get; set; }
    }
}