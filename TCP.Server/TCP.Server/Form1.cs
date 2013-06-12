using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;


namespace TCP.Server
{
    public partial class Form1 : Form
    {
        public List<TcpClient> AllClients = new List<TcpClient>();
        public List<NetworkStream> AllStreams = new List<NetworkStream>();
        public Task<TcpClient> taskWaiting;
        private TcpListener server;
        public Form1()
        {
            InitializeComponent();
        }
        public void ServerStart()
        {
            try
            {
                server = new TcpListener(IPAddress.Parse("127.0.0.1"), 4242);
                server.Start();
                taskWaiting = server.AcceptTcpClientAsync();
                timer1.Start();
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void TurnOnButton_Click(object sender, EventArgs e)
        {
            ServerStart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            AllClients = AllClients.Except(AllClients.Where(z => z.Client.Available == 0)).ToList();
            NowConnectedLabel.Text = AllClients.Count.ToString();
            if (taskWaiting.IsCompleted)
            {
                AllClients.Add(taskWaiting.Result);
                NowConnectedLabel.Text = AllClients.Count.ToString();
                taskWaiting = server.AcceptTcpClientAsync();
            }
        }
    }
}

