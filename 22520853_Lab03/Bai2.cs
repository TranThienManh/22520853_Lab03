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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            btn_Listen.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
            Thread severThread = new Thread(new ThreadStart(UnsafeThread));
            severThread.Start();
        }

        //Create UnsafeThread
        private void UnsafeThread()
        {
            //Tạo kết nối đầu cuối
            IPEndPoint IPEP = new IPEndPoint(IPAddress.Parse("192.168.56.1"), 8080);
            //Tạo lắng nghe TCP
            TcpListener tcpListener = new TcpListener(IPEP);

            

            //Tạo socket
            Socket ClientSocket;
            Socket ListenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // Gán socket lắng nghe tới địa chỉ IP của máy và port 8080
            ListenerSocket.Bind(IPEP);
            // bắt đầu lắng nghe. Socket.Listen(int backlog)
            // với backlog: là độ dài tối đa của hàng đợi các kết nối đang chờ xử lý
            ListenerSocket.Listen(-1);
            //Đồng ý kết nối
            ClientSocket = ListenerSocket.Accept();

            byte[] receive = new byte[1];

            while (ClientSocket.Connected)
            {
                string text = "";
                ClientSocket.Receive(receive);
                text += Encoding.ASCII.GetString(receive);
                rtb_ShowMessage.AppendText(text);
            }
            ListenerSocket.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
