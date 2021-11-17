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

namespace BT3
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
                String macd = txtMaCD.Text;
                String tencd = txtTenCD.Text;
                String cmnd = txtCMND.Text;
                String gt = radioButton1.Checked ? "nam" : "nu";
                int ns = Convert.ToInt32(txtNamSinh.Text);
                String sdt = txtSDT.Text;
                String sql = "insert into CongDan values (@macd,@tencd,@cmnd,@gt,@ns,@sdt)";

                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@macd", macd));
                cmd.Parameters.Add(new SqlParameter("@tencd", tencd));
                cmd.Parameters.Add(new SqlParameter("@cmnd", cmnd));
                cmd.Parameters.Add(new SqlParameter("@gt", gt));
                cmd.Parameters.Add(new SqlParameter("@ns", ns));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));

                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Thêm thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("er :" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
