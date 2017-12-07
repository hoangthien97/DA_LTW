using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLNV
{
    class NhanVien
    {
        DBconnect db;
        public NhanVien()
        {
            db = new DBconnect();
        }

        public DataTable LayDSNV()
        {
            string strSQL = "Select manhanvien, hotennhanvien, ngaysinh, gioitinh, dienthoai, " +
                "diachi, email, tenphongban from nhanvien a, phongban b where a.maphongban=b.maphongban";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable PBM()
        {
            string strSQL = "Select manhanvien, hotennhanvien, ngaysinh, gioitinh, dienthoai, " +
               "diachi, email, tenphongban from nhanvien a, phongban b where a.maphongban=b.maphongban and b.maphongban=1";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayPB()
        {
            string strSQL = "Select * from phongban";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        //thêm NV
        public void ThemNV(string ten, string ngaysinh, string gt, string dt, string dc, string email, string index_pb)
        {
            string sql = string.Format("insert into nhanvien values (N'{0}','{1}',N'{2}','{3}',N'{4}',N'{5}','{6}')", 
                ten, ngaysinh, gt, dt, dc, email, index_pb);
            db.ExcuteNonQuery(sql);

        }

        //xóa NV
        public void XoaNV(string index_nv)
        {
            string sql = "Delete from NHANVIEN where MaNhanVien = " + index_nv;
            db.ExcuteNonQuery(sql);
        }

        //Cập nhật thông tin NV
        public void CapnhatNV(string index_nv, string ten, string ngaysinh, string gt,string dt, string dc,string email, string index_pb)
        {
            string str = string.Format("update nhanvien set HoTenNhanVien = N'{0}', NgaySinh ='{1}', GioiTinh = N'{2}', DienThoai= '{3}', DiaChi = N'{4}', Email = '{5}', MaPhongBan ={6} where MaNhanVien={7}",
                ten, ngaysinh, gt, dt, dc, email, index_pb, index_nv);
            db.ExcuteNonQuery(str);
        }

    }
}
