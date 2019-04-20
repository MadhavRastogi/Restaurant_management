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
    public partial class paymentb : Form
    {
        public paymentb()
        {
            InitializeComponent();
            label8.Text = Form1.co;
            label2.Text = Form1.nm;
            label9.Text = breakfast.q;
            label10.Text = breakfast.my;
            double k = 0.05 * int.Parse(breakfast.my);
            label11.Text = k.ToString();
            label12.Text = (k + int.Parse(breakfast.my)).ToString();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {
            thank tt = new thank();
            tt.Show();
            this.Hide();
        }
    }
}
