using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace dbsproj
{
    public partial class Profile : Form
    {
        
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Profile()
        {
            InitializeComponent();
            label2.Text = Form1.nm;
            label7.Text = Form1.nm;
            label8.Text = Form1.co;
            label9.Text = Form1.em;
            label10.Text = Form1.pp;

        }
        public void DB_Connect()
        {
            String oradb = "Data Source=LAPTOP-N2JK1JM6; User ID=system; Password = sys";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label10.Text = textBox2.Text;
            DB_Connect();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "update customer set password=:pb where email=:pdn";
            cm.CommandType = CommandType.Text;
            //Uses OracleParameter to read the parameter from the GUI
            OracleParameter pa1 = new OracleParameter();
            pa1.ParameterName = "pb";
            pa1.DbType = DbType.String;
            pa1.Value = label10.Text;
            OracleParameter pa2 = new OracleParameter();
            pa2.ParameterName = "pdn";
            pa2.DbType = DbType.String;
            pa2.Value = label9.Text;
            cm.Parameters.Add(pa1);
            cm.Parameters.Add(pa2);
            cm.ExecuteNonQuery();
            MessageBox.Show("updated");
            conn.Close();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Main_Page mm = new Main_Page();
            mm.Show();

            


        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
    }
}
