using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Thư viện của DataSet, DataTable
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Thư viện của Sql Data Provider

namespace DemoCSDL
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Code kiểm tra đăng nhập của người dùng; so sánh với tài khoản và mật khẩu trong Database
            try
            {
                // Bước 1: Khởi tạo kết nối
                string con_str = "Data Source=DESKTOP-8SPQQOR\\SQLEXPRESS; Initial Catalog=QLBH_D14; User ID=sa; Password=123456;";
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                //MessageBox.Show("Kết nối thành công!");
                // Bước 3: Tạo truy vấn
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string query = "select COUNT(*) from tbl_NguoiDung where TaiKhoan = @tk and MatKhau = @mk";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", tk));
                cmd.Parameters.Add(new SqlParameter("@mk", mk));
                // Chọn phương thức thực thi phù hợp
                int SoLuong = (int)cmd.ExecuteScalar();
                // Bước 5: Đóng kết nối
                conn.Close();

                // Kiểm tra SoLuong có thỏa mãn điều kiện hay không
                if(SoLuong == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
