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

namespace B20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                String con_str = "Data source = LAPTOP-JSV9TQI0; Initial catalog = SimThe ; user id = sa; password = 123456";
                String sql = "select * from Sim order by NgayKichHoat ";
                SqlConnection conn = new SqlConnection(con_str);
                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "DATA");
                dgv.DataSource = ds.Tables["DATA"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
