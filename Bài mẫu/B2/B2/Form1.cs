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
using System.Data;

namespace B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String con_str = "Data Source = LAPTOP-JSV9TQI0; Initial catalog = DieuTraDS; User ID = sa; Password = 123456";
            String sql = "select * from congdan order by tencd";
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                //khởi tạo data set lưu dữ liệu
                DataSet rs = new DataSet();
                // tự quản lí mở kết nối
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "CongDan");
                //conn.Open();
                //SqlCommand cmd = new SqlCommand(sql, conn);


                //conn.Close();

                dgv.DataSource = rs.Tables["CongDan"];


            }
            catch(Exception ex)
            {
                MessageBox.Show("err : " + ex.Message);
            }

        }
    }
}
