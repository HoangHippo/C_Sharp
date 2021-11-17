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
namespace b10
{
    public partial class Form1 : Form
    {
        string conn_str = "data source = LAPTOP-JSV9TQI0; initial catalog = b10 ; user id = sa; password = 123456";
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
                string ma = txtma.Text;
                string ten = txtten.Text;
                string ngaysinh =dtngaysinh.Value.ToString("dd/MM/yyyy") ;
                string gt = rdnam.Checked ? "nam" : "nu";
                string tenbo = txtbo.Text;
                string tenme = txtme.Text;
                string sql = "insert into bengoan values (@ma, @ten, @ngaysinh, @gt, @tenbo, @tenme)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", ma));
                cmd.Parameters.Add(new SqlParameter("@ten", ten));
                cmd.Parameters.Add(new SqlParameter("@ngaysinh", ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@gt", gt));
                cmd.Parameters.Add(new SqlParameter("@tenbo", tenbo));
                cmd.Parameters.Add(new SqlParameter("@tenme", tenme));

                int rs = (int)cmd.ExecuteNonQuery();
                if(rs == 1)
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("KO OK");
                }
                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
