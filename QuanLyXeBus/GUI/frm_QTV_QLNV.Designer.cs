namespace QuanLyXeBus.GUI
{
    partial class frm_QTV_QLNV
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
            this.dgv_QTV_DanhSachQuanTriVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_QTV_LamMoiQuanTriVien = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_QTV_LuuQuanTriVien = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_QTV_XoaQuanTriVien = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_QTV_ThemQuanTriVien = new QuanLyXeBus.CustomControls.RJButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_QTV_EmailQuanTriVien = new System.Windows.Forms.TextBox();
            this.txt_QTV_HoTenQuanTriVien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_QTV_MatKhauQuanTriVien = new System.Windows.Forms.TextBox();
            this.txt_QTV_LoaiTaiKhoanQuanTriVien = new System.Windows.Forms.TextBox();
            this.cbb_QTV_ChucVuQuanTriVien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_QTV_IDQuanTriVien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_QTV_TimKiemQuanTriVien = new QuanLyXeBus.CustomControls.RJButton();
            this.txt_QTV_TimKiemQuanTriVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QTV_DanhSachQuanTriVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_QTV_DanhSachQuanTriVien
            // 
            this.dgv_QTV_DanhSachQuanTriVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_QTV_DanhSachQuanTriVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QTV_DanhSachQuanTriVien.Location = new System.Drawing.Point(77, 407);
            this.dgv_QTV_DanhSachQuanTriVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_QTV_DanhSachQuanTriVien.Name = "dgv_QTV_DanhSachQuanTriVien";
            this.dgv_QTV_DanhSachQuanTriVien.RowHeadersWidth = 51;
            this.dgv_QTV_DanhSachQuanTriVien.RowTemplate.Height = 24;
            this.dgv_QTV_DanhSachQuanTriVien.Size = new System.Drawing.Size(798, 167);
            this.dgv_QTV_DanhSachQuanTriVien.TabIndex = 23;
            this.dgv_QTV_DanhSachQuanTriVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QTV_DanhSachQuanTriVien_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_QTV_LamMoiQuanTriVien);
            this.groupBox2.Controls.Add(this.btn_QTV_LuuQuanTriVien);
            this.groupBox2.Controls.Add(this.btn_QTV_XoaQuanTriVien);
            this.groupBox2.Controls.Add(this.btn_QTV_ThemQuanTriVien);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(694, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(181, 243);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_QTV_LamMoiQuanTriVien
            // 
            this.btn_QTV_LamMoiQuanTriVien.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_LamMoiQuanTriVien.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_LamMoiQuanTriVien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_QTV_LamMoiQuanTriVien.BorderRadius = 25;
            this.btn_QTV_LamMoiQuanTriVien.BorderSize = 0;
            this.btn_QTV_LamMoiQuanTriVien.FlatAppearance.BorderSize = 0;
            this.btn_QTV_LamMoiQuanTriVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QTV_LamMoiQuanTriVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QTV_LamMoiQuanTriVien.ForeColor = System.Drawing.Color.White;
            this.btn_QTV_LamMoiQuanTriVien.Location = new System.Drawing.Point(44, 182);
            this.btn_QTV_LamMoiQuanTriVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_QTV_LamMoiQuanTriVien.Name = "btn_QTV_LamMoiQuanTriVien";
            this.btn_QTV_LamMoiQuanTriVien.Size = new System.Drawing.Size(93, 39);
            this.btn_QTV_LamMoiQuanTriVien.TabIndex = 9;
            this.btn_QTV_LamMoiQuanTriVien.Text = "Làm mới";
            this.btn_QTV_LamMoiQuanTriVien.TextColor = System.Drawing.Color.White;
            this.btn_QTV_LamMoiQuanTriVien.UseVisualStyleBackColor = false;
            this.btn_QTV_LamMoiQuanTriVien.Click += new System.EventHandler(this.btn_QTV_LamMoiQuanTriVien_Click);
            // 
            // btn_QTV_LuuQuanTriVien
            // 
            this.btn_QTV_LuuQuanTriVien.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_LuuQuanTriVien.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_LuuQuanTriVien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_QTV_LuuQuanTriVien.BorderRadius = 25;
            this.btn_QTV_LuuQuanTriVien.BorderSize = 0;
            this.btn_QTV_LuuQuanTriVien.FlatAppearance.BorderSize = 0;
            this.btn_QTV_LuuQuanTriVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QTV_LuuQuanTriVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QTV_LuuQuanTriVien.ForeColor = System.Drawing.Color.White;
            this.btn_QTV_LuuQuanTriVien.Location = new System.Drawing.Point(44, 131);
            this.btn_QTV_LuuQuanTriVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_QTV_LuuQuanTriVien.Name = "btn_QTV_LuuQuanTriVien";
            this.btn_QTV_LuuQuanTriVien.Size = new System.Drawing.Size(93, 39);
            this.btn_QTV_LuuQuanTriVien.TabIndex = 8;
            this.btn_QTV_LuuQuanTriVien.Text = "Lưu";
            this.btn_QTV_LuuQuanTriVien.TextColor = System.Drawing.Color.White;
            this.btn_QTV_LuuQuanTriVien.UseVisualStyleBackColor = false;
            this.btn_QTV_LuuQuanTriVien.Click += new System.EventHandler(this.btn_QTV_LuuQuanTriVien_Click);
            // 
            // btn_QTV_XoaQuanTriVien
            // 
            this.btn_QTV_XoaQuanTriVien.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_XoaQuanTriVien.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_XoaQuanTriVien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_QTV_XoaQuanTriVien.BorderRadius = 25;
            this.btn_QTV_XoaQuanTriVien.BorderSize = 0;
            this.btn_QTV_XoaQuanTriVien.FlatAppearance.BorderSize = 0;
            this.btn_QTV_XoaQuanTriVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QTV_XoaQuanTriVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QTV_XoaQuanTriVien.ForeColor = System.Drawing.Color.White;
            this.btn_QTV_XoaQuanTriVien.Location = new System.Drawing.Point(44, 79);
            this.btn_QTV_XoaQuanTriVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_QTV_XoaQuanTriVien.Name = "btn_QTV_XoaQuanTriVien";
            this.btn_QTV_XoaQuanTriVien.Size = new System.Drawing.Size(93, 39);
            this.btn_QTV_XoaQuanTriVien.TabIndex = 7;
            this.btn_QTV_XoaQuanTriVien.Text = "Xóa";
            this.btn_QTV_XoaQuanTriVien.TextColor = System.Drawing.Color.White;
            this.btn_QTV_XoaQuanTriVien.UseVisualStyleBackColor = false;
            this.btn_QTV_XoaQuanTriVien.Click += new System.EventHandler(this.btn_QTV_XoaQuanTriVien_Click);
            // 
            // btn_QTV_ThemQuanTriVien
            // 
            this.btn_QTV_ThemQuanTriVien.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_ThemQuanTriVien.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_ThemQuanTriVien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_QTV_ThemQuanTriVien.BorderRadius = 25;
            this.btn_QTV_ThemQuanTriVien.BorderSize = 0;
            this.btn_QTV_ThemQuanTriVien.FlatAppearance.BorderSize = 0;
            this.btn_QTV_ThemQuanTriVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QTV_ThemQuanTriVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QTV_ThemQuanTriVien.ForeColor = System.Drawing.Color.White;
            this.btn_QTV_ThemQuanTriVien.Location = new System.Drawing.Point(44, 24);
            this.btn_QTV_ThemQuanTriVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_QTV_ThemQuanTriVien.Name = "btn_QTV_ThemQuanTriVien";
            this.btn_QTV_ThemQuanTriVien.Size = new System.Drawing.Size(93, 39);
            this.btn_QTV_ThemQuanTriVien.TabIndex = 6;
            this.btn_QTV_ThemQuanTriVien.Text = "Thêm";
            this.btn_QTV_ThemQuanTriVien.TextColor = System.Drawing.Color.White;
            this.btn_QTV_ThemQuanTriVien.UseVisualStyleBackColor = false;
            this.btn_QTV_ThemQuanTriVien.Click += new System.EventHandler(this.btn_QTV_ThemQuanTriVien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_QTV_EmailQuanTriVien);
            this.groupBox1.Controls.Add(this.txt_QTV_HoTenQuanTriVien);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_QTV_MatKhauQuanTriVien);
            this.groupBox1.Controls.Add(this.txt_QTV_LoaiTaiKhoanQuanTriVien);
            this.groupBox1.Controls.Add(this.cbb_QTV_ChucVuQuanTriVien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_QTV_IDQuanTriVien);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(77, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(589, 243);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // txt_QTV_EmailQuanTriVien
            // 
            this.txt_QTV_EmailQuanTriVien.Location = new System.Drawing.Point(404, 184);
            this.txt_QTV_EmailQuanTriVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_QTV_EmailQuanTriVien.Multiline = true;
            this.txt_QTV_EmailQuanTriVien.Name = "txt_QTV_EmailQuanTriVien";
            this.txt_QTV_EmailQuanTriVien.Size = new System.Drawing.Size(156, 28);
            this.txt_QTV_EmailQuanTriVien.TabIndex = 42;
            // 
            // txt_QTV_HoTenQuanTriVien
            // 
            this.txt_QTV_HoTenQuanTriVien.Location = new System.Drawing.Point(404, 37);
            this.txt_QTV_HoTenQuanTriVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_QTV_HoTenQuanTriVien.Multiline = true;
            this.txt_QTV_HoTenQuanTriVien.Name = "txt_QTV_HoTenQuanTriVien";
            this.txt_QTV_HoTenQuanTriVien.Size = new System.Drawing.Size(156, 28);
            this.txt_QTV_HoTenQuanTriVien.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mật khẩu";
            // 
            // txt_QTV_MatKhauQuanTriVien
            // 
            this.txt_QTV_MatKhauQuanTriVien.Location = new System.Drawing.Point(125, 111);
            this.txt_QTV_MatKhauQuanTriVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_QTV_MatKhauQuanTriVien.Multiline = true;
            this.txt_QTV_MatKhauQuanTriVien.Name = "txt_QTV_MatKhauQuanTriVien";
            this.txt_QTV_MatKhauQuanTriVien.Size = new System.Drawing.Size(156, 28);
            this.txt_QTV_MatKhauQuanTriVien.TabIndex = 38;
            // 
            // txt_QTV_LoaiTaiKhoanQuanTriVien
            // 
            this.txt_QTV_LoaiTaiKhoanQuanTriVien.Location = new System.Drawing.Point(125, 184);
            this.txt_QTV_LoaiTaiKhoanQuanTriVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_QTV_LoaiTaiKhoanQuanTriVien.Multiline = true;
            this.txt_QTV_LoaiTaiKhoanQuanTriVien.Name = "txt_QTV_LoaiTaiKhoanQuanTriVien";
            this.txt_QTV_LoaiTaiKhoanQuanTriVien.ReadOnly = true;
            this.txt_QTV_LoaiTaiKhoanQuanTriVien.Size = new System.Drawing.Size(156, 28);
            this.txt_QTV_LoaiTaiKhoanQuanTriVien.TabIndex = 37;
            // 
            // cbb_QTV_ChucVuQuanTriVien
            // 
            this.cbb_QTV_ChucVuQuanTriVien.FormattingEnabled = true;
            this.cbb_QTV_ChucVuQuanTriVien.Location = new System.Drawing.Point(404, 111);
            this.cbb_QTV_ChucVuQuanTriVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_QTV_ChucVuQuanTriVien.Name = "cbb_QTV_ChucVuQuanTriVien";
            this.cbb_QTV_ChucVuQuanTriVien.Size = new System.Drawing.Size(156, 27);
            this.cbb_QTV_ChucVuQuanTriVien.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label5.Location = new System.Drawing.Point(323, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label6.Location = new System.Drawing.Point(323, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Loại tài khoản";
            // 
            // txt_QTV_IDQuanTriVien
            // 
            this.txt_QTV_IDQuanTriVien.Location = new System.Drawing.Point(125, 37);
            this.txt_QTV_IDQuanTriVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_QTV_IDQuanTriVien.Multiline = true;
            this.txt_QTV_IDQuanTriVien.Name = "txt_QTV_IDQuanTriVien";
            this.txt_QTV_IDQuanTriVien.Size = new System.Drawing.Size(156, 28);
            this.txt_QTV_IDQuanTriVien.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "ID Nhân viên";
            // 
            // btn_QTV_TimKiemQuanTriVien
            // 
            this.btn_QTV_TimKiemQuanTriVien.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_TimKiemQuanTriVien.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_TimKiemQuanTriVien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_QTV_TimKiemQuanTriVien.BorderRadius = 25;
            this.btn_QTV_TimKiemQuanTriVien.BorderSize = 0;
            this.btn_QTV_TimKiemQuanTriVien.FlatAppearance.BorderSize = 0;
            this.btn_QTV_TimKiemQuanTriVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QTV_TimKiemQuanTriVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QTV_TimKiemQuanTriVien.ForeColor = System.Drawing.Color.White;
            this.btn_QTV_TimKiemQuanTriVien.Location = new System.Drawing.Point(741, 106);
            this.btn_QTV_TimKiemQuanTriVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_QTV_TimKiemQuanTriVien.Name = "btn_QTV_TimKiemQuanTriVien";
            this.btn_QTV_TimKiemQuanTriVien.Size = new System.Drawing.Size(80, 39);
            this.btn_QTV_TimKiemQuanTriVien.TabIndex = 20;
            this.btn_QTV_TimKiemQuanTriVien.Text = "Tìm";
            this.btn_QTV_TimKiemQuanTriVien.TextColor = System.Drawing.Color.White;
            this.btn_QTV_TimKiemQuanTriVien.UseVisualStyleBackColor = false;
            this.btn_QTV_TimKiemQuanTriVien.Click += new System.EventHandler(this.btn_QTV_TimKiemQuanTriVien_Click);
            // 
            // txt_QTV_TimKiemQuanTriVien
            // 
            this.txt_QTV_TimKiemQuanTriVien.Location = new System.Drawing.Point(210, 108);
            this.txt_QTV_TimKiemQuanTriVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_QTV_TimKiemQuanTriVien.Multiline = true;
            this.txt_QTV_TimKiemQuanTriVien.Name = "txt_QTV_TimKiemQuanTriVien";
            this.txt_QTV_TimKiemQuanTriVien.Size = new System.Drawing.Size(518, 33);
            this.txt_QTV_TimKiemQuanTriVien.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tìm kiếm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 100);
            this.panel2.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(196, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN QUẢN TRỊ VIÊN";
            // 
            // frm_QTV_QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_QTV_DanhSachQuanTriVien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_QTV_TimKiemQuanTriVien);
            this.Controls.Add(this.txt_QTV_TimKiemQuanTriVien);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_QTV_QLNV";
            this.Text = "frm_QTV_QLNV";
            this.Load += new System.EventHandler(this.frm_QTV_QLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QTV_DanhSachQuanTriVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_QTV_DanhSachQuanTriVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomControls.RJButton btn_QTV_LamMoiQuanTriVien;
        private CustomControls.RJButton btn_QTV_LuuQuanTriVien;
        private CustomControls.RJButton btn_QTV_XoaQuanTriVien;
        private CustomControls.RJButton btn_QTV_ThemQuanTriVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_QTV_ChucVuQuanTriVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_QTV_IDQuanTriVien;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJButton btn_QTV_TimKiemQuanTriVien;
        private System.Windows.Forms.TextBox txt_QTV_TimKiemQuanTriVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_QTV_LoaiTaiKhoanQuanTriVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_QTV_MatKhauQuanTriVien;
        private System.Windows.Forms.TextBox txt_QTV_EmailQuanTriVien;
        private System.Windows.Forms.TextBox txt_QTV_HoTenQuanTriVien;
        private System.Windows.Forms.Label label8;
    }
}