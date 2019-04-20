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
    public partial class breakfast : Form
    {
        public static string my = "", q = "";
        public static int sum = 0, b = 0;
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public breakfast()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select * from breakf";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "Tbl_breakf");
            dt = ds.Tables["Tbl_breakf"];
            int t = dt.Rows.Count;
            int j, n, r = 0;
            String h = textBox1.Text;
            int k, l, m = 0, w;
            String v;
            h = h + " ";
            l = h.Length;
            label4.Text = l.ToString();
            int[] a = new int[20];
            for (j = 0; j < 20; j++)
            {
                a[j] = 0;
            }

            for (j = 0; j < l; j++)
            {

                if (r >= l)
                    break;
                else if (h[j] == ' ')
                {
                    v = h.Substring(r, 2);
                    v.Trim();
                    k = int.Parse(v);
                    a[m] = k;
                    m++;
                    r = j + 1;
                    v = "";
                }
            }

            for (n = 0; n < m; n++)
            {
                for (i = 0; i < 9; i++)
                {
                    dr = dt.Rows[i];
                    String x = dr["ID"].ToString();
                    int p = int.Parse(x);
                    if (a[n] == p)
                    {
                        b++;
                        w = int.Parse(dr["price"].ToString());
                        sum = sum + w;
                    }
                }
            }

            my = sum.ToString();
            label6.Text = my;
            q = b.ToString();
            label4.Text = q;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            paymentb ppp = new paymentb();
            ppp.Show();
            this.Hide();
        }

        public void DB_Connect()
        {
            String oradb = "Data Source=LAPTOP-N2JK1JM6; User ID=system; Password = sys";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void Breakfast_Load(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select * from breakf";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "breakf");
            dt = ds.Tables["breakf"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "breakf";
            conn.Close();
        }
    }
}
