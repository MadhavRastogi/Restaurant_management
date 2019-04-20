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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
            label9.Text = Form1.co;
            label1.Text = Form1.nm;
            label10.Text = lunch.q;
            label11.Text = lunch.my;
            double k = 0.05 * int.Parse(lunch.my);
            label12.Text =k.ToString();
            label13.Text = (k + int.Parse(lunch.my)).ToString();
            label16.Text = DateTime.Now.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {
            thank tt = new thank();
            tt.Show();
            this.Hide();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
