using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {

        static void Main(string[] args)
        {
            Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket connection;

            IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6400);

            listen.Bind(connect);
            // llamamos al metodo listenes y recibe un metodo entero, se pone el número maximo de conexiones
            listen.Listen(10);

            connection = listen.Accept();
            Console.WriteLine("Conexion aceptada");

            byte[] recibir_info = new byte[100];
            string data = " ";
            int array_size = 0;


            // Aca recibe la informacion en byte
            array_size = connection.Receive(recibir_info, 0, recibir_info.Length, 0);
            Array.Resize(ref recibir_info, array_size);

            // Convertimos los byte en una cadena de caracteres
            data = Encoding.Default.GetString(recibir_info);

            Console.WriteLine("La info recibida es: {0}", data);
            Console.ReadKey();

        }
    }
}
