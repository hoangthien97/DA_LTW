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

namespace QLNV
{
    public partial class frmTimkiem : Form
    {
        SqlConnection con;
        DataTable dt;
        DataView dv;
        SqlDataAdapter da;

        public frmTimkiem()
        {
            InitializeComponent();
        }

        private void frmTimkiem_Load(object sender, EventArgs e)
        {
            string strCnn = @"Data Source=DESKTOP-I9L9APE;Initial Catalog=QLNV;Integrated Security=True";
            con = new SqlConnection(strCnn);
            da = new SqlDataAdapter("select * from nhanvien", con);
            dt = new DataTable("nhanvien");
            da.Fill(dt);
            dv = new DataView(dt);
            dataGV1.DataSource = dv;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            dv.RowFilter = "hotennhanvien like '%" + ten + "%'";
            dataGV1.DataSource = dv;
        }

        //chuyển qua tab 2
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strCnn = @"Data Source=DESKTOP-I9L9APE;Initial Catalog=QLNV;Integrated Security=True";
            con = new SqlConnection(strCnn);
            da = new SqlDataAdapter("Select manhanvien as MaNhanVIen, hotennhanvien HoTenNhanVien, ngaysinh as NgaySinh, gioitinh as GioiTinh, dienthoai as DienTHoai, " +
                "diachi as DiaChi, email as Email, tenphongban as PhongBan from nhanvien a, phongban b where a.maphongban=b.maphongban", con);
            dt = new DataTable("nhanvien");
            da.Fill(dt);
            dv = new DataView(dt);
            dataGV2.DataSource = dv;
        }

        private void btnTim2_Click(object sender, EventArgs e)
        {
            string gt = cboGioitinh.Text;
            dv.RowFilter = "gioitinh like '" + gt + "'";
            dataGV2.DataSource = dv;
        }
    }
}
