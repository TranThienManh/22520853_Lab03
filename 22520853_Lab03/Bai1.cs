﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520853_Lab03
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {
            Bai1_Server server = new Bai1_Server();
            server.Show();
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            Bai1_Client client = new Bai1_Client();
            client.Show();
        }
    }
}
