
using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
public class Server  {

    public static void Main()
    {
        Console.WriteLine("Starting echo server...");

        int port = 1700;
        TcpListener listener = new TcpListener(IPAddress.Any, port);
        listener.Start();

        TcpClient client = listener.AcceptTcpClient();
        NetworkStream stream = client.GetStream();
        StreamWriter writer = new StreamWriter(stream, Encoding.ASCII) { AutoFlush = true };
        StreamReader reader = new StreamReader(stream, Encoding.ASCII);

        while (true)
        {
            string inputLine = "";
            while (inputLine != null)
            {
                inputLine = reader.ReadLine();
                writer.WriteLine("Echoing string: " + inputLine);
                Console.WriteLine("Echoing string: " + inputLine);
            }
            Console.WriteLine("Server saw disconnect from client.");
        }
    }
}
