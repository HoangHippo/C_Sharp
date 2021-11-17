using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String con_str = "Data source = LAPTOP-JSV9TQI0; Initial catalog = DieuTraDS; User id = sa; password = 123456";
                SqlConnection conn = new SqlConnection(con_str);

                String MaCD = txtMa.Text;
                String sql = "delete Congdan where macd = @MaCD ";

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@MaCD", MaCD));
                int n = cmd.ExecuteNonQuery();
                if(n == 0)
                {
                    MessageBox.Show("Không Tồn Tại MaCD");
                }
                else
                {
                    MessageBox.Show("Xóa Thành Công");
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("err : " + ex.Message);
            }


        }
    }
}
