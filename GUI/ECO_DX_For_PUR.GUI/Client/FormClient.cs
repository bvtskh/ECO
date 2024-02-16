using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ReceivedTextFiles = new Queue<byte[]>();
        }
        public int SenderPort { get; set; }
        public byte[] Buffer { get; set; }
        public string SenderHost { get; set; }
        public TcpClient SenderConnection;
        public Queue<byte[]> ReceivedTextFiles;

        public Task Connect()
        {
            return Task.Factory.StartNew(() =>
            {
                SenderConnection = new TcpClient();
                SenderConnection.Connect("172.28.10.28", 5000);
                Thread t = new Thread(Recieve);
                Thread t2 = new Thread(ProcessTextFiles);
                t.Start();
                t2.Start();
            });
        }
        public void Recieve()
        {
            while (true)
            {
                Thread.Sleep(500);
                if (SenderConnection.Available > 0)
                {
                    lock (Buffer)
                    {
                        Buffer = new byte[SenderConnection.Available];
                        int receivedBytes = SenderConnection.Client.Receive(Buffer);
                        if (receivedBytes > 0)
                        {
                            lock (ReceivedTextFiles)
                            {
                                ReceivedTextFiles.Enqueue(Buffer);
                                Buffer = null;
                            }
                        }
                    }
                }
            }
        }
        public void ProcessTextFiles()
        {
            while (true)
            {
                byte[] textFile = null;
                lock (ReceivedTextFiles)
                {
                    //We have buffers to process, get one, and remove it from the queue
                    if (ReceivedTextFiles.Count > 0)
                    {
                        textFile = ReceivedTextFiles.Dequeue();
                    }
                }
                //Process the buffer
                var textFileContent = System.Text.Encoding.Default.GetString(textFile);
                //Do whatever you want
                Thread.Sleep(1500);
            }
        }
        private void btncon_Click(object sender, EventArgs e)
        {
            Connect();
        }
    }
}
