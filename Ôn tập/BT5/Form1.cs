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

namespace BT5
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
                String con_str = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=DieuTraDS;Persist Security Info=True;User ID=sa;Password=123456";
                String cmnd = txtCMND.Text;
                String macd = txtMaCD.Text;
                String sql = "update CongDan set CMND = @cmnd where MaCD = @macd";

                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@macd", macd));
                cmd.Parameters.Add(new SqlParameter("@cmnd", cmnd));

                int n = cmd.ExecuteNonQuery();
                if (n == 0)
                {
                    MessageBox.Show("Không tồn tại mã công dân");
                }
                else
                {
                    MessageBox.Show("Sửa thành công");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("err :"+ex.Message);
            }
        }
    }
}
