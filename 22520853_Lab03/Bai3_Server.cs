using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520853_Lab03
{
    public partial class Bai3_Server : Form
    {
        public Bai3_Server()
        {
            InitializeComponent();
        }

        TcpListener server;
        IPEndPoint ep;
        private void btn_Listen_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(8080);
            ep = new IPEndPoint(IPAddress.Any, port);
            server = new TcpListener(ep);
            Thread lis = new Thread(() => Listen(server));
            rtb_ShowMessage.Text += "Server starts\r\n"
                          + "Waiting for connection...\r\n";
            lis.Start();
        }

        void Listen(TcpListener listener)
        {
            listener.Start();
            CheckForIllegalCrossThreadCalls = false;
            btn_Listen.Enabled = false;
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                rtb_ShowMessage.Text += "Connected from " + client.Client.RemoteEndPoint + "\r\n";
                Receive(client);
                rtb_ShowMessage.Text += "Disconnected from " + client.Client.RemoteEndPoint + "\r\n";
            }
        }

        void Receive(TcpClient client)
        {
            byte[] Data = new byte[256];
            String Mes = null;
            NetworkStream stream = client.GetStream();
            int i;
            while ((i = stream.Read(Data, 0, Data.Length)) != 0)
            {
                Mes = System.Text.Encoding.UTF8.GetString(Data, 0, i);
                rtb_ShowMessage.Text += "Client: " + Mes + "\r\n";
            }
        }
    }
}