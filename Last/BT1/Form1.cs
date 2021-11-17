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


namespace BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            String con_str = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=BT1;User ID=sa;Password=123456";
            String tk = txtTK.Text;
            String mk = txtMK.Text;
            String sql = "select count(*) from Nguoidung where Taikhoan = @tk and Matkhau = @mk";
            int rs = 0;
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.Add(new SqlParameter("@tk", tk));
                cmd.Parameters.Add(new SqlParameter("@mk", mk));
                rs = (int)cmd.ExecuteScalar();
                conn.Close();

                if(rs == 1)
                {
                    MessageBox.Show("Dang nhap thanh cong!");
                }
                else
                {
                    MessageBox.Show("That bai");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("err :" + ex.Message);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
