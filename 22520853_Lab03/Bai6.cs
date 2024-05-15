using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab3
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread ServerThrd = new Thread(ServerThread);
            ServerThrd.Start();
            Thread isServerAli = new Thread(() => isServerAlive(ServerThrd));
            isServerAli.Start();
        }

        private void ServerThread()
        {
            Bai6_Server ChatServer = new Bai6_Server();
            ChatServer.ShowDialog();
        }

        private void isServerAlive(Thread ServerThread)
        {
            while (true)
            {
                if (ServerThread.IsAlive)
                {
                    btn_Server.Enabled = false;
                }
                else
                {
                    btn_Server.Enabled = true;
                    break;
                }
            }
        }

        private List<Bai6_Client> clientForms = new List<Bai6_Client>(); // Track client forms

        private void btn_Client_Click(object sender, EventArgs e)
        {
            Bai6_Client chatClientForm = new Bai6_Client();
            chatClientForm.Show();
            btn_Client.Enabled = true;
        }
        }
    }