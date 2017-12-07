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
    public partial class frmDangnhap : Form
    {

        string strConnection = @"Data Source=DESKTOP-I9L9APE;Initial Catalog=Login;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;

        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strConnection);
                con.Open();
                string sql = "select count(*) from tblogin where taikhoan=@acc and matkhau=@pass";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@acc", txtTaikhoan.Text)); //tạo đối số để đối chiếu với thuộc tính 
                cmd.Parameters.Add(new SqlParameter("@pass", txtMatkhau.Text)); //tạo đối số để đối chiếu với thuộc tính 
                int x = (int)cmd.ExecuteScalar();   // trả về kết quả hàm count
                if (x == 1)
                {

                    MessageBox.Show("Đăng nhập thành công.", "Thông báo");
                    Visible = false;    //ẩn mainForm
                    Form1 frm1 = new Form1();   //tạo form1 và sử dụng form1
                    frm1.Activate();
                    frm1.Show();
                }

                else
                    lblTBsai.Text = "Bạn nhập sai tài khoản hoặc mật khẩu";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ckbHIenmk_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHIenmk.Checked)
                txtMatkhau.UseSystemPasswordChar = false;
            else
                txtMatkhau.UseSystemPasswordChar = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void frmDangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
