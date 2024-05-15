

using Lab3;

namespace _22520853_Lab03
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_VD_Click(object sender, EventArgs e)
        {
            vd_Server vd_Server = new vd_Server();
            if (Application.OpenForms.OfType<vd_Server>().Any())
            {
                MessageBox.Show("Already Opened.");
            }
            else
                vd_Server.Show();

            vd_Client vd_Client = new vd_Client();
            vd_Client.Show();
        }

        private void btn_Bai01_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void btn_Bai2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.Show();
        }

        private void btn_Bai3_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            bai3.Show();
        }

       
        private void btn_Bai6_Click(object sender, EventArgs e)
        {
            Bai6 bai6 = new Bai6();
            bai6.Show();
        }
    }
}
