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

namespace B19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String con_str = "Data source = LAPTOP-JSV9TQI0; Initial catalog = Simthe; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(con_str);
            String sdt = txt.Text;

            String sql = "select * from Sim where SoSim = @SDT";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.Add(new SqlParameter("@SDT", sdt));
            da.Fill(ds, "D");
            String id = ds.Tables["D"].Rows[0]["SoSim"].ToString();
            String ngay = DateTime.Parse(ds.Tables["D"].Rows[0]["NgayKichHoat"].ToString()).ToString("yyyy-MM-dd");
            MessageBox.Show(id  + " ngày hết hạn là: " + ngay);
        }
    }
}
