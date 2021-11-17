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

namespace BT07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showdata();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                String con_str = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=DieuTraDS;Persist Security Info=True;User ID=sa;Password=123456";
                String cmnd = txtCMND.Text;
                String sql = "select * from CongDan where CMND like '%' + @cmnd + '%'";
                SqlConnection conn = new SqlConnection(con_str);
                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add(new SqlParameter("@cmnd", cmnd));
                da.Fill(ds, "CD");

                dgv.DataSource = ds.Tables["CD"];
            }
            catch(Exception ex)
            {
                MessageBox.Show("err : " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void showdata()
        {
            try
            {
                String con_str = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=DieuTraDS;Persist Security Info=True;User ID=sa;Password=123456";
                String cmnd = txtCMND.Text;
                String sql = "select * from CongDan";
                SqlConnection conn = new SqlConnection(con_str);
                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "CD");

                dgv.DataSource = ds.Tables["CD"];
            }
            catch(Exception ex)
            {
                MessageBox.Show("err : " + ex.Message);
            }
        }
    }
}
