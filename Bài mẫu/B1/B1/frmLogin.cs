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

namespace B1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // chuỗi kết nối với sql
            String con_str = "Data Source = LAPTOP-JSV9TQI0; Initial catalog = DieuTraDS; User ID = sa; Password = 123456";
            String tk = txtTK.Text;
            String mk = txtMK.Text;
            // truy vấn
            String sql = "select count(*) from nguoidung where taikhoan = @tk and matkhau = @mk";
            int rs = 0;
            try
            {
                // kết nối
                SqlConnection conn = new SqlConnection(con_str);
                // mở kế nối
                conn.Open();
                // tạo command đẻ thực hiện truy vấn 
                SqlCommand cmd = new SqlCommand(sql, conn);
                // tạo biến trong sql
                cmd.Parameters.Add(new SqlParameter("@tk", tk));
                cmd.Parameters.Add(new SqlParameter("@mk", mk));
                // lựa chọn kiểu thực thi truy vấn
                rs = (int)cmd.ExecuteScalar();
                conn.Close();

                if(rs == 1)
                {
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Đăng Nhập thành công! ");
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Không thành công! ");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("err : " + ex.Message);
            }
            

        }
    }
}
