using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520853_Lab03
{
    public partial class Bai1_Client : Form
    {
        public Bai1_Client()
        {
            InitializeComponent();
        }

        private void tb_IP_Host_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            //Tạo kết nối UDP
            UdpClient udpClient = new UdpClient();
            string msg = rtb_Message.Text;
            //Chuyen message sang bytes
            if(msg == null)
            {
                MessageBox.Show("Null message !");
            }
            else
            {
                Byte[] bytes = Encoding.UTF8.GetBytes(msg);
                udpClient.Send(bytes, bytes.Length, tb_IP_Host.Text, Int32.Parse(tb_Port.Text));
            }
        }
    }
}
