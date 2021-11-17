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

namespace DemoCSDL
{
    public partial class frmSanPhamDataSet : Form
    {
        connectDB db = new connectDB();

        public frmSanPhamDataSet()
        {
            InitializeComponent();
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
            getData();

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

        public void getData()
        {
            try
            {
                string query = "select * from tbl_SanPham";
                DataSet ds = db.getData(query, "SanPham", null);
                dgvSanPham.DataSource = ds.Tables["SanPham"];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void getcmbLoaiSP()
        {
            try
            {
                string query = "select * from tbl_LoaiSP";
                DataSet ds = db.getData(query, "LoaiSP", null);
                // Hiển thị dữ liệu lên ComboBox
                cmbLoaiSP.DataSource = ds.Tables["LoaiSP"];
                // Xác định ValueMember, DisplayMember
                cmbLoaiSP.ValueMember = "MaLoaiSP";
                cmbLoaiSP.DisplayMember = "TenLoaiSP";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void frmSanPhamDataSet_Load(object sender, EventArgs e)
        {
            clearText();
            getcmbLoaiSP();
            getData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                string mota = txtMoTa.Text;
                string maloaisp = cmbLoaiSP.SelectedValue.ToString();
                int soluongton = int.Parse(txtSoLuongTon.Text);
                long dongia = long.Parse(txtDonGia.Text);
                string query = "Insert into tbl_SanPham (MaSP, TenSP, MoTa, MaLoaiSP, SoLuongTon, DonGia)VALUES(@MaSP, @TenSP, @MoTa, @MaLoaiSP, @SoLuongTon, @DonGia)";

                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@MaSP", masp));
                data.Add(new SqlParameter("@TenSP", tensp));
                data.Add(new SqlParameter("@MoTa", mota));
                data.Add(new SqlParameter("@MaLoaiSP", maloaisp));
                data.Add(new SqlParameter("@SoLuongTon", soluongton));
                data.Add(new SqlParameter("@DonGia", dongia));

                db.execute(query, data);

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txtMaSP.Text;
                string query = "Delete from tbl_SanPham where MaSP = @MaSP";
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@MaSP", masp));
                db.execute(query, data);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from tbl_SanPham where TenSP like '%' + @tk + '%'";
                string tk = txtTimKiem.Text;
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@tk", tk));
                DataSet ds = db.getData(query, "SanPham", data);
                // Hiển thị dữ liệu vừa lấy được ở DataSet lên DataGridView
                dgvSanPham.DataSource = ds.Tables["SanPham"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
