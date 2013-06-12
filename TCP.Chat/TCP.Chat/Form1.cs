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

namespace TCP.Chat
{
    public partial class Form1 : Form
    {
        string ip;
        int port;
        public TcpClient client;
        public Form1()
        {
            ip = "127.0.0.1";
            port = 4242;
            InitializeComponent();    
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ConnectToServer(ip, port);
        }

        private void ConnectToServer(string ip, int port)
        {
            try
            {
                if (client != null)
                {
                    client.Client.Shutdown(SocketShutdown.Both);
                    client.Close();
                }
                client = new TcpClient();
                client.Connect(ip, port);                
            }
            catch (SocketException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
