using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbsproj
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Shreya" && textBox2.Text == "adm")
            {
                Admin a1 = new Admin();
                this.Hide();
                a1.Show();
            }
            else
            {
                label4.Visible = false;
                label5.Visible = true;
                textBox2.Text = "";
                textBox1.Text = "";
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Start t = new Start();
            t.Show();
            this.Hide();
        }
    }
}
