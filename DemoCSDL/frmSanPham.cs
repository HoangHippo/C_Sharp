using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Thư viện SqlDataProvider

namespace DemoCSDL
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            clearText();
            getcmbLoaiSP();
            getData();
        }

        public void getcmbLoaiSP()
        {
            List<Models.LoaiSP> lst = new List<Models.LoaiSP>();
            // Lấy dữ liệu từ database và hiển thị lên DataGridView
            try
            {
                // Bước 1: Khởi tạo kết nối
                string con_str = "Data Source=DESKTOP-8SPQQOR\\SQLEXPRESS; Initial Catalog=QLBH_D14; User ID=sa; Password=123456;";
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "select * from tbl_LoaiSP";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                // -- lựa chọn phương thức thực thi phù hợp
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Models.LoaiSP obj = new Models.LoaiSP(rd);
                    lst.Add(obj);
                }
                // Bước 5: Đóng kết nối
                conn.Close();
                // Hiển thị dữ liệu của List lên ComboBox
                cmbLoaiSP.DataSource = lst;
                // DisplayMember: Xác định dữ liệu nào hiển thị lên ComboBox
                cmbLoaiSP.DisplayMember = "TenLoaiSP";
                // ValueMember: Giá trị ánh xạ với lựa chọn trên ComboBox
                cmbLoaiSP.ValueMember = "MaLoaiSP";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void getData()
        {
            List<Models.SanPham> lst = new List<Models.SanPham>();
            // Lấy dữ liệu từ database và hiển thị lên DataGridView
            try
            {
                // Bước 1: Khởi tạo kết nối
                string con_str = "Data Source=DESKTOP-8SPQQOR\\SQLEXPRESS; Initial Catalog=QLBH_D14; User ID=sa; Password=123456;";
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "select * from tbl_SanPham";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                // -- lựa chọn phương thức thực thi phù hợp
                SqlDataReader rd = cmd.ExecuteReader();
                
                while (rd.Read())
                {
                    Models.SanPham obj = new Models.SanPham(rd);
                    lst.Add(obj);
                }
                // Bước 5: Đóng kết nối
                conn.Close();
                // Hiển thị dữ liệu của List lên DataGridView
                dgvSanPham.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
            getData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<Models.SanPham> lst = new List<Models.SanPham>();
            // Lấy dữ liệu từ database và hiển thị lên DataGridView
            try
            {
                // Bước 1: Khởi tạo kết nối
                string con_str = "Data Source=DESKTOP-8SPQQOR\\SQLEXPRESS; Initial Catalog=QLBH_D14; User ID=sa; Password=123456;";
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string tk = txtTimKiem.Text;
                string query = "select * from tbl_SanPham where TenSP LIKE '%' + @tk + '%' or MoTa LIKE '%' + @tk + '%' or MaLoaiSP LIKE '%' + @tk + '%'";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", tk));
                // -- lựa chọn phương thức thực thi phù hợp
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Models.SanPham obj = new Models.SanPham(rd);
                    lst.Add(obj);
                }
                // Bước 5: Đóng kết nối
                conn.Close();
                // Hiển thị dữ liệu của List lên DataGridView
                dgvSanPham.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Bước 1: Khởi tạo kết nối
                string con_str = "Data Source=DESKTOP-8SPQQOR\\SQLEXPRESS; Initial Catalog=QLBH_D14; User ID=sa; Password=123456;";
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                string mota = txtMoTa.Text;
                string maloaisp = cmbLoaiSP.SelectedValue.ToString();
                int soluongton = int.Parse(txtSoLuongTon.Text);
                long dongia = long.Parse(txtDonGia.Text);
                string query = "Insert into tbl_SanPham (MaSP, TenSP, MoTa, MaLoaiSP, SoLuongTon, DonGia)VALUES(@MaSP, @TenSP, @MoTa, @MaLoaiSP, @SoLuongTon, @DonGia)";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaSP", masp));
                cmd.Parameters.Add(new SqlParameter("@TenSP", tensp));
                cmd.Parameters.Add(new SqlParameter("@MoTa", mota));
                cmd.Parameters.Add(new SqlParameter("@MaLoaiSP", maloaisp));
                cmd.Parameters.Add(new SqlParameter("@SoLuongTon", soluongton));
                cmd.Parameters.Add(new SqlParameter("@DonGia", dongia));

                cmd.ExecuteNonQuery();

                // Bước 5: Đóng kết nối
                conn.Close();

                MessageBox.Show("Thêm mới thành công!");
                // Load lại dữ liệu trên GridView
                getData();
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void clearText()
        {
            btnThem.Enabled = true;
            txtMaSP.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtMoTa.Text = "";
            //txtMaLoaiSP.Text = "";
            txtSoLuongTon.Text = "0";
            txtDonGia.Text = "0";
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đọc dữ liệu của dòng người dùng chọn, fill lên các ô text
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                btnThem.Enabled = false;
                txtMaSP.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMaSP.Text = dgvSanPham.Rows[idx].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dgvSanPham.Rows[idx].Cells["TenSP"].Value.ToString();
                txtMoTa.Text = dgvSanPham.Rows[idx].Cells["MoTa"].Value.ToString();
                //txtMaLoaiSP.Text = dgvSanPham.Rows[idx].Cells["MaLoaiSP"].Value.ToString();
                cmbLoaiSP.SelectedValue = dgvSanPham.Rows[idx].Cells["MaLoaiSP"].Value;
                txtSoLuongTon.Text = dgvSanPham.Rows[idx].Cells["SoLuongTon"].Value.ToString();
                txtDonGia.Text = dgvSanPham.Rows[idx].Cells["DonGia"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Bước 1: Khởi tạo kết nối
                string con_str = "Data Source=DESKTOP-8SPQQOR\\SQLEXPRESS; Initial Catalog=QLBH_D14; User ID=sa; Password=123456;";
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string masp = txtMaSP.Text;
                string query = "Delete from tbl_SanPham where MaSP = @MaSP";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaSP", masp));

                cmd.ExecuteNonQuery();

                // Bước 5: Đóng kết nối
                conn.Close();

                MessageBox.Show("Xóa thành công!");
                // Load lại dữ liệu trên GridView
                getData();
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
