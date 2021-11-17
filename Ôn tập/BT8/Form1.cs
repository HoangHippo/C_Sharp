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

namespace BT8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String con_str = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=HoaHong;User ID=sa;Password=123456";
                String malop = txtMaLop.Text;
                String sql = "select * from LopHoc where MaLop like '%' + @malop + '%'";
                SqlConnection conn = new SqlConnection(con_str);
                DataSet bn = new DataSet();
                SqlDataAdapter ba = new SqlDataAdapter(sql, conn);
                ba.SelectCommand.Parameters.Add(new SqlParameter("@malop", malop));
                ba.Fill(bn, "BN");

                dgv.DataSource = bn.Tables["BN"];
            }
            catch(Exception ex)
            {
                MessageBox.Show("err :" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void showdata()
        {
            try
            {
                String con_str = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=HoaHong;User ID=sa;Password=123456";
                String malop = txtMaLop.Text;
                String sql = "select * from LopHoc";
                SqlConnection conn = new SqlConnection(con_str);
                DataSet bn = new DataSet();
                SqlDataAdapter ba = new SqlDataAdapter(sql, conn);
                ba.Fill(bn, "BN");

                dgv.DataSource = bn.Tables["BN"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err :" + ex.Message);
            }
        }
    }
}
