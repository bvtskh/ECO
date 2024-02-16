using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;

namespace Server
{
    public partial class FormServer : Form
    {
        private TcpListener tcpListener;
        private Thread listenThread;

        public FormServer()
        {
            InitializeComponent();
            StartServer();
        }

        private void StartServer()
        {
            tcpListener = new TcpListener(IPAddress.Any, 8080);
            listenThread = new Thread(new ThreadStart(ListenForClients));
            listenThread.Start();
        }

        private void ListenForClients()
        {
            tcpListener.Start();
            while (true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    break;
                }

                if (bytesRead == 0)
                {
                    break;
                }

                string data = Encoding.ASCII.GetString(message, 0, bytesRead);
                Console.WriteLine("Received: " + data);

                // You can process received data here.

                // Example: Echoing back to client
                byte[] responseData = Encoding.ASCII.GetBytes(data);
                clientStream.Write(responseData, 0, responseData.Length);
                clientStream.Flush();
            }

            tcpClient.Close();
        }
    }
}
