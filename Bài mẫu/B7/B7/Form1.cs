using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace B7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showdata();
        }
        private void showdata()
        {
            String conn_str = "Data source = LAPTOP-JSV9TQI0; Initial catalog = DieuTraDS; User id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);

            String CMND = txt.Text;
            String sql = "select * from congdan";
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "CD");

            dgv.DataSource = ds.Tables["CD"];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String conn_str = "Data source = LAPTOP-JSV9TQI0; Initial catalog = DieuTraDS; User id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);

            String CMND = txt.Text;
            String sql = "select * from congdan where CMND like '%' + @CMND + '%'";
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.Add(new SqlParameter("@CMND", CMND));
            da.Fill(ds, "CD");

            dgv.DataSource = ds.Tables["CD"];
        }
    }
}
