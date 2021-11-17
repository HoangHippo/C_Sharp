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

namespace b14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String con_str = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=14;User ID=sa;Password=123456";
            String sql = "select * from SanPham where SoLuongTon = 0 OR DAY(GETDATE()) < DAY(NgayHetHan)";
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "SanPham");
                dgv.DataSource = ds.Tables["SanPham"];
            }
            catch(Exception ex)
            {
                MessageBox.Show("err :" + ex.Message);
            }
        }
    }
}
