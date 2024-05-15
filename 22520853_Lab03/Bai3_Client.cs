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
    public partial class Bai3_Client : Form
    {
        public Bai3_Client()
        {
            InitializeComponent();
        }

        ConnectServer client;


        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new ConnectServer();
                client.Connect();
                btn_Send.Enabled = true;
                btn_Connect.Enabled = false;
                btn_DisConnect.Enabled = true;
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Cann't connect server !");
            }
        }


        private void btn_Send_Click(object sender, EventArgs e)
        {
            string msg = rtb_Message.Text;
            client.Send(msg);
            rtb_Message.Text = "";
        }

        private void btn_DisConnect_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            btn_Send.Enabled = false;
            btn_Connect.Enabled = true;
            btn_DisConnect.Enabled = false;
        }

        class ConnectServer
        {
            int serverPort = 8080;
            IPAddress serverAddr = IPAddress.Parse("192.168.56.1");
            TcpClient client = new TcpClient();

            public void Connect()
            {
                client.Connect(serverAddr, serverPort);
            }
            public void Send(string message)
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);           // Sau đó gửi dữ liệu
            }

            public void Disconnect()
            {
                client.Close();
            }
        }
    }
}
