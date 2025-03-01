namespace QuanLyXeBus.GUI
{
    partial class frm_QTV_QLHS
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
            this.dgv_QTV_DanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_QTV_LamMoi = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_QTV_LuuHocSinh = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_QTV_XoaHocSinh = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_QTV_ThemHocSinh = new QuanLyXeBus.CustomControls.RJButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_QTV_HoTenHocSinh = new System.Windows.Forms.TextBox();
            this.dtp_QTV_NgaySinhHocSinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_QTV_IDPhuHuynhHocSinh = new System.Windows.Forms.ComboBox();
            this.cbb_QTV_LopHocSinh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_QTV_DiaChiHocSinh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_QTV_IDHocSinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_QTV_TimKiemHocSinh = new QuanLyXeBus.CustomControls.RJButton();
            this.txt_QTV_TimKiemHocSinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QTV_DanhSachHocSinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_QTV_DanhSachHocSinh
            // 
            this.dgv_QTV_DanhSachHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_QTV_DanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QTV_DanhSachHocSinh.Location = new System.Drawing.Point(94, 491);
            this.dgv_QTV_DanhSachHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_QTV_DanhSachHocSinh.Name = "dgv_QTV_DanhSachHocSinh";
            this.dgv_QTV_DanhSachHocSinh.RowHeadersWidth = 51;
            this.dgv_QTV_DanhSachHocSinh.RowTemplate.Height = 24;
            this.dgv_QTV_DanhSachHocSinh.Size = new System.Drawing.Size(1064, 206);
            this.dgv_QTV_DanhSachHocSinh.TabIndex = 17;
            this.dgv_QTV_DanhSachHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QTV_DanhSachHocSinh_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_QTV_LamMoi);
            this.groupBox2.Controls.Add(this.btn_QTV_LuuHocSinh);
            this.groupBox2.Controls.Add(this.btn_QTV_XoaHocSinh);
            this.groupBox2.Controls.Add(this.btn_QTV_ThemHocSinh);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(917, 188);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(241, 299);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_QTV_LamMoi
            // 
            this.btn_QTV_LamMoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_LamMoi.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_LamMoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_QTV_LamMoi.BorderRadius = 25;
            this.btn_QTV_LamMoi.BorderSize = 0;
            this.btn_QTV_LamMoi.FlatAppearance.BorderSize = 0;
            this.btn_QTV_LamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QTV_LamMoi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QTV_LamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_QTV_LamMoi.Location = new System.Drawing.Point(59, 224);
            this.btn_QTV_LamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QTV_LamMoi.Name = "btn_QTV_LamMoi";
            this.btn_QTV_LamMoi.Size = new System.Drawing.Size(124, 48);
            this.btn_QTV_LamMoi.TabIndex = 9;
            this.btn_QTV_LamMoi.Text = "Làm mới";
            this.btn_QTV_LamMoi.TextColor = System.Drawing.Color.White;
            this.btn_QTV_LamMoi.UseVisualStyleBackColor = false;
            this.btn_QTV_LamMoi.Click += new System.EventHandler(this.btn_QTV_LamMoi_Click);
            // 
            // btn_QTV_LuuHocSinh
            // 
            this.btn_QTV_LuuHocSinh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_LuuHocSinh.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_LuuHocSinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_QTV_LuuHocSinh.BorderRadius = 25;
            this.btn_QTV_LuuHocSinh.BorderSize = 0;
            this.btn_QTV_LuuHocSinh.FlatAppearance.BorderSize = 0;
            this.btn_QTV_LuuHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QTV_LuuHocSinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QTV_LuuHocSinh.ForeColor = System.Drawing.Color.White;
            this.btn_QTV_LuuHocSinh.Location = new System.Drawing.Point(59, 161);
            this.btn_QTV_LuuHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QTV_LuuHocSinh.Name = "btn_QTV_LuuHocSinh";
            this.btn_QTV_LuuHocSinh.Size = new System.Drawing.Size(124, 48);
            this.btn_QTV_LuuHocSinh.TabIndex = 8;
            this.btn_QTV_LuuHocSinh.Text = "Lưu";
            this.btn_QTV_LuuHocSinh.TextColor = System.Drawing.Color.White;
            this.btn_QTV_LuuHocSinh.UseVisualStyleBackColor = false;
            this.btn_QTV_LuuHocSinh.Click += new System.EventHandler(this.btn_QTV_LuuHocSinh_Click);
            // 
            // btn_QTV_XoaHocSinh
            // 
            this.btn_QTV_XoaHocSinh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_XoaHocSinh.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_XoaHocSinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_QTV_XoaHocSinh.BorderRadius = 25;
            this.btn_QTV_XoaHocSinh.BorderSize = 0;
            this.btn_QTV_XoaHocSinh.FlatAppearance.BorderSize = 0;
            this.btn_QTV_XoaHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QTV_XoaHocSinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QTV_XoaHocSinh.ForeColor = System.Drawing.Color.White;
            this.btn_QTV_XoaHocSinh.Location = new System.Drawing.Point(59, 97);
            this.btn_QTV_XoaHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QTV_XoaHocSinh.Name = "btn_QTV_XoaHocSinh";
            this.btn_QTV_XoaHocSinh.Size = new System.Drawing.Size(124, 48);
            this.btn_QTV_XoaHocSinh.TabIndex = 7;
            this.btn_QTV_XoaHocSinh.Text = "Xóa";
            this.btn_QTV_XoaHocSinh.TextColor = System.Drawing.Color.White;
            this.btn_QTV_XoaHocSinh.UseVisualStyleBackColor = false;
            this.btn_QTV_XoaHocSinh.Click += new System.EventHandler(this.btn_QTV_XoaHocSinh_Click);
            // 
            // btn_QTV_ThemHocSinh
            // 
            this.btn_QTV_ThemHocSinh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_ThemHocSinh.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_ThemHocSinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_QTV_ThemHocSinh.BorderRadius = 25;
            this.btn_QTV_ThemHocSinh.BorderSize = 0;
            this.btn_QTV_ThemHocSinh.FlatAppearance.BorderSize = 0;
            this.btn_QTV_ThemHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QTV_ThemHocSinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QTV_ThemHocSinh.ForeColor = System.Drawing.Color.White;
            this.btn_QTV_ThemHocSinh.Location = new System.Drawing.Point(59, 30);
            this.btn_QTV_ThemHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QTV_ThemHocSinh.Name = "btn_QTV_ThemHocSinh";
            this.btn_QTV_ThemHocSinh.Size = new System.Drawing.Size(124, 48);
            this.btn_QTV_ThemHocSinh.TabIndex = 6;
            this.btn_QTV_ThemHocSinh.Text = "Thêm";
            this.btn_QTV_ThemHocSinh.TextColor = System.Drawing.Color.White;
            this.btn_QTV_ThemHocSinh.UseVisualStyleBackColor = false;
            this.btn_QTV_ThemHocSinh.Click += new System.EventHandler(this.btn_QTV_ThemHocSinh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_QTV_HoTenHocSinh);
            this.groupBox1.Controls.Add(this.dtp_QTV_NgaySinhHocSinh);
            this.groupBox1.Controls.Add(this.cbb_QTV_IDPhuHuynhHocSinh);
            this.groupBox1.Controls.Add(this.cbb_QTV_LopHocSinh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_QTV_DiaChiHocSinh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_QTV_IDHocSinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(94, 183);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(785, 299);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // txt_QTV_HoTenHocSinh
            // 
            this.txt_QTV_HoTenHocSinh.Location = new System.Drawing.Point(182, 138);
            this.txt_QTV_HoTenHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_QTV_HoTenHocSinh.Multiline = true;
            this.txt_QTV_HoTenHocSinh.Name = "txt_QTV_HoTenHocSinh";
            this.txt_QTV_HoTenHocSinh.Size = new System.Drawing.Size(192, 34);
            this.txt_QTV_HoTenHocSinh.TabIndex = 38;
            // 
            // dtp_QTV_NgaySinhHocSinh
            // 
            this.dtp_QTV_NgaySinhHocSinh.Location = new System.Drawing.Point(182, 225);
            this.dtp_QTV_NgaySinhHocSinh.Name = "dtp_QTV_NgaySinhHocSinh";
            this.dtp_QTV_NgaySinhHocSinh.Size = new System.Drawing.Size(192, 30);
            this.dtp_QTV_NgaySinhHocSinh.TabIndex = 37;
            // 
            // cbb_QTV_IDPhuHuynhHocSinh
            // 
            this.cbb_QTV_IDPhuHuynhHocSinh.FormattingEnabled = true;
            this.cbb_QTV_IDPhuHuynhHocSinh.Location = new System.Drawing.Point(557, 138);
            this.cbb_QTV_IDPhuHuynhHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_QTV_IDPhuHuynhHocSinh.Name = "cbb_QTV_IDPhuHuynhHocSinh";
            this.cbb_QTV_IDPhuHuynhHocSinh.Size = new System.Drawing.Size(192, 31);
            this.cbb_QTV_IDPhuHuynhHocSinh.TabIndex = 36;
            // 
            // cbb_QTV_LopHocSinh
            // 
            this.cbb_QTV_LopHocSinh.FormattingEnabled = true;
            this.cbb_QTV_LopHocSinh.Location = new System.Drawing.Point(557, 225);
            this.cbb_QTV_LopHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_QTV_LopHocSinh.Name = "cbb_QTV_LopHocSinh";
            this.cbb_QTV_LopHocSinh.Size = new System.Drawing.Size(192, 31);
            this.cbb_QTV_LopHocSinh.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Họ và tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label5.Location = new System.Drawing.Point(428, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label6.Location = new System.Drawing.Point(428, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Phụ huynh";
            // 
            // txt_QTV_DiaChiHocSinh
            // 
            this.txt_QTV_DiaChiHocSinh.Location = new System.Drawing.Point(557, 46);
            this.txt_QTV_DiaChiHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_QTV_DiaChiHocSinh.Multiline = true;
            this.txt_QTV_DiaChiHocSinh.Name = "txt_QTV_DiaChiHocSinh";
            this.txt_QTV_DiaChiHocSinh.Size = new System.Drawing.Size(192, 34);
            this.txt_QTV_DiaChiHocSinh.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label8.Location = new System.Drawing.Point(428, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Địa chi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ngày sinh";
            // 
            // txt_QTV_IDHocSinh
            // 
            this.txt_QTV_IDHocSinh.Location = new System.Drawing.Point(182, 46);
            this.txt_QTV_IDHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_QTV_IDHocSinh.Multiline = true;
            this.txt_QTV_IDHocSinh.Name = "txt_QTV_IDHocSinh";
            this.txt_QTV_IDHocSinh.Size = new System.Drawing.Size(192, 34);
            this.txt_QTV_IDHocSinh.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "ID Học sinh";
            // 
            // btn_QTV_TimKiemHocSinh
            // 
            this.btn_QTV_TimKiemHocSinh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_TimKiemHocSinh.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_QTV_TimKiemHocSinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_QTV_TimKiemHocSinh.BorderRadius = 25;
            this.btn_QTV_TimKiemHocSinh.BorderSize = 0;
            this.btn_QTV_TimKiemHocSinh.FlatAppearance.BorderSize = 0;
            this.btn_QTV_TimKiemHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QTV_TimKiemHocSinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QTV_TimKiemHocSinh.ForeColor = System.Drawing.Color.White;
            this.btn_QTV_TimKiemHocSinh.Location = new System.Drawing.Point(984, 120);
            this.btn_QTV_TimKiemHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QTV_TimKiemHocSinh.Name = "btn_QTV_TimKiemHocSinh";
            this.btn_QTV_TimKiemHocSinh.Size = new System.Drawing.Size(107, 48);
            this.btn_QTV_TimKiemHocSinh.TabIndex = 14;
            this.btn_QTV_TimKiemHocSinh.Text = "Tìm";
            this.btn_QTV_TimKiemHocSinh.TextColor = System.Drawing.Color.White;
            this.btn_QTV_TimKiemHocSinh.UseVisualStyleBackColor = false;
            this.btn_QTV_TimKiemHocSinh.Click += new System.EventHandler(this.btn_QTV_TimKiemHocSinh_Click);
            // 
            // txt_QTV_TimKiemHocSinh
            // 
            this.txt_QTV_TimKiemHocSinh.Location = new System.Drawing.Point(276, 123);
            this.txt_QTV_TimKiemHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_QTV_TimKiemHocSinh.Multiline = true;
            this.txt_QTV_TimKiemHocSinh.Name = "txt_QTV_TimKiemHocSinh";
            this.txt_QTV_TimKiemHocSinh.Size = new System.Drawing.Size(689, 40);
            this.txt_QTV_TimKiemHocSinh.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(316, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ DANH SÁCH HỌC SINH";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1642, 100);
            this.panel2.TabIndex = 19;
            // 
            // frm_QTV_QLHS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1271, 758);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_QTV_DanhSachHocSinh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_QTV_TimKiemHocSinh);
            this.Controls.Add(this.txt_QTV_TimKiemHocSinh);
            this.Controls.Add(this.label2);
            this.Name = "frm_QTV_QLHS";
            this.Text = "frm_QTV_QLHS";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QTV_DanhSachHocSinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_QTV_DanhSachHocSinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomControls.RJButton btn_QTV_LamMoi;
        private CustomControls.RJButton btn_QTV_LuuHocSinh;
        private CustomControls.RJButton btn_QTV_XoaHocSinh;
        private CustomControls.RJButton btn_QTV_ThemHocSinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_QTV_LopHocSinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_QTV_DiaChiHocSinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_QTV_IDHocSinh;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJButton btn_QTV_TimKiemHocSinh;
        private System.Windows.Forms.TextBox txt_QTV_TimKiemHocSinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbb_QTV_IDPhuHuynhHocSinh;
        private System.Windows.Forms.DateTimePicker dtp_QTV_NgaySinhHocSinh;
        private System.Windows.Forms.TextBox txt_QTV_HoTenHocSinh;
    }
}