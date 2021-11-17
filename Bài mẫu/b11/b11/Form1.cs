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
namespace b11
{
    public partial class Form1 : Form
    {
        string conn_str = "data source = LAPTOP-JSV9TQI0; initial catalog = b8 ; user id = sa; password = 123456";
        SqlConnection conn = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conn_str);
                string mabe = txt.Text;
                string malop = cbb.SelectedValue.ToString();
                MessageBox.Show(cbb.SelectedValue.ToString());

                string sql = "update bengoan set malop = @malop where mabn = @mabe"; ;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@malop", malop));
                cmd.Parameters.Add(new SqlParameter("@mabe", mabe));

                int rs = (int)cmd.ExecuteNonQuery();
                if (rs == 1)
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("err");
                }

                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conn_str);
                string sql = "select * from lop";
                DataSet rs = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "rs");
                cbb.DataSource = rs.Tables["rs"];
                cbb.DisplayMember = "tenlop";
                cbb.ValueMember = "malop";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
