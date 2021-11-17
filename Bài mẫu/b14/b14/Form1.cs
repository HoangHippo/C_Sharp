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
namespace b14
{
    public partial class Form1 : Form
    {
        string conn_str = "data source = LAPTOP-JSV9TQI0; initial catalog = b13 ; user id = sa; password = 123456";
        SqlConnection conn = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conn_str);        //ngay het han
                String date = DateTime.Today.ToString("yyyy/MM/dd");
                string sql = "select * from sp where sl = 0 or nsx < @date";
                DataSet rs = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add(new SqlParameter("@date", date));
                da.Fill(rs, "rs");
                dgv.DataSource = rs.Tables["rs"];
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
