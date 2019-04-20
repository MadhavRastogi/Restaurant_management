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
    public partial class paymentd : Form
    {
        public paymentd()
        {
            InitializeComponent();
            label8.Text = Form1.co;
            label2.Text = Form1.nm;
            label9.Text = dinner.q;
            label10.Text = dinner.my;
            double k = 0.05 * int.Parse(dinner.my);
            label11.Text = k.ToString();
            label12.Text = (k + int.Parse(dinner.my)).ToString();
            label15.Text=DateTime.Now.ToString();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Paymentd_Load(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {
            thank tt = new thank();
            tt.Show();
            this.Hide();
        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }
    }
}
