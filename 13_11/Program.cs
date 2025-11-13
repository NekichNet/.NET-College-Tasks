using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _13_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(
                AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp
                );
            socket.Bind(new IPEndPoint(IPAddress.Loopback, 8080));
            socket.Listen(2);
            socket.Accept();
            SocketMessageHelper.SendMessage(socket, "Hi, client!");
            Console.WriteLine(SocketMessageHelper.ReceiveMessage(socket));
            socket.Close();
        }
    }
}
