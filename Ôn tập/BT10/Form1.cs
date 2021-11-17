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

namespace BT10
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
                String malop = txtMaLop.Text;
                String tbn = txtTenBeNgoan.Text;
                int ns = Convert.ToInt32(txtNgaySinh.Text);
                String gt = radioButton1.Checked ? "Nam" : "Nu";
                String htBo = txtHoTenBo.Text;
                String htMe = txtHoTenMe.Text;
                String dc = txtDiaChi.Text;
                SqlConnection conn = new SqlConnection(con_str);
                String sql = "insert into BeNgoan values (@mabn,@malop,@tbn,@ns,@gt,@htBo,@htMe,@dc)";

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@mabn", mabn));
                cmd.Parameters.Add(new SqlParameter("@malop", malop));
                cmd.Parameters.Add(new SqlParameter("@tbn", tbn));
                cmd.Parameters.Add(new SqlParameter("@ns", ns));
                cmd.Parameters.Add(new SqlParameter("@gt", gt));
                cmd.Parameters.Add(new SqlParameter("@htBo", htBo));
                cmd.Parameters.Add(new SqlParameter("@htMe", htMe));
                cmd.Parameters.Add(new SqlParameter("@dc", dc));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("err :" + ex.Message);
            }
        }
    }
}
