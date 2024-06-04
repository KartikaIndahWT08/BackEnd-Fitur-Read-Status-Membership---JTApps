using Fitur_Profile_Account;
using Homepage;

namespace Homepage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Focus();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "Mau kemana hari ini?";
            }
            else
            {
                label1.Text = "";
            }
            textBox1.AutoSize = false;
            textBox1.Height = 20;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox1.Focus();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            membership Membership = new membership();

            Membership.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}