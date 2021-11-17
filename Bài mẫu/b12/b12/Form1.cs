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
namespace b12
{
    public partial class Form1 : Form
    {
        string conn_str = "data source = LAPTOP-JSV9TQI0; initial catalog = b12; user id = sa; password = 123456";
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
                string sql = "update bengoan set tenbe = @ten where mabn = @ma";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@ten", ten));
                cmd.Parameters.Add(new SqlParameter("@ma", ma));

                int rs = (int)cmd.ExecuteNonQuery();
                if(rs == 1)
                {
                    MessageBox.Show("Ok:");
                }
                else
                {
                    MessageBox.Show("ERR");
                }
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
