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
    public partial class Bai1_Server : Form
    {
        public Bai1_Server()
        {
            InitializeComponent();
        }

        //Create ServerThread
        private void serverThread()
        {
            UdpClient udpClient = new UdpClient(int.Parse(tb_PortListen.Text));
            while(true)
            {
                IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveByte = udpClient.Receive(ref remoteIpEndPoint);
                string returnDate = Encoding.UTF8.GetString(receiveByte);
                string msg = remoteIpEndPoint.Address.ToString() + " : " + returnDate.ToString();
                rtb_RMessage.AppendText(msg + '\n');
            }    
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            if(tb_PortListen == null)
            {
                MessageBox.Show("Connect Port Failed !");
            }
            else
            {
                CheckForIllegalCrossThreadCalls = false;
                Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
                thdUDPServer.Start();
            }
        }
    }
}
