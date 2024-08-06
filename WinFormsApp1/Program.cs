using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }

        public static string SendMessage(string message)
        {
            const int bytesize = 1024 * 1024;
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            byte[] responseBytes = new byte[bytesize];

            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 1234); // Create a new connection  
                NetworkStream stream = client.GetStream();

                stream.Write(messageBytes, 0, messageBytes.Length); // Write the bytes  
                Console.WriteLine("================================");
                Console.WriteLine("=   Connected to the server    =");
                Console.WriteLine("================================");
                Console.WriteLine("Waiting for response...");

                // Receive the stream of bytes  
                int bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
                string responseMessage = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

                // Clean up  
                stream.Dispose();
                client.Close();

                return responseMessage.TrimEnd('\0'); // Return response
            }
            catch (Exception e) // error excpetion catching
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
