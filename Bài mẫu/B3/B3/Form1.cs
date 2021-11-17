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

namespace B3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String con_str = "Data Source = LAPTOP-JSV9TQI0; Initial catalog = DieuTraDS; User ID = sa; Password = 123456";

            try
            {
                String macd = txtMaCD.Text;
                String tencd = txtTenCD.Text;
                String cmnd = txtCMND.Text;
                String gt = radioButton1.Checked ? "nam" : "nu";
                int ns = Convert.ToInt32(txtNamSInh.Text);
                String sdt = txtSDT.Text;
                String sql = "insert into CongDan values (@macd, @tencd, @cmnd, @gt, @ns, @sdt)";

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
                showData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("er : " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void showData()
        {
            String con_str = "Data Source = LAPTOP-JSV9TQI0; Initial catalog = DieuTraDS; User ID = sa; Password = 123456";

            try
            {
                string sql = "select * from congdan";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "CongDan");

                dgv.DataSource = rs.Tables["CongDan"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("er : " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String cmnd = txtTimKiem.Text;
            String con_str = "Data Source = LAPTOP-JSV9TQI0; Initial catalog = DieuTraDS; User ID = sa; Password = 123456";

            try
            {
                string sql = "select * from congdan where cmnd like '%'+ @cmnd +'%'";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add(new SqlParameter("@cmnd", cmnd));
                da.Fill(rs, "CongDan");
                dgv.DataSource = rs.Tables["CongDan"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("er : " + ex.Message);
            }
        }
    }
}
