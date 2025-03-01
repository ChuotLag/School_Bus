namespace QuanLyXeBus.GUI
{
    partial class frm_ALL_OTP_QuenMatKhau
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
            this.btn_ALL_XacNhan = new System.Windows.Forms.Button();
            this.txt_ALL_OTP = new System.Windows.Forms.TextBox();
            this.txt_ALL_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ALL_GuiOTP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ALL_XacNhan
            // 
            this.btn_ALL_XacNhan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_ALL_XacNhan.Location = new System.Drawing.Point(200, 164);
            this.btn_ALL_XacNhan.Name = "btn_ALL_XacNhan";
            this.btn_ALL_XacNhan.Size = new System.Drawing.Size(100, 44);
            this.btn_ALL_XacNhan.TabIndex = 7;
            this.btn_ALL_XacNhan.Text = "Xác nhận";
            this.btn_ALL_XacNhan.UseVisualStyleBackColor = true;
            this.btn_ALL_XacNhan.Click += new System.EventHandler(this.btn_ALL_XacNhan_Click);
            // 
            // txt_ALL_OTP
            // 
            this.txt_ALL_OTP.Location = new System.Drawing.Point(156, 108);
            this.txt_ALL_OTP.Name = "txt_ALL_OTP";
            this.txt_ALL_OTP.Size = new System.Drawing.Size(210, 22);
            this.txt_ALL_OTP.TabIndex = 5;
            // 
            // txt_ALL_Email
            // 
            this.txt_ALL_Email.Location = new System.Drawing.Point(156, 55);
            this.txt_ALL_Email.Multiline = true;
            this.txt_ALL_Email.Name = "txt_ALL_Email";
            this.txt_ALL_Email.Size = new System.Drawing.Size(210, 21);
            this.txt_ALL_Email.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập Email ";
            // 
            // btn_ALL_GuiOTP
            // 
            this.btn_ALL_GuiOTP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ALL_GuiOTP.Location = new System.Drawing.Point(389, 42);
            this.btn_ALL_GuiOTP.Name = "btn_ALL_GuiOTP";
            this.btn_ALL_GuiOTP.Size = new System.Drawing.Size(110, 44);
            this.btn_ALL_GuiOTP.TabIndex = 8;
            this.btn_ALL_GuiOTP.Text = "GỬI OTP";
            this.btn_ALL_GuiOTP.UseVisualStyleBackColor = true;
            this.btn_ALL_GuiOTP.Click += new System.EventHandler(this.btn_ALL_GuiOTP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập mã OTP";
            // 
            // frm_ALL_OTP_QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ALL_XacNhan);
            this.Controls.Add(this.btn_ALL_GuiOTP);
            this.Controls.Add(this.txt_ALL_OTP);
            this.Controls.Add(this.txt_ALL_Email);
            this.Controls.Add(this.label1);
            this.Name = "frm_ALL_OTP_QuenMatKhau";
            this.Text = "frm_ALL_QuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ALL_XacNhan;
        private System.Windows.Forms.TextBox txt_ALL_OTP;
        private System.Windows.Forms.TextBox txt_ALL_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ALL_GuiOTP;
        private System.Windows.Forms.Label label2;
    }
}