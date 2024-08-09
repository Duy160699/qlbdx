using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiDoXe
{
    class LopDungChung
    {
        string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Me\CS464SC-LTUD\QuanLyBaiDoXe\QuanLyBaiDoXe\Database1.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(chuoiketnoi);
        }
        public DataTable LoadData(string sqlData)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlData, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void NonQuery(string sqlNonQuery)
        {
            SqlCommand comm = new SqlCommand(sqlNonQuery, conn);
            conn.Open();
            int ketqua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketqua >= 1)
            {
                MessageBox.Show("thành công");
            }
            else
            {
                MessageBox.Show("thất bại");
            }
        }
        public int Scalar(string sql)
        {
            SqlCommand scl = new SqlCommand(sql, conn);
            conn.Open();
            int ketqua = (int)scl.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
    }
}
