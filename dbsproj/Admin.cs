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
    public partial class Admin : Form
    {
        public static string my = "", q = "";
        public static int sum = 0, b = 0;
        OracleConnection conn,conn1,conn2,conn3;
        OracleCommand comm,comm1,comm2,comm3;
        OracleDataAdapter da,da1,da2,da3;
        DataSet ds,ds1,ds2,ds3;
        DataTable dt,dt1,dt2,dt3;
        DataRow dr,dr1,dr2,dr3;
        int i = 0,i1=0,i2=0,i3=0;

        private void Admin_Load(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select * from customer";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "customer");
            dt = ds.Tables["customer"];
            int t = dt.Rows.Count;
            
            dr = dt.Rows[i];
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "customer";
            conn.Close();

          
            

        }

        public Admin()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Start t = new Start();
            t.Show();
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void DB_Connect()
        {
            String oradb = "Data Source=LAPTOP-N2JK1JM6; User ID=system; Password = sys";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
    }
}
