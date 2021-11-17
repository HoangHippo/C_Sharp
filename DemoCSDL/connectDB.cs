using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCSDL
{
    class connectDB
    {
        string con_str = "Data Source=DESKTOP-8SPQQOR\\SQLEXPRESS; Initial Catalog=QLBH_D14; User ID=sa; Password=123456;";
        SqlConnection conn = null;

        public connectDB()
        {
            conn = new SqlConnection(con_str);
        }

        public DataSet getData(string query, string table_name, List<SqlParameter> data)
        {
            DataSet ds = new DataSet();
            try
            {
                // Bước 1: Tạo Adapter
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                if (data != null)
                {
                    da.SelectCommand.Parameters.AddRange(data.ToArray());
                }
                da.Fill(ds, table_name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return ds;
        }

        public void execute(string query, List<SqlParameter> data)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if(data != null)
                {
                    cmd.Parameters.AddRange(data.ToArray());
                }
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


    }
}
