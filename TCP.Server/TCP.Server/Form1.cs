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
        public bool turnOff = false;
        public int a = 0;
        public Form1()
        {
            InitializeComponent();
            this.Show();
            Thread ownThread = new Thread(new ThreadStart(thread1));
        }
        public void thread1()
        {
            try
            {
                TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 4242);
                server.Start();
                while (!turnOff)
                {
                    TcpClient client = server.AcceptTcpClient(); a++;
                    NetworkStream stream = client.GetStream();
                    MessageBox.Show(stream.ToString());
                }
                
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                //         MessageBox.Show("Сервер успешно запущен.");
            }          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turnOff = true;
            this.Close();
        }
    }
}
