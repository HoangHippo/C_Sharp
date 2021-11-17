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

namespace BT02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String con_str = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=DieuTraDS;User ID=sa;Password=123456";
            String sql = "select * from CongDan order by TenCD";
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                DataSet rs = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "CongDan");
                dgv.DataSource = rs.Tables["CongDan"];
            }
            catch(Exception ex)
            {
                MessageBox.Show("err :" + ex.Message);
            }
        }
    }
}
