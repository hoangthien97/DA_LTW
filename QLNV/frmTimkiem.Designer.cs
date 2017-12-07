namespace QLNV
{
    partial class frmTimkiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPTimten = new System.Windows.Forms.TabPage();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.dataGV1 = new System.Windows.Forms.DataGridView();
            this.tabPTimGT = new System.Windows.Forms.TabPage();
            this.btnTim2 = new System.Windows.Forms.Button();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.cboGioitinh = new System.Windows.Forms.ComboBox();
            this.dataGV2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPTimten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV1)).BeginInit();
            this.tabPTimGT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPTimten);
            this.tabControl1.Controls.Add(this.tabPTimGT);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(493, 283);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPTimten
            // 
            this.tabPTimten.Controls.Add(this.btnTim);
            this.tabPTimten.Controls.Add(this.txtTen);
            this.tabPTimten.Controls.Add(this.lblTen);
            this.tabPTimten.Controls.Add(this.dataGV1);
            this.tabPTimten.Location = new System.Drawing.Point(4, 25);
            this.tabPTimten.Name = "tabPTimten";
            this.tabPTimten.Padding = new System.Windows.Forms.Padding(3);
            this.tabPTimten.Size = new System.Drawing.Size(485, 254);
            this.tabPTimten.TabIndex = 0;
            this.tabPTimten.Text = "Tìm theo tên";
            this.tabPTimten.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.Location = new System.Drawing.Point(333, 15);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.Location = new System.Drawing.Point(76, 16);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(251, 22);
            this.txtTen.TabIndex = 2;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTen.Location = new System.Drawing.Point(10, 19);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(60, 16);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Nhập tên";
            // 
            // dataGV1
            // 
            this.dataGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV1.Location = new System.Drawing.Point(6, 56);
            this.dataGV1.Name = "dataGV1";
            this.dataGV1.Size = new System.Drawing.Size(473, 192);
            this.dataGV1.TabIndex = 0;
            // 
            // tabPTimGT
            // 
            this.tabPTimGT.Controls.Add(this.btnTim2);
            this.tabPTimGT.Controls.Add(this.lblGioitinh);
            this.tabPTimGT.Controls.Add(this.cboGioitinh);
            this.tabPTimGT.Controls.Add(this.dataGV2);
            this.tabPTimGT.Location = new System.Drawing.Point(4, 25);
            this.tabPTimGT.Name = "tabPTimGT";
            this.tabPTimGT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPTimGT.Size = new System.Drawing.Size(485, 254);
            this.tabPTimGT.TabIndex = 1;
            this.tabPTimGT.Text = "Tìm theo giới tính";
            this.tabPTimGT.UseVisualStyleBackColor = true;
            // 
            // btnTim2
            // 
            this.btnTim2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim2.Location = new System.Drawing.Point(206, 19);
            this.btnTim2.Name = "btnTim2";
            this.btnTim2.Size = new System.Drawing.Size(75, 23);
            this.btnTim2.TabIndex = 3;
            this.btnTim2.Text = "Tìm";
            this.btnTim2.UseVisualStyleBackColor = true;
            this.btnTim2.Click += new System.EventHandler(this.btnTim2_Click);
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioitinh.Location = new System.Drawing.Point(15, 22);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(58, 16);
            this.lblGioitinh.TabIndex = 2;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // cboGioitinh
            // 
            this.cboGioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioitinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboGioitinh.FormattingEnabled = true;
            this.cboGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioitinh.Location = new System.Drawing.Point(79, 19);
            this.cboGioitinh.Name = "cboGioitinh";
            this.cboGioitinh.Size = new System.Drawing.Size(121, 24);
            this.cboGioitinh.TabIndex = 1;
            // 
            // dataGV2
            // 
            this.dataGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV2.Location = new System.Drawing.Point(6, 60);
            this.dataGV2.Name = "dataGV2";
            this.dataGV2.Size = new System.Drawing.Size(473, 191);
            this.dataGV2.TabIndex = 0;
            // 
            // frmTimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 307);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTimkiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frmTimkiem_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPTimten.ResumeLayout(false);
            this.tabPTimten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV1)).EndInit();
            this.tabPTimGT.ResumeLayout(false);
            this.tabPTimGT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPTimten;
        private System.Windows.Forms.TabPage tabPTimGT;
        private System.Windows.Forms.DataGridView dataGV1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Button btnTim2;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.ComboBox cboGioitinh;
        private System.Windows.Forms.DataGridView dataGV2;
    }
}