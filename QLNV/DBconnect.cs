using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLNV
{
    class DBconnect
    {
        SqlConnection sqlConn; //đối tượng kết nối sql
        SqlDataAdapter da;
        DataSet ds;

        public DBconnect()
        {
            string strCnn = @"Data Source=DESKTOP-I9L9APE;Initial Catalog=QLNV;Integrated Security=True";
            sqlConn = new SqlConnection(strCnn);
        }

        public SqlConnection getDB()
        {
            return new SqlConnection("Data Source=DESKTOP-I9L9APE;Initial Catalog=QLNV;Integrated Security=True");
        }

        public DataTable taobang(string sql)
        {
            sqlConn = getDB();
            SqlDataAdapter ad = new SqlDataAdapter(sql, sqlConn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        // phương thức để thực hiện câu lệnh truy vấn dữ liệu
        public DataTable Execute(string sqlStr)
        {

            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds, "nhanvien");
            return ds.Tables[0];
        }

        //phương thức thực hiện các câu lệnh thêm, xóa, sửa 
        public void ExcuteNonQuery(string strSQL)
        {

            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }

    }
}
