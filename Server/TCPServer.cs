using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace TcpClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Loopback, 1234);
            TcpListener listener = new TcpListener(ep);
            listener.Start();

            Console.WriteLine(@"  
            ===================================================  
                   Started listening requests at: {0}:{1}  
            ===================================================",
            ep.Address, ep.Port);

            // Run the loop continuously; this is the server.  
            while (true)
            {
                const int bytesize = 1024 * 1024;

                byte[] buffer = new byte[bytesize];

                var sender = listener.AcceptTcpClient();
                var networkStream = sender.GetStream();
                int bytesRead = networkStream.Read(buffer, 0, bytesize);

                // Read the message and perform different actions  
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                // Call the HandleMessage method to display the message
                HandleMessage(message);

                // Respond back to the client
                string responseMessage = "Message received!";
                byte[] responseBytes = Encoding.UTF8.GetBytes(responseMessage); //encoding.utf8 same as program.cs
                networkStream.Write(responseBytes, 0, responseBytes.Length);
            }
        }

        // method taht handle displaying the message
        private static void HandleMessage(string message)
        {
            Console.WriteLine("Your message is: {0}", message);
        }
    }
}
