using Homepage;
using Homepage.Context;
using Homepage.Models;
using Npgsql;

namespace Fitur_Profile_Account
{
    public partial class membership : Form
    {
        statusmembershipContext context;
        public membership()
        {
            InitializeComponent();
        }
        private void membership_Load(object sender, EventArgs e)
        {
            context = new statusmembershipContext();
            context.Read();

            foreach (statusmembership status in context.statuslist)
            {
                if (status.status == 1)
                {
                    label3.Text = "Aktif";
                }
                else
                {
                    label3.Text = "Tidak Aktif";
                }
            }
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Profil_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Homepage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 homepage = new Form1();
            homepage.Show();
        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            {
                context = new statusmembershipContext();
                context.Read();

                foreach (statusmembership status in context.statuslist)
                {
                    if (status.status == 1)
                    {
                        gradientPanel2.Visible = true;
                    }
                    else
                    {
                        gradientPanel2.Visible = false;
                    }
                }
            }

        }
        private void gradientPanel3_Paint(object sender, PaintEventArgs e)
        {
            {
                context = new statusmembershipContext();
                context.Read();

                foreach (statusmembership status in context.statuslist)
                {
                    if (status.status == 1)
                    {
                        gradientPanel3.Visible = true;
                    }
                    else
                    {
                        gradientPanel3.Visible = false;
                    }
                }
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}


