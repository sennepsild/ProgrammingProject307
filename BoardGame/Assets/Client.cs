using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

public class Client  {

    static void Main()
    {
        Console.WriteLine("Starting echo client...");

        int port = 1700;
        TcpClient client = new TcpClient("172.20.10.5", port);
        NetworkStream stream = client.GetStream();
        StreamReader reader = new StreamReader(stream);
        StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

        while (true)
        {
            Console.Write("Enter to send: ");
            string lineToSend = Console.ReadLine();
            Console.WriteLine("Sending to server: " + lineToSend);
            writer.WriteLine(lineToSend);
            string lineReceived = reader.ReadLine();
            Console.WriteLine("Received from server: " + lineReceived);
        }
    }
}
