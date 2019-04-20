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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
           admin_login d1 = new admin_login();
            this.Hide();
            d1.Show();


        }
    }
}
