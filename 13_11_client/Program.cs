using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _13_11_client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(
                AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp
                );
            socket.Connect(new IPEndPoint(IPAddress.Loopback, 8080));
            Console.WriteLine(SocketMessageHelper.ReceiveMessage(socket));
            SocketMessageHelper.SendMessage(socket, "Hi, server!");
            socket.Close();
        }
    }
}
