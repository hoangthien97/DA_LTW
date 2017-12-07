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
    public partial class Form1 : Form
    {
        public bool themmoi = false;
        NhanVien nv = new NhanVien();
        DBconnect db = new DBconnect();

        public Form1()
        {
            InitializeComponent();
        }

        private DataTable truyvan(string sql, SqlConnection con)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        void Hienthitw()
        {
            SqlConnection con = db.getDB();
            con.Open();
            DataTable ndcha = new DataTable();
            //tạo nút gốc
            TreeNode root = new TreeNode("Danh sách phòng ban");
            trV.Nodes.Add(root);
            trV.Nodes[0].Tag = "0";
            //duyệt phòng ban đưa vào nút gốc
            ndcha = truyvan("select tenphongban from phongban", con);
            for (int i = 0; i < ndcha.Rows.Count; i++)
            {
                trV.Nodes[0].Nodes.Add(ndcha.Rows[i][0].ToString());
                trV.Nodes[0].Nodes[i].Tag = "2";
            }
        }

        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        void HienthiNV()
        {
            lvNhanvien.Items.Clear();
            DataTable dt = nv.LayDSNV();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lvNhanvien.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
            }
        }

        void HienthiPB()
        {
            DataTable dt = nv.LayPB();
            cboPhongban.DataSource = dt;
            cboPhongban.DisplayMember = "TenPhongBan";
            cboPhongban.ValueMember = "MaPhongBan";
        }

        void setNull()
        {
            txtHoten.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            txtEmail.Text = "";
        }

        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnLammoi.Enabled = val;
            btnThoat.Enabled = val;
            btnDangxuat.Enabled = val;
            btnHienthi.Enabled = val;
            btnLuu.Enabled = !val;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
           // HienthiNV();
            HienthiPB();
            Hienthitw();
        }

        //sự kiện đóng form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //hiển thị thông tin NV lên các control
        private void lvNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanvien.SelectedItems.Count > 0)
            {
                ListViewItem isl = lvNhanvien.SelectedItems[0];
                txtMaNV.Text = isl.SubItems[0].Text;
                txtHoten.Text = isl.SubItems[1].Text;
                dtpNgaysinh.Value = DateTime.Parse(isl.SubItems[2].Text);
                if (lvNhanvien.SelectedItems[0].SubItems[3].Text == "Nam")
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                txtDienthoai.Text = isl.SubItems[4].Text;
                txtDiachi.Text = isl.SubItems[5].Text;
                txtEmail.Text = isl.SubItems[6].Text;
                cboPhongban.Text = lvNhanvien.SelectedItems[0].SubItems[7].Text;
            }
        }

        //button làm mới
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHoten.Clear();
            txtDienthoai.Clear();
            txtDiachi.Clear();
            txtEmail.Clear();
            rdbNam.Checked = false;
            rdbNu.Checked = false;
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            HienthiNV();
        }

        //button thêm
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            txtHoten.Focus();
        }

        //button sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvNhanvien.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn cần chọn nhân viên cần cập nhật", "Sửa thông tin");
        }

        //button tìm kiếm
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            frmTimkiem frm2 = new frmTimkiem();
            frm2.Activate();
            frm2.Show();
        }


        //button hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        //button thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult dlr = MessageBox.Show("Bạn thực sự muốn thoát?", "Thoát",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        //button xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvNhanvien.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bán có muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv.XoaNV(lvNhanvien.SelectedItems[0].SubItems[0].Text);
                    lvNhanvien.Items.RemoveAt(lvNhanvien.SelectedIndices[0]);
                    setNull();
                }
                else
                    MessageBox.Show("Bạn phải chọn mẫu tin cần xóa!");
            }
        }

        //lấy text trong radiobutton nếu radiobutton đó đc check
        string gt;
        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = sender as RadioButton;
            if (rd.Checked)
                gt = rd.Text;
        }

        //lưu lại thông tin khi thêm hoặc cập nhật
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngay = string.Format("{0:dd/MM/yyyy}", dtpNgaysinh.Value);
            if (themmoi)
            {
                nv.ThemNV(txtHoten.Text, ngay, gt, txtDienthoai.Text, txtDiachi.Text, txtEmail.Text, cboPhongban.SelectedValue.ToString());
                MessageBox.Show("Thêm nhân viên mới thành công.");
            }
            else
            {
                nv.CapnhatNV(lvNhanvien.SelectedItems[0].SubItems[0].Text, txtHoten.Text, ngay, gt, txtDienthoai.Text, txtDiachi.Text, txtEmail.Text, cboPhongban.SelectedValue.ToString());
                MessageBox.Show("Cập nhật thông tin thành công.");
            }
            HienthiNV();
            setNull();
        }

        //button đăng xuất
        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                //this.Close();
                frmDangnhap frm = new frmDangnhap();
                frm.ShowDialog();
            }
        }

        //chỉ cho người dùng nhập chữ vào textbox hoten
        private void txtHoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))  //isDigit() kiểm tra xem ký tự vừa nhập vào textbox có phải là ký tự số hay không
            {
                e.Handled = true;
                MessageBox.Show("Họ tên phải là kí tự chữ ", "Thông Báo ");
            }
        }

        //chỉ cho người dùng nhập số vào textbox điện thoại
        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Điện thoại phải là kí tự số ", "Thông Báo ");
            }
        }

        //các button duyệt ds
        //button next
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lvNhanvien.SelectedItems.Count > 0)
            {
                int vt = lvNhanvien.SelectedItems[0].Index;
                if (vt == lvNhanvien.Items.Count - 1)
                {
                    MessageBox.Show("Bạn đã ở cuối");
                    lvNhanvien.Focus();
                }
                else
                {
                    lvNhanvien.Items[vt + 1].Selected = true;
                    lvNhanvien.Items[vt].Selected = false;
                    txtMaNV.Text = lvNhanvien.Items[vt + 1].SubItems[0].Text;
                    txtHoten.Text = lvNhanvien.Items[vt + 1].SubItems[1].Text;
                    txtDienthoai.Text = lvNhanvien.Items[vt + 1].SubItems[4].Text;
                    txtDiachi.Text = lvNhanvien.Items[vt + 1].SubItems[5].Text;
                    txtEmail.Text = lvNhanvien.Items[vt + 1].SubItems[6].Text;
                    cboPhongban.Text = lvNhanvien.Items[vt + 1].SubItems[7].Text;
                }
            }
        }

        //button previous
        private void btnPre_Click(object sender, EventArgs e)
        {
            if (lvNhanvien.SelectedItems.Count > 0)
            {
                int vt = lvNhanvien.SelectedItems[0].Index;
                if(lvNhanvien.Items[0].Selected == true)
                {
                    MessageBox.Show("Bạn đã ở đầu");
                }
                else
                {
                    lvNhanvien.Items[vt - 1].Selected = true;
                    lvNhanvien.Items[vt].Selected = false;
                    txtMaNV.Text = lvNhanvien.Items[vt - 1].SubItems[0].Text;
                    txtHoten.Text = lvNhanvien.Items[vt - 1].SubItems[1].Text;
                    txtDienthoai.Text = lvNhanvien.Items[vt - 1].SubItems[4].Text;
                    txtDiachi.Text = lvNhanvien.Items[vt - 1].SubItems[5].Text;
                    txtEmail.Text = lvNhanvien.Items[vt - 1].SubItems[6].Text;
                    cboPhongban.Text = lvNhanvien.Items[vt - 1].SubItems[7].Text;
                }
            }
        }

        //button first
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (lvNhanvien.SelectedItems.Count > 0)
            {
                if (lvNhanvien.Items[0].Selected == true)
                {
                    MessageBox.Show("Bạn đã ở đầu");
                    lvNhanvien.Focus();
                }
                else
                {
                    lvNhanvien.Items[0].Selected = true;
                    txtMaNV.Text = lvNhanvien.Items[0].SubItems[0].Text;
                    txtHoten.Text = lvNhanvien.Items[0].SubItems[1].Text;
                    if (lvNhanvien.Items[0].SubItems[3].Text == "Nam")
                        rdbNam.Checked = true;
                    else
                        rdbNu.Checked = true;
                    txtDienthoai.Text = lvNhanvien.Items[0].SubItems[4].Text;
                    txtDiachi.Text = lvNhanvien.Items[0].SubItems[5].Text;
                    txtEmail.Text = lvNhanvien.Items[0].SubItems[6].Text;
                    cboPhongban.Text = lvNhanvien.Items[0].SubItems[7].Text;
                }
            }
        }

        //button last
        private void btnLast_Click(object sender, EventArgs e)
        {
            if (lvNhanvien.SelectedItems.Count > 0)
            {
                if (lvNhanvien.Items[lvNhanvien.Items.Count - 1].Selected == true)
                {
                    MessageBox.Show("Bạn đã ở cuối");
                }
                else
                {
                    lvNhanvien.Items[lvNhanvien.Items.Count - 1].Selected = true;
                    txtMaNV.Text = lvNhanvien.Items[lvNhanvien.Items.Count - 1].SubItems[0].Text;
                    txtHoten.Text = lvNhanvien.Items[lvNhanvien.Items.Count - 1].SubItems[1].Text;
                    if (lvNhanvien.Items[lvNhanvien.Items.Count - 1].SubItems[3].Text == "Nam")
                        rdbNam.Checked = true;
                    else
                        rdbNu.Checked = true;
                    txtDienthoai.Text = lvNhanvien.Items[lvNhanvien.Items.Count - 1].SubItems[4].Text;
                    txtDiachi.Text = lvNhanvien.Items[lvNhanvien.Items.Count - 1].SubItems[5].Text;
                    txtEmail.Text = lvNhanvien.Items[lvNhanvien.Items.Count - 1].SubItems[6].Text;
                    cboPhongban.Text = lvNhanvien.Items[lvNhanvien.Items.Count - 1].SubItems[7].Text;
                }
            }
        }
    }
}
