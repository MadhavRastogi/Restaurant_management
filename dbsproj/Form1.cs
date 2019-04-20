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

    public partial class Form1 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public static string nm = "", em = "", co = "", pp = "";

        public Form1()
        {
            InitializeComponent();
        }

        public void DB_Connect()
        {
            String oradb = "Data Source=LAPTOP-N2JK1JM6; User ID=system; Password = sys";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
            linkLabel3.Visible = true;
            label12.Visible = false;
            name.Text = "";
            email.Text = "";
            pwords.Text = "";
            pw.Text = "";
            contact.Text = "";
           

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DB_Connect();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            String con = contact.Text;
            if (con.Length != 10)
            { 
            label11.Text = "Invalid Contact Number";
                linkLabel3.Visible = false;
                label12.Visible = true;

             }

            else if (pwords.Text != pw.Text)
            {
                label11.Text = "Invalid Password";
                linkLabel3.Visible = false;
                label12.Visible = true;
            }

            else
            {
                cm.CommandText = "insert into customer values('" + name.Text + "','" + contact.Text + "','" + email.Text + "','" + pw.Text + "')";
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                MessageBox.Show("You Have Been Registered");
                conn.Close();
                name.Text = "";
                email.Text = "";
                pwords.Text = "";
                pw.Text = "";
                contact.Text = "";
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select * from customer";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_customer");
            dt = ds.Tables["Tbl_customer"];
            int t = dt.Rows.Count;
            while(true)
            {
                dr = dt.Rows[i];
                if (textBox1.Text == dr["email"].ToString() && textBox2.Text == dr["password"].ToString())
                {
                    em = textBox1.Text;
                    nm = dr["name"].ToString();
                    pp = textBox2.Text;
                    co = dr["contact"].ToString();
                    Main_Page mm = new Main_Page();
                    this.Hide();
                    mm.Show();
                    break;
                }
                i++;
                if (i >= dt.Rows.Count)
                {
                    MessageBox.Show("Invalid Details!!");
                    break;
                }
            }
            conn.Close();
        }

    }
}
