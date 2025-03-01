namespace QuanLyXeBus.view
{
    partial class frm_QTV_XTK
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
            this.btn_ThongkeTheoHocSinh = new System.Windows.Forms.Button();
            this.cbb_HocSInh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_TenLopHoc = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Picker_MMdd = new System.Windows.Forms.DateTimePicker();
            this.cbb_MaTaiXe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ThongkeTheoTaiXe = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Tu_ddMMyyyy = new System.Windows.Forms.DateTimePicker();
            this.cbb_BienSoXe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_XTK_BS_HS_tuan = new System.Windows.Forms.Button();
            this.Den_ddMMyyyy = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ThongkeTheoHocSinh
            // 
            this.btn_ThongkeTheoHocSinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ThongkeTheoHocSinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongkeTheoHocSinh.Location = new System.Drawing.Point(79, 176);
            this.btn_ThongkeTheoHocSinh.Name = "btn_ThongkeTheoHocSinh";
            this.btn_ThongkeTheoHocSinh.Size = new System.Drawing.Size(254, 34);
            this.btn_ThongkeTheoHocSinh.TabIndex = 0;
            this.btn_ThongkeTheoHocSinh.Text = "Xuất thống kê";
            this.btn_ThongkeTheoHocSinh.UseVisualStyleBackColor = false;
            this.btn_ThongkeTheoHocSinh.Click += new System.EventHandler(this.btn_ThongkeTheoHocSinh_Click);
            // 
            // cbb_HocSInh
            // 
            this.cbb_HocSInh.FormattingEnabled = true;
            this.cbb_HocSInh.Location = new System.Drawing.Point(158, 118);
            this.cbb_HocSInh.Name = "cbb_HocSInh";
            this.cbb_HocSInh.Size = new System.Drawing.Size(253, 27);
            this.cbb_HocSInh.TabIndex = 1;
            this.cbb_HocSInh.DropDown += new System.EventHandler(this.cbb_HocSInh_DropDown);
            this.cbb_HocSInh.SelectedIndexChanged += new System.EventHandler(this.cbb_HocSInh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Lớp học";
            // 
            // cbb_TenLopHoc
            // 
            this.cbb_TenLopHoc.FormattingEnabled = true;
            this.cbb_TenLopHoc.Location = new System.Drawing.Point(158, 56);
            this.cbb_TenLopHoc.Name = "cbb_TenLopHoc";
            this.cbb_TenLopHoc.Size = new System.Drawing.Size(253, 27);
            this.cbb_TenLopHoc.TabIndex = 3;
            this.cbb_TenLopHoc.DropDown += new System.EventHandler(this.cbb_TenLopHoc_DropDown);
            this.cbb_TenLopHoc.SelectedIndexChanged += new System.EventHandler(this.cbb_TenLopHoc_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_TenLopHoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_ThongkeTheoHocSinh);
            this.groupBox1.Controls.Add(this.cbb_HocSInh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(39, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 253);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê học sinh theo tháng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Picker_MMdd);
            this.groupBox2.Controls.Add(this.cbb_MaTaiXe);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_ThongkeTheoTaiXe);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(554, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 253);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê tài xế theo tháng";
            // 
            // Picker_MMdd
            // 
            this.Picker_MMdd.CustomFormat = "MM/yyyy";
            this.Picker_MMdd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Picker_MMdd.Location = new System.Drawing.Point(158, 129);
            this.Picker_MMdd.Name = "Picker_MMdd";
            this.Picker_MMdd.ShowUpDown = true;
            this.Picker_MMdd.Size = new System.Drawing.Size(253, 27);
            this.Picker_MMdd.TabIndex = 5;
            this.Picker_MMdd.ValueChanged += new System.EventHandler(this.Picker_MMdd_ValueChanged);
            // 
            // cbb_MaTaiXe
            // 
            this.cbb_MaTaiXe.FormattingEnabled = true;
            this.cbb_MaTaiXe.Location = new System.Drawing.Point(158, 56);
            this.cbb_MaTaiXe.Name = "cbb_MaTaiXe";
            this.cbb_MaTaiXe.Size = new System.Drawing.Size(253, 27);
            this.cbb_MaTaiXe.TabIndex = 3;
            this.cbb_MaTaiXe.DropDown += new System.EventHandler(this.cbb_MaTaiXe_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã tài xế";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tháng";
            // 
            // btn_ThongkeTheoTaiXe
            // 
            this.btn_ThongkeTheoTaiXe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ThongkeTheoTaiXe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongkeTheoTaiXe.Location = new System.Drawing.Point(89, 176);
            this.btn_ThongkeTheoTaiXe.Name = "btn_ThongkeTheoTaiXe";
            this.btn_ThongkeTheoTaiXe.Size = new System.Drawing.Size(254, 34);
            this.btn_ThongkeTheoTaiXe.TabIndex = 0;
            this.btn_ThongkeTheoTaiXe.Text = "Xuất thống kê";
            this.btn_ThongkeTheoTaiXe.UseVisualStyleBackColor = false;
            this.btn_ThongkeTheoTaiXe.Click += new System.EventHandler(this.btn_ThongkeTheoTaiXe_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Den_ddMMyyyy);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.Tu_ddMMyyyy);
            this.groupBox3.Controls.Add(this.cbb_BienSoXe);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_XTK_BS_HS_tuan);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(299, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 301);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê tài xế theo tháng";
            // 
            // Tu_ddMMyyyy
            // 
            this.Tu_ddMMyyyy.CustomFormat = "dd/MM/yyyy";
            this.Tu_ddMMyyyy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Tu_ddMMyyyy.Location = new System.Drawing.Point(158, 129);
            this.Tu_ddMMyyyy.Name = "Tu_ddMMyyyy";
            this.Tu_ddMMyyyy.ShowUpDown = true;
            this.Tu_ddMMyyyy.Size = new System.Drawing.Size(253, 27);
            this.Tu_ddMMyyyy.TabIndex = 5;
            // 
            // cbb_BienSoXe
            // 
            this.cbb_BienSoXe.FormattingEnabled = true;
            this.cbb_BienSoXe.Location = new System.Drawing.Point(158, 56);
            this.cbb_BienSoXe.Name = "cbb_BienSoXe";
            this.cbb_BienSoXe.Size = new System.Drawing.Size(253, 27);
            this.cbb_BienSoXe.TabIndex = 3;
            this.cbb_BienSoXe.DropDown += new System.EventHandler(this.cbb_BienSoXe_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Biển số xe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Từ ngày";
            // 
            // btn_XTK_BS_HS_tuan
            // 
            this.btn_XTK_BS_HS_tuan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_XTK_BS_HS_tuan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XTK_BS_HS_tuan.Location = new System.Drawing.Point(85, 242);
            this.btn_XTK_BS_HS_tuan.Name = "btn_XTK_BS_HS_tuan";
            this.btn_XTK_BS_HS_tuan.Size = new System.Drawing.Size(254, 34);
            this.btn_XTK_BS_HS_tuan.TabIndex = 0;
            this.btn_XTK_BS_HS_tuan.Text = "Xuất thống kê";
            this.btn_XTK_BS_HS_tuan.UseVisualStyleBackColor = false;
            this.btn_XTK_BS_HS_tuan.Click += new System.EventHandler(this.btn_XTK_BS_HS_tuan_Click);
            // 
            // Den_ddMMyyyy
            // 
            this.Den_ddMMyyyy.CustomFormat = "dd/MM/yyyy";
            this.Den_ddMMyyyy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Den_ddMMyyyy.Location = new System.Drawing.Point(158, 180);
            this.Den_ddMMyyyy.Name = "Den_ddMMyyyy";
            this.Den_ddMMyyyy.ShowUpDown = true;
            this.Den_ddMMyyyy.Size = new System.Drawing.Size(253, 27);
            this.Den_ddMMyyyy.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đến ngày";
            // 
            // frm_QTV_XTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 736);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_QTV_XTK";
            this.Text = "frm_QTV_XTK";
            this.Load += new System.EventHandler(this.frm_QTV_XTK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ThongkeTheoHocSinh;
        private System.Windows.Forms.ComboBox cbb_HocSInh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_TenLopHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_MaTaiXe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ThongkeTheoTaiXe;
        private System.Windows.Forms.DateTimePicker Picker_MMdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker Tu_ddMMyyyy;
        private System.Windows.Forms.ComboBox cbb_BienSoXe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_XTK_BS_HS_tuan;
        private System.Windows.Forms.DateTimePicker Den_ddMMyyyy;
        private System.Windows.Forms.Label label7;
    }
}