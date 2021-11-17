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

namespace BT9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                String con_str = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=HoaHong;User ID=sa;Password=123456";
                String malop = txtMaLop.Text;
                String sql = "Delete LopHoc where MaLop = @malop";
                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@malop", malop);
                int n = cmd.ExecuteNonQuery();
                if (n == 0)
                {
                    MessageBox.Show("Mã lớp không tồn tại!");
                }
                else
                {
                    MessageBox.Show("Xóa thành công!");
                }

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("err : " + ex.Message);
            }
        }

    }
}
