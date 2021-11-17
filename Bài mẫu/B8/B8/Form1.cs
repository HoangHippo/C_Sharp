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
namespace B8
{
    public partial class Form1 : Form
    {
        String conn_str = "data source = LAPTOP-JSV9TQI0; initial catalog = b8 ; user id = sa; password = 123456";
        SqlConnection conn = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conn_str);
                string malop = txtMaLop.Text;
                string sql = "select * from lop, bengoan where lop.malop = bengoan.malop and bengoan.malop = @malop";
                DataSet rs = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add(new SqlParameter("@malop", malop));
                da.Fill(rs, "data");
                dgv.DataSource = rs.Tables["data"];
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
