namespace QuanLyXeBus.view
{
    partial class frm_TX_DiemDanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_thGian = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TX_BienSoXe = new System.Windows.Forms.TextBox();
            this.txt_TX_IDDiemDanh = new System.Windows.Forms.TextBox();
            this.lb_TX_thGianDD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chb_DiemDanhVe = new System.Windows.Forms.CheckBox();
            this.chb_DiemDanhDi = new System.Windows.Forms.CheckBox();
            this.lb_TX_GioXuongXe = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_TX_GioLenXe = new System.Windows.Forms.Label();
            this.cbb_TX_DiemXuongXe = new System.Windows.Forms.ComboBox();
            this.cbb_TX_DiemLenXe = new System.Windows.Forms.ComboBox();
            this.cbb_TX_HocSinh = new System.Windows.Forms.ComboBox();
            this.txt_TX_ChiTietDiemDanhID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_TX_DiemDanhHocSinh = new System.Windows.Forms.DataGridView();
            this.btn_TX_CapNhatDanhSach = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_TX_Xoa = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_TX_Vang = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_TX_CapNhat = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_TX_DiemDanh = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_TX_LamMoi = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_TX_TaoMoiID = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_TX_XoaDD = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_TX_HoanThanh = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_TX_LuuLaiDD = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_TX_LamMoiDD = new QuanLyXeBus.CustomControls.RJButton();
            this.btn_TX_TaoMoi = new QuanLyXeBus.CustomControls.RJButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TX_DiemDanhHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày:";
            // 
            // lb_thGian
            // 
            this.lb_thGian.AutoSize = true;
            this.lb_thGian.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lb_thGian.Location = new System.Drawing.Point(87, 27);
            this.lb_thGian.Name = "lb_thGian";
            this.lb_thGian.Size = new System.Drawing.Size(67, 19);
            this.lb_thGian.TabIndex = 1;
            this.lb_thGian.Text = "ddmmyy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TX_XoaDD);
            this.groupBox1.Controls.Add(this.btn_TX_HoanThanh);
            this.groupBox1.Controls.Add(this.btn_TX_LuuLaiDD);
            this.groupBox1.Controls.Add(this.btn_TX_LamMoiDD);
            this.groupBox1.Controls.Add(this.btn_TX_TaoMoi);
            this.groupBox1.Controls.Add(this.txt_TX_BienSoXe);
            this.groupBox1.Controls.Add(this.txt_TX_IDDiemDanh);
            this.groupBox1.Controls.Add(this.lb_TX_thGianDD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm danh";
            // 
            // txt_TX_BienSoXe
            // 
            this.txt_TX_BienSoXe.Location = new System.Drawing.Point(186, 81);
            this.txt_TX_BienSoXe.Multiline = true;
            this.txt_TX_BienSoXe.Name = "txt_TX_BienSoXe";
            this.txt_TX_BienSoXe.Size = new System.Drawing.Size(245, 26);
            this.txt_TX_BienSoXe.TabIndex = 8;
            // 
            // txt_TX_IDDiemDanh
            // 
            this.txt_TX_IDDiemDanh.Location = new System.Drawing.Point(186, 36);
            this.txt_TX_IDDiemDanh.Multiline = true;
            this.txt_TX_IDDiemDanh.Name = "txt_TX_IDDiemDanh";
            this.txt_TX_IDDiemDanh.Size = new System.Drawing.Size(245, 26);
            this.txt_TX_IDDiemDanh.TabIndex = 7;
            // 
            // lb_TX_thGianDD
            // 
            this.lb_TX_thGianDD.AutoSize = true;
            this.lb_TX_thGianDD.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.lb_TX_thGianDD.Location = new System.Drawing.Point(182, 122);
            this.lb_TX_thGianDD.Name = "lb_TX_thGianDD";
            this.lb_TX_thGianDD.Size = new System.Drawing.Size(73, 20);
            this.lb_TX_thGianDD.TabIndex = 6;
            this.lb_TX_thGianDD.Text = "ddmmyy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày điểm danh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Biển số xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label3.Location = new System.Drawing.Point(27, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Điểm danh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chb_DiemDanhVe);
            this.groupBox2.Controls.Add(this.chb_DiemDanhDi);
            this.groupBox2.Controls.Add(this.btn_TX_Xoa);
            this.groupBox2.Controls.Add(this.btn_TX_Vang);
            this.groupBox2.Controls.Add(this.btn_TX_CapNhat);
            this.groupBox2.Controls.Add(this.btn_TX_DiemDanh);
            this.groupBox2.Controls.Add(this.btn_TX_LamMoi);
            this.groupBox2.Controls.Add(this.btn_TX_TaoMoiID);
            this.groupBox2.Controls.Add(this.lb_TX_GioXuongXe);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lb_TX_GioLenXe);
            this.groupBox2.Controls.Add(this.cbb_TX_DiemXuongXe);
            this.groupBox2.Controls.Add(this.cbb_TX_DiemLenXe);
            this.groupBox2.Controls.Add(this.cbb_TX_HocSinh);
            this.groupBox2.Controls.Add(this.txt_TX_ChiTietDiemDanhID);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(595, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 346);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết điểm danh";
            // 
            // chb_DiemDanhVe
            // 
            this.chb_DiemDanhVe.AutoSize = true;
            this.chb_DiemDanhVe.Location = new System.Drawing.Point(194, 301);
            this.chb_DiemDanhVe.Name = "chb_DiemDanhVe";
            this.chb_DiemDanhVe.Size = new System.Drawing.Size(138, 24);
            this.chb_DiemDanhVe.TabIndex = 33;
            this.chb_DiemDanhVe.Text = "Điểm danh về";
            this.chb_DiemDanhVe.UseVisualStyleBackColor = true;
            this.chb_DiemDanhVe.CheckedChanged += new System.EventHandler(this.chb_DiemDanhVe_CheckedChanged);
            // 
            // chb_DiemDanhDi
            // 
            this.chb_DiemDanhDi.AutoSize = true;
            this.chb_DiemDanhDi.Location = new System.Drawing.Point(29, 301);
            this.chb_DiemDanhDi.Name = "chb_DiemDanhDi";
            this.chb_DiemDanhDi.Size = new System.Drawing.Size(136, 24);
            this.chb_DiemDanhDi.TabIndex = 32;
            this.chb_DiemDanhDi.Text = "Điểm danh đi";
            this.chb_DiemDanhDi.UseVisualStyleBackColor = true;
            this.chb_DiemDanhDi.CheckedChanged += new System.EventHandler(this.chb_DiemDanhDi_CheckedChanged);
            // 
            // lb_TX_GioXuongXe
            // 
            this.lb_TX_GioXuongXe.AutoSize = true;
            this.lb_TX_GioXuongXe.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.lb_TX_GioXuongXe.Location = new System.Drawing.Point(239, 239);
            this.lb_TX_GioXuongXe.Name = "lb_TX_GioXuongXe";
            this.lb_TX_GioXuongXe.Size = new System.Drawing.Size(49, 20);
            this.lb_TX_GioXuongXe.TabIndex = 26;
            this.lb_TX_GioXuongXe.Text = "00:00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label14.Location = new System.Drawing.Point(239, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 20);
            this.label14.TabIndex = 25;
            // 
            // lb_TX_GioLenXe
            // 
            this.lb_TX_GioLenXe.AutoSize = true;
            this.lb_TX_GioLenXe.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.lb_TX_GioLenXe.Location = new System.Drawing.Point(239, 201);
            this.lb_TX_GioLenXe.Name = "lb_TX_GioLenXe";
            this.lb_TX_GioLenXe.Size = new System.Drawing.Size(49, 20);
            this.lb_TX_GioLenXe.TabIndex = 24;
            this.lb_TX_GioLenXe.Text = "00:00";
            // 
            // cbb_TX_DiemXuongXe
            // 
            this.cbb_TX_DiemXuongXe.FormattingEnabled = true;
            this.cbb_TX_DiemXuongXe.Location = new System.Drawing.Point(243, 164);
            this.cbb_TX_DiemXuongXe.Name = "cbb_TX_DiemXuongXe";
            this.cbb_TX_DiemXuongXe.Size = new System.Drawing.Size(245, 28);
            this.cbb_TX_DiemXuongXe.TabIndex = 23;
            // 
            // cbb_TX_DiemLenXe
            // 
            this.cbb_TX_DiemLenXe.FormattingEnabled = true;
            this.cbb_TX_DiemLenXe.Location = new System.Drawing.Point(243, 127);
            this.cbb_TX_DiemLenXe.Name = "cbb_TX_DiemLenXe";
            this.cbb_TX_DiemLenXe.Size = new System.Drawing.Size(245, 28);
            this.cbb_TX_DiemLenXe.TabIndex = 22;
            this.cbb_TX_DiemLenXe.SelectedIndexChanged += new System.EventHandler(this.cbb_TX_DiemLenXe_SelectedIndexChanged);
            // 
            // cbb_TX_HocSinh
            // 
            this.cbb_TX_HocSinh.FormattingEnabled = true;
            this.cbb_TX_HocSinh.Location = new System.Drawing.Point(243, 86);
            this.cbb_TX_HocSinh.Name = "cbb_TX_HocSinh";
            this.cbb_TX_HocSinh.Size = new System.Drawing.Size(245, 28);
            this.cbb_TX_HocSinh.TabIndex = 21;
            // 
            // txt_TX_ChiTietDiemDanhID
            // 
            this.txt_TX_ChiTietDiemDanhID.Location = new System.Drawing.Point(243, 34);
            this.txt_TX_ChiTietDiemDanhID.Multiline = true;
            this.txt_TX_ChiTietDiemDanhID.Name = "txt_TX_ChiTietDiemDanhID";
            this.txt_TX_ChiTietDiemDanhID.Size = new System.Drawing.Size(245, 33);
            this.txt_TX_ChiTietDiemDanhID.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label12.Location = new System.Drawing.Point(25, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Giờ xuống xe:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label11.Location = new System.Drawing.Point(25, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Giờ lên xe:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label10.Location = new System.Drawing.Point(25, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Điểm xuống xe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label9.Location = new System.Drawing.Point(25, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Điểm lên xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label8.Location = new System.Drawing.Point(25, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Học sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label7.Location = new System.Drawing.Point(25, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Chi tiết điểm danh ID";
            // 
            // dgv_TX_DiemDanhHocSinh
            // 
            this.dgv_TX_DiemDanhHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TX_DiemDanhHocSinh.Location = new System.Drawing.Point(38, 465);
            this.dgv_TX_DiemDanhHocSinh.Name = "dgv_TX_DiemDanhHocSinh";
            this.dgv_TX_DiemDanhHocSinh.RowHeadersWidth = 51;
            this.dgv_TX_DiemDanhHocSinh.RowTemplate.Height = 24;
            this.dgv_TX_DiemDanhHocSinh.Size = new System.Drawing.Size(1155, 259);
            this.dgv_TX_DiemDanhHocSinh.TabIndex = 4;
            this.dgv_TX_DiemDanhHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TX_DiemDanhHocSinh_CellClick);
            // 
            // btn_TX_CapNhatDanhSach
            // 
            this.btn_TX_CapNhatDanhSach.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_CapNhatDanhSach.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_CapNhatDanhSach.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TX_CapNhatDanhSach.BorderRadius = 35;
            this.btn_TX_CapNhatDanhSach.BorderSize = 0;
            this.btn_TX_CapNhatDanhSach.FlatAppearance.BorderSize = 0;
            this.btn_TX_CapNhatDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TX_CapNhatDanhSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TX_CapNhatDanhSach.ForeColor = System.Drawing.Color.White;
            this.btn_TX_CapNhatDanhSach.Location = new System.Drawing.Point(1233, 474);
            this.btn_TX_CapNhatDanhSach.Name = "btn_TX_CapNhatDanhSach";
            this.btn_TX_CapNhatDanhSach.Size = new System.Drawing.Size(201, 75);
            this.btn_TX_CapNhatDanhSach.TabIndex = 25;
            this.btn_TX_CapNhatDanhSach.Text = "Cập nhật danh sách";
            this.btn_TX_CapNhatDanhSach.TextColor = System.Drawing.Color.White;
            this.btn_TX_CapNhatDanhSach.UseVisualStyleBackColor = false;
            this.btn_TX_CapNhatDanhSach.Click += new System.EventHandler(this.btn_TX_CapNhatDanhSach_Click);
            // 
            // btn_TX_Xoa
            // 
            this.btn_TX_Xoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_Xoa.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_Xoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TX_Xoa.BorderRadius = 20;
            this.btn_TX_Xoa.BorderSize = 0;
            this.btn_TX_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_TX_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TX_Xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TX_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_TX_Xoa.Location = new System.Drawing.Point(556, 301);
            this.btn_TX_Xoa.Name = "btn_TX_Xoa";
            this.btn_TX_Xoa.Size = new System.Drawing.Size(141, 44);
            this.btn_TX_Xoa.TabIndex = 31;
            this.btn_TX_Xoa.Text = "Xóa";
            this.btn_TX_Xoa.TextColor = System.Drawing.Color.White;
            this.btn_TX_Xoa.UseVisualStyleBackColor = false;
            this.btn_TX_Xoa.Click += new System.EventHandler(this.btn_TX_Xoa_Click);
            // 
            // btn_TX_Vang
            // 
            this.btn_TX_Vang.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_Vang.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_Vang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TX_Vang.BorderRadius = 20;
            this.btn_TX_Vang.BorderSize = 0;
            this.btn_TX_Vang.FlatAppearance.BorderSize = 0;
            this.btn_TX_Vang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TX_Vang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TX_Vang.ForeColor = System.Drawing.Color.White;
            this.btn_TX_Vang.Location = new System.Drawing.Point(556, 239);
            this.btn_TX_Vang.Name = "btn_TX_Vang";
            this.btn_TX_Vang.Size = new System.Drawing.Size(141, 44);
            this.btn_TX_Vang.TabIndex = 30;
            this.btn_TX_Vang.Text = "Vắng";
            this.btn_TX_Vang.TextColor = System.Drawing.Color.White;
            this.btn_TX_Vang.UseVisualStyleBackColor = false;
            this.btn_TX_Vang.Click += new System.EventHandler(this.btn_TX_Vang_Click);
            // 
            // btn_TX_CapNhat
            // 
            this.btn_TX_CapNhat.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_CapNhat.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_CapNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TX_CapNhat.BorderRadius = 20;
            this.btn_TX_CapNhat.BorderSize = 0;
            this.btn_TX_CapNhat.FlatAppearance.BorderSize = 0;
            this.btn_TX_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TX_CapNhat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TX_CapNhat.ForeColor = System.Drawing.Color.White;
            this.btn_TX_CapNhat.Location = new System.Drawing.Point(556, 177);
            this.btn_TX_CapNhat.Name = "btn_TX_CapNhat";
            this.btn_TX_CapNhat.Size = new System.Drawing.Size(141, 44);
            this.btn_TX_CapNhat.TabIndex = 29;
            this.btn_TX_CapNhat.Text = "Cập nhật";
            this.btn_TX_CapNhat.TextColor = System.Drawing.Color.White;
            this.btn_TX_CapNhat.UseVisualStyleBackColor = false;
            this.btn_TX_CapNhat.Click += new System.EventHandler(this.btn_TX_CapNhat_Click);
            // 
            // btn_TX_DiemDanh
            // 
            this.btn_TX_DiemDanh.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_DiemDanh.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_DiemDanh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TX_DiemDanh.BorderRadius = 20;
            this.btn_TX_DiemDanh.BorderSize = 0;
            this.btn_TX_DiemDanh.FlatAppearance.BorderSize = 0;
            this.btn_TX_DiemDanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TX_DiemDanh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TX_DiemDanh.ForeColor = System.Drawing.Color.White;
            this.btn_TX_DiemDanh.Location = new System.Drawing.Point(556, 127);
            this.btn_TX_DiemDanh.Name = "btn_TX_DiemDanh";
            this.btn_TX_DiemDanh.Size = new System.Drawing.Size(141, 44);
            this.btn_TX_DiemDanh.TabIndex = 28;
            this.btn_TX_DiemDanh.Text = "Điểm danh";
            this.btn_TX_DiemDanh.TextColor = System.Drawing.Color.White;
            this.btn_TX_DiemDanh.UseVisualStyleBackColor = false;
            this.btn_TX_DiemDanh.Click += new System.EventHandler(this.btn_TX_DiemDanh_Click);
            // 
            // btn_TX_LamMoi
            // 
            this.btn_TX_LamMoi.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_LamMoi.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_LamMoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TX_LamMoi.BorderRadius = 20;
            this.btn_TX_LamMoi.BorderSize = 0;
            this.btn_TX_LamMoi.FlatAppearance.BorderSize = 0;
            this.btn_TX_LamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TX_LamMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TX_LamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_TX_LamMoi.Location = new System.Drawing.Point(556, 77);
            this.btn_TX_LamMoi.Name = "btn_TX_LamMoi";
            this.btn_TX_LamMoi.Size = new System.Drawing.Size(141, 44);
            this.btn_TX_LamMoi.TabIndex = 27;
            this.btn_TX_LamMoi.Text = "Làm mới";
            this.btn_TX_LamMoi.TextColor = System.Drawing.Color.White;
            this.btn_TX_LamMoi.UseVisualStyleBackColor = false;
            this.btn_TX_LamMoi.Click += new System.EventHandler(this.btn_TX_LamMoi_Click);
            // 
            // btn_TX_TaoMoiID
            // 
            this.btn_TX_TaoMoiID.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_TaoMoiID.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_TaoMoiID.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TX_TaoMoiID.BorderRadius = 20;
            this.btn_TX_TaoMoiID.BorderSize = 0;
            this.btn_TX_TaoMoiID.FlatAppearance.BorderSize = 0;
            this.btn_TX_TaoMoiID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TX_TaoMoiID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TX_TaoMoiID.ForeColor = System.Drawing.Color.White;
            this.btn_TX_TaoMoiID.Location = new System.Drawing.Point(556, 25);
            this.btn_TX_TaoMoiID.Name = "btn_TX_TaoMoiID";
            this.btn_TX_TaoMoiID.Size = new System.Drawing.Size(141, 44);
            this.btn_TX_TaoMoiID.TabIndex = 20;
            this.btn_TX_TaoMoiID.Text = "Tạo mới ID";
            this.btn_TX_TaoMoiID.TextColor = System.Drawing.Color.White;
            this.btn_TX_TaoMoiID.UseVisualStyleBackColor = false;
            this.btn_TX_TaoMoiID.Click += new System.EventHandler(this.btn_TX_TaoMoiID_Click);
            // 
            // btn_TX_XoaDD
            // 
            this.btn_TX_XoaDD.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_XoaDD.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_XoaDD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TX_XoaDD.BorderRadius = 20;
            this.btn_TX_XoaDD.BorderSize = 0;
            this.btn_TX_XoaDD.FlatAppearance.BorderSize = 0;
            this.btn_TX_XoaDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TX_XoaDD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TX_XoaDD.ForeColor = System.Drawing.Color.White;
            this.btn_TX_XoaDD.Location = new System.Drawing.Point(260, 227);
            this.btn_TX_XoaDD.Name = "btn_TX_XoaDD";
            this.btn_TX_XoaDD.Size = new System.Drawing.Size(141, 44);
            this.btn_TX_XoaDD.TabIndex = 19;
            this.btn_TX_XoaDD.Text = "Xóa";
            this.btn_TX_XoaDD.TextColor = System.Drawing.Color.White;
            this.btn_TX_XoaDD.UseVisualStyleBackColor = false;
            this.btn_TX_XoaDD.Click += new System.EventHandler(this.btn_TX_XoaDD_Click);
            // 
            // btn_TX_HoanThanh
            // 
            this.btn_TX_HoanThanh.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_HoanThanh.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_HoanThanh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TX_HoanThanh.BorderRadius = 20;
            this.btn_TX_HoanThanh.BorderSize = 0;
            this.btn_TX_HoanThanh.FlatAppearance.BorderSize = 0;
            this.btn_TX_HoanThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TX_HoanThanh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TX_HoanThanh.ForeColor = System.Drawing.Color.White;
            this.btn_TX_HoanThanh.Location = new System.Drawing.Point(94, 227);
            this.btn_TX_HoanThanh.Name = "btn_TX_HoanThanh";
            this.btn_TX_HoanThanh.Size = new System.Drawing.Size(141, 44);
            this.btn_TX_HoanThanh.TabIndex = 18;
            this.btn_TX_HoanThanh.Text = "Hoàn thành";
            this.btn_TX_HoanThanh.TextColor = System.Drawing.Color.White;
            this.btn_TX_HoanThanh.UseVisualStyleBackColor = false;
            this.btn_TX_HoanThanh.Click += new System.EventHandler(this.btn_TX_HoanThanh_Click);
            // 
            // btn_TX_LuuLaiDD
            // 
            this.btn_TX_LuuLaiDD.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_LuuLaiDD.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_LuuLaiDD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TX_LuuLaiDD.BorderRadius = 20;
            this.btn_TX_LuuLaiDD.BorderSize = 0;
            this.btn_TX_LuuLaiDD.FlatAppearance.BorderSize = 0;
            this.btn_TX_LuuLaiDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TX_LuuLaiDD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TX_LuuLaiDD.ForeColor = System.Drawing.Color.White;
            this.btn_TX_LuuLaiDD.Location = new System.Drawing.Point(314, 177);
            this.btn_TX_LuuLaiDD.Name = "btn_TX_LuuLaiDD";
            this.btn_TX_LuuLaiDD.Size = new System.Drawing.Size(141, 44);
            this.btn_TX_LuuLaiDD.TabIndex = 17;
            this.btn_TX_LuuLaiDD.Text = "Lưu lại";
            this.btn_TX_LuuLaiDD.TextColor = System.Drawing.Color.White;
            this.btn_TX_LuuLaiDD.UseVisualStyleBackColor = false;
            this.btn_TX_LuuLaiDD.Click += new System.EventHandler(this.btn_TX_LuuLaiDD_Click);
            // 
            // btn_TX_LamMoiDD
            // 
            this.btn_TX_LamMoiDD.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_LamMoiDD.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_LamMoiDD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TX_LamMoiDD.BorderRadius = 20;
            this.btn_TX_LamMoiDD.BorderSize = 0;
            this.btn_TX_LamMoiDD.FlatAppearance.BorderSize = 0;
            this.btn_TX_LamMoiDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TX_LamMoiDD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TX_LamMoiDD.ForeColor = System.Drawing.Color.White;
            this.btn_TX_LamMoiDD.Location = new System.Drawing.Point(167, 177);
            this.btn_TX_LamMoiDD.Name = "btn_TX_LamMoiDD";
            this.btn_TX_LamMoiDD.Size = new System.Drawing.Size(141, 44);
            this.btn_TX_LamMoiDD.TabIndex = 16;
            this.btn_TX_LamMoiDD.Text = "Làm mới";
            this.btn_TX_LamMoiDD.TextColor = System.Drawing.Color.White;
            this.btn_TX_LamMoiDD.UseVisualStyleBackColor = false;
            this.btn_TX_LamMoiDD.Click += new System.EventHandler(this.btn_TX_LamMoiDD_Click);
            // 
            // btn_TX_TaoMoi
            // 
            this.btn_TX_TaoMoi.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_TaoMoi.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_TX_TaoMoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TX_TaoMoi.BorderRadius = 20;
            this.btn_TX_TaoMoi.BorderSize = 0;
            this.btn_TX_TaoMoi.FlatAppearance.BorderSize = 0;
            this.btn_TX_TaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TX_TaoMoi.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.btn_TX_TaoMoi.ForeColor = System.Drawing.Color.White;
            this.btn_TX_TaoMoi.Location = new System.Drawing.Point(20, 177);
            this.btn_TX_TaoMoi.Name = "btn_TX_TaoMoi";
            this.btn_TX_TaoMoi.Size = new System.Drawing.Size(141, 44);
            this.btn_TX_TaoMoi.TabIndex = 15;
            this.btn_TX_TaoMoi.Text = "Tạo mới";
            this.btn_TX_TaoMoi.TextColor = System.Drawing.Color.White;
            this.btn_TX_TaoMoi.UseVisualStyleBackColor = false;
            this.btn_TX_TaoMoi.Click += new System.EventHandler(this.btn_TX_TaoMoi_Click);
            // 
            // frm_TX_DiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 736);
            this.Controls.Add(this.btn_TX_CapNhatDanhSach);
            this.Controls.Add(this.dgv_TX_DiemDanhHocSinh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_thGian);
            this.Controls.Add(this.label1);
            this.Name = "frm_TX_DiemDanh";
            this.Text = "frm_TX_DiemDanh";
            this.Load += new System.EventHandler(this.frm_TX_DiemDanh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TX_DiemDanhHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_thGian;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_TX_thGianDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TX_BienSoXe;
        private System.Windows.Forms.TextBox txt_TX_IDDiemDanh;
        private CustomControls.RJButton btn_TX_TaoMoi;
        private CustomControls.RJButton btn_TX_XoaDD;
        private CustomControls.RJButton btn_TX_HoanThanh;
        private CustomControls.RJButton btn_TX_LuuLaiDD;
        private CustomControls.RJButton btn_TX_LamMoiDD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_TX_ChiTietDiemDanhID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_TX_GioLenXe;
        private System.Windows.Forms.ComboBox cbb_TX_DiemXuongXe;
        private System.Windows.Forms.ComboBox cbb_TX_DiemLenXe;
        private System.Windows.Forms.ComboBox cbb_TX_HocSinh;
        private CustomControls.RJButton btn_TX_Xoa;
        private CustomControls.RJButton btn_TX_Vang;
        private CustomControls.RJButton btn_TX_CapNhat;
        private CustomControls.RJButton btn_TX_DiemDanh;
        private CustomControls.RJButton btn_TX_LamMoi;
        private CustomControls.RJButton btn_TX_TaoMoiID;
        private System.Windows.Forms.Label lb_TX_GioXuongXe;
        private System.Windows.Forms.DataGridView dgv_TX_DiemDanhHocSinh;
        private CustomControls.RJButton btn_TX_CapNhatDanhSach;
        private System.Windows.Forms.CheckBox chb_DiemDanhVe;
        private System.Windows.Forms.CheckBox chb_DiemDanhDi;
    }
}