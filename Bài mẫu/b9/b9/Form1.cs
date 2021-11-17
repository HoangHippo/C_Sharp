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
namespace b9
{
    public partial class Form1 : Form
    {
        string conn_str = "data source = LAPTOP-JSV9TQI0; initial catalog = b9 ; user id = sa; password = 123456";
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
                string sql = "delete lop where malop = @malop";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@malop", malop));
                int rs = (int)cmd.ExecuteNonQuery();
                if(rs == 1)
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("Ko ton tai");
                }
                conn.Close();

            }catch (Exception ex)
            {
                MessageBox.Show("KO Ton tai !");
            }
        }
    }
}
