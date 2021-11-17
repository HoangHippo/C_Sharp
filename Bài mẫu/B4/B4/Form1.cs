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

namespace B4
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
                String con_str = " Data Source = LAPTOP-JSV9TQI0; Initial catalog = DieuTraDS; User id = sa; Password = 123456";
                SqlConnection conn = new SqlConnection(con_str);

                String MaCD = txtMa.Text;
                String TenCD = txtTen.Text;

                String sql = "Update CongDan set TenCD = @TenCD where MaCD = @MaCD";

                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@MaCD", MaCD));
                cmd.Parameters.Add(new SqlParameter("@TenCD", TenCD));

                int n = cmd.ExecuteNonQuery();
                if(n == 0)
                {
                    MessageBox.Show("Không tồn tại MaCD");
                }
                else
                {
                    MessageBox.Show("Thành Công");
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("err :" + ex.Message);
            }

        }
    }
}
