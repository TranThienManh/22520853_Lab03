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
    public partial class vd_Server : Form
    {
        public vd_Server()
        {
            InitializeComponent();
        }

        void serverThread()
        {
            UdpClient udpClient = new UdpClient();

            // endpoint receive
            IPEndPoint RemoteIPEP = new IPEndPoint(IPAddress.Any, 8080);
            udpClient.Client.Bind(RemoteIPEP);

            while (true)
            {
                // IPEndPoint RemoteIPEP = new IPEndPoint(IPAddress.Any, 0);
                Byte[] bytesend = udpClient.Receive(ref RemoteIPEP);

                //byte to string
                string returndata = Encoding.ASCII.GetString(bytesend);
                string mess = RemoteIPEP.Address.ToString() + ": " + returndata.ToString();
                lst_Mess.Items.Add(mess);
            }

        }

        private void vd_Server_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread threadUDPServer = new Thread(new ThreadStart(serverThread));
            threadUDPServer.IsBackground = true;
            threadUDPServer.Start();
        }
    }
}
