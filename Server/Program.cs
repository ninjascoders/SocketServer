using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {

        static void Main(string[] args)
        {
            Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket connection;

            IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6400);
        }
    }
}
