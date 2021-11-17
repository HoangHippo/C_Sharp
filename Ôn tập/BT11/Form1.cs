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

namespace BT11
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
                String con_str = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=HoaHong;Persist Security Info=True;User ID=sa;Password=123456";
                String mabn = txtMaBN.Text;
                String lop = Convert.ToString(cbLop.SelectedItem);
                SqlConnection conn = new SqlConnection(con_str);
                String sql = "update LopHoc set MaLop = @lop and BeNgoan set MaLop = @lop where MaBN = @mabn";

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@mabn", mabn));
                cmd.Parameters.Add(new SqlParameter("@lop", lop));
                int n = cmd.ExecuteNonQuery();
                if (n == 0)
                {
                    MessageBox.Show("Không tồn tại Mã Bé Ngoan!");
                }
                else
                {
                    MessageBox.Show("Sửa thành công!");
                }

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("err: +" + ex.Message);
            }
        }
    }
}
