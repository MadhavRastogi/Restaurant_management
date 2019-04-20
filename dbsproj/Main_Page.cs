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
    public partial class Main_Page : Form
    {
        static int flag = 0;
        static char b;

        public Main_Page()
        {
            InitializeComponent();
            String k;
            int s;
            label2.Text = Form1.nm;
            linkLabel1.Text = Form1.nm;
            k = DateTime.Now.ToLongTimeString();
            s = int.Parse(k.Substring(0, 2));
            if (s > 9&& s < 13)
            {
                label3.Text = "Serving Breakfast";
                b = 'B';
            }
            else if (s >=13 && s <17)
            {
                label3.Text = "Serving Lunch";
                b = 'L';
            }
            else if (s >19 && s < 24)
            {
                label3.Text = "Serving Dinner";
                b = 'D';
            }
            else
            {
                label3.Text = "SORRY, We are closed right now";
                label5.Visible = false;
                label4.Visible = false;
                linkLabel2.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;

            }

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profile p = new Profile();
            this.Hide();
            p.Show();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (checkBox2.Checked == false && checkBox1.Checked == false)
            {
                MessageBox.Show("Please Select an option");
            }
            else
            {
               
                if (checkBox1.Checked == true)
                {
                    flag = 1;
                }
                else if (checkBox2.Checked == true)
                {
                    flag = 2;
                }

                switch(b)
                {
                    case 'B':
                        breakfast bb = new breakfast();
                        bb.Show();
                        break;
                    case 'L':
                        lunch ll = new lunch();
                        ll.Show();
                        break;
                    case 'D':
                        dinner dd = new dinner();
                        dd.Show();
                        break;
                    default: break;
                }

                this.Hide();
            }
        



        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Start t = new Start();
            t.Show();
            this.Hide();
        }
    }
}