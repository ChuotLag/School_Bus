namespace QuanLyXeBus.view
{
    partial class frm_DoiMatKhau
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_NhapMatKhauCu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NhapMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NhapLaiMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_CapNhatMK = new QuanLyXeBus.CustomControls.RJButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 104);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(214, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(341, 45);
            this.label9.TabIndex = 18;
            this.label9.Text = "Thay đổi mật khẩu";
            // 
            // txt_NhapMatKhauCu
            // 
            this.txt_NhapMatKhauCu.Location = new System.Drawing.Point(139, 153);
            this.txt_NhapMatKhauCu.Multiline = true;
            this.txt_NhapMatKhauCu.Name = "txt_NhapMatKhauCu";
            this.txt_NhapMatKhauCu.Size = new System.Drawing.Size(466, 28);
            this.txt_NhapMatKhauCu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập mật khẩu cũ";
            // 
            // txt_NhapMatKhauMoi
            // 
            this.txt_NhapMatKhauMoi.Location = new System.Drawing.Point(139, 230);
            this.txt_NhapMatKhauMoi.Multiline = true;
            this.txt_NhapMatKhauMoi.Name = "txt_NhapMatKhauMoi";
            this.txt_NhapMatKhauMoi.Size = new System.Drawing.Size(466, 28);
            this.txt_NhapMatKhauMoi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(134, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập mật khẩu mới";
            // 
            // txt_NhapLaiMatKhauMoi
            // 
            this.txt_NhapLaiMatKhauMoi.Location = new System.Drawing.Point(139, 300);
            this.txt_NhapLaiMatKhauMoi.Multiline = true;
            this.txt_NhapLaiMatKhauMoi.Name = "txt_NhapLaiMatKhauMoi";
            this.txt_NhapLaiMatKhauMoi.Size = new System.Drawing.Size(466, 28);
            this.txt_NhapLaiMatKhauMoi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(134, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // btn_CapNhatMK
            // 
            this.btn_CapNhatMK.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_CapNhatMK.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_CapNhatMK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_CapNhatMK.BorderRadius = 20;
            this.btn_CapNhatMK.BorderSize = 0;
            this.btn_CapNhatMK.FlatAppearance.BorderSize = 0;
            this.btn_CapNhatMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhatMK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_CapNhatMK.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhatMK.Location = new System.Drawing.Point(455, 350);
            this.btn_CapNhatMK.Name = "btn_CapNhatMK";
            this.btn_CapNhatMK.Size = new System.Drawing.Size(150, 40);
            this.btn_CapNhatMK.TabIndex = 9;
            this.btn_CapNhatMK.Text = "Cập nhật";
            this.btn_CapNhatMK.TextColor = System.Drawing.Color.White;
            this.btn_CapNhatMK.UseVisualStyleBackColor = false;
            this.btn_CapNhatMK.Click += new System.EventHandler(this.btn_CapNhatMK_Click);
            // 
            // frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 473);
            this.Controls.Add(this.btn_CapNhatMK);
            this.Controls.Add(this.txt_NhapLaiMatKhauMoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NhapMatKhauMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NhapMatKhauCu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_DoiMatKhau";
            this.Text = "frm_DoiMatKhau";
            this.Load += new System.EventHandler(this.frm_DoiMatKhau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_NhapMatKhauCu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NhapMatKhauMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NhapLaiMatKhauMoi;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJButton btn_CapNhatMK;
    }
}