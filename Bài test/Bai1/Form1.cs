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

namespace Bai1
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
                String con_str = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=b1;User ID=sa;Password=123456";
                SqlConnection conn = new SqlConnection(con_str);
                String tk = txtTK.Text;
                String mk = txtMK.Text;
                String sql = "select count(*) from NguoiDung where TaiKhoan = @tk and MatKhau = @mk";
                int rs = 0;

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", tk));
                cmd.Parameters.Add(new SqlParameter("@mk", mk));
                rs = (int)cmd.ExecuteScalar();
                if(rs == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công!");
                }

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("err :" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
