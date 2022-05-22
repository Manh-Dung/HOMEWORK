namespace FormLogin
{
    partial class FAdMain
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
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboMon = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.themTK = new System.Windows.Forms.ToolStripMenuItem();
            this.thayDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.maGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuanGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(1104, 227);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(247, 27);
            this.txtTim.TabIndex = 34;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(860, 227);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(225, 32);
            this.btnTim.TabIndex = 33;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(652, 227);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(202, 32);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(442, 227);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(202, 32);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(233, 227);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(202, 32);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(22, 227);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(202, 32);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // cboMon
            // 
            this.cboMon.FormattingEnabled = true;
            this.cboMon.Location = new System.Drawing.Point(1104, 170);
            this.cboMon.Margin = new System.Windows.Forms.Padding(4);
            this.cboMon.Name = "cboMon";
            this.cboMon.Size = new System.Drawing.Size(247, 27);
            this.cboMon.TabIndex = 28;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(1104, 120);
            this.cboLop.Margin = new System.Windows.Forms.Padding(4);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(247, 27);
            this.cboLop.TabIndex = 27;
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(1104, 67);
            this.cboKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(247, 27);
            this.cboKhoa.TabIndex = 26;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(634, 170);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 27);
            this.txtEmail.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1007, 174);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Môn học";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(634, 120);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(219, 27);
            this.txtSDT.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1007, 124);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1007, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Khoa";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(634, 67);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(4);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(219, 27);
            this.txtQueQuan.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quê quán";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(141, 170);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(219, 27);
            this.txtNgaySinh.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày sinh";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(141, 120);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(219, 27);
            this.txtTenGV.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên giảng viên";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(141, 68);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(219, 27);
            this.txtMaGV.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã giảng viên";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taiKhoan,
            this.quảnLýToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1386, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taiKhoan
            // 
            this.taiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themTK,
            this.thayDoiMK,
            this.dangXuat,
            this.toolStripSeparator1,
            this.thoátToolStripMenuItem});
            this.taiKhoan.Name = "taiKhoan";
            this.taiKhoan.Size = new System.Drawing.Size(85, 24);
            this.taiKhoan.Text = "Tài khoản";
            // 
            // themTK
            // 
            this.themTK.Name = "themTK";
            this.themTK.Size = new System.Drawing.Size(224, 26);
            this.themTK.Text = "Thêm tài khoản";
            // 
            // thayDoiMK
            // 
            this.thayDoiMK.Name = "thayDoiMK";
            this.thayDoiMK.Size = new System.Drawing.Size(224, 26);
            this.thayDoiMK.Text = "Thay đổi mật khẩu";
            // 
            // dangXuat
            // 
            this.dangXuat.Name = "dangXuat";
            this.dangXuat.Size = new System.Drawing.Size(224, 26);
            this.dangXuat.Text = "Đăng xuất";
            this.dangXuat.Click += new System.EventHandler(this.dangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeyDisplayString = "Alt + X";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khoaToolStripMenuItem,
            this.lớpToolStripMenuItem,
            this.mônHọcToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // khoaToolStripMenuItem
            // 
            this.khoaToolStripMenuItem.Name = "khoaToolStripMenuItem";
            this.khoaToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.khoaToolStripMenuItem.Text = "Khoa";
            // 
            // lớpToolStripMenuItem
            // 
            this.lớpToolStripMenuItem.Name = "lớpToolStripMenuItem";
            this.lớpToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.lớpToolStripMenuItem.Text = "Lớp";
            // 
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.mônHọcToolStripMenuItem.Text = "Môn học";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.trợGiúpToolStripMenuItem.Text = "Báo cáo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Danh sách giảng viên";
            // 
            // dgvGiangVien
            // 
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGV,
            this.tenGV,
            this.ngaySinhGV,
            this.queQuanGV,
            this.sdt,
            this.email,
            this.maKhoa,
            this.maLop,
            this.maMonHoc});
            this.dgvGiangVien.Location = new System.Drawing.Point(14, 332);
            this.dgvGiangVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.RowHeadersWidth = 51;
            this.dgvGiangVien.RowTemplate.Height = 24;
            this.dgvGiangVien.Size = new System.Drawing.Size(1358, 361);
            this.dgvGiangVien.TabIndex = 9;
            // 
            // maGV
            // 
            this.maGV.DataPropertyName = "maGV";
            this.maGV.HeaderText = "Mã giảng viên";
            this.maGV.MinimumWidth = 6;
            this.maGV.Name = "maGV";
            this.maGV.Width = 80;
            // 
            // tenGV
            // 
            this.tenGV.DataPropertyName = "tenGV";
            this.tenGV.HeaderText = "Tên giảng viên";
            this.tenGV.MinimumWidth = 6;
            this.tenGV.Name = "tenGV";
            this.tenGV.Width = 170;
            // 
            // ngaySinhGV
            // 
            this.ngaySinhGV.DataPropertyName = "ngaySinhGV";
            this.ngaySinhGV.HeaderText = "Ngày sinh";
            this.ngaySinhGV.MinimumWidth = 6;
            this.ngaySinhGV.Name = "ngaySinhGV";
            this.ngaySinhGV.Width = 125;
            // 
            // queQuanGV
            // 
            this.queQuanGV.DataPropertyName = "queQuanGV";
            this.queQuanGV.HeaderText = "Quê quán";
            this.queQuanGV.MinimumWidth = 6;
            this.queQuanGV.Name = "queQuanGV";
            this.queQuanGV.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 180;
            // 
            // maKhoa
            // 
            this.maKhoa.DataPropertyName = "maKhoa";
            this.maKhoa.HeaderText = "Mã khoa";
            this.maKhoa.MinimumWidth = 6;
            this.maKhoa.Name = "maKhoa";
            this.maKhoa.Width = 125;
            // 
            // maLop
            // 
            this.maLop.DataPropertyName = "maLop";
            this.maLop.HeaderText = "Mã lớp";
            this.maLop.MinimumWidth = 6;
            this.maLop.Name = "maLop";
            this.maLop.Width = 125;
            // 
            // maMonHoc
            // 
            this.maMonHoc.DataPropertyName = "maMonHoc";
            this.maMonHoc.HeaderText = "Mã môn học";
            this.maMonHoc.MinimumWidth = 6;
            this.maMonHoc.Name = "maMonHoc";
            this.maMonHoc.Width = 125;
            // 
            // FAdMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 700);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboMon);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGiangVien);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FAdMain";
            this.Text = "FAdMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboMon;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taiKhoan;
        private System.Windows.Forms.ToolStripMenuItem themTK;
        private System.Windows.Forms.ToolStripMenuItem thayDoiMK;
        private System.Windows.Forms.ToolStripMenuItem dangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuanGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonHoc;
    }
}