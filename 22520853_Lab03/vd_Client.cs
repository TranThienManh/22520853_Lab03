using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520853_Lab03
{
    public partial class vd_Client : Form
    {
        public vd_Client()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            // initialize variable ip endpoint and Udpclient
            UdpClient udpClient = new UdpClient();
            IPAddress IpAdd = IPAddress.Parse(IP.Text);
            IPEndPoint EPHost = new IPEndPoint(IpAdd, 8080);

            //data
            Byte[] datasend = Encoding.ASCII.GetBytes("Hello world!");

            //send
            udpClient.Send(datasend, datasend.Length, EPHost);
        }
    }
}
