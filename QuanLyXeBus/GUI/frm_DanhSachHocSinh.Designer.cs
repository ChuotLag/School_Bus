namespace QuanLyXeBus.GUI
{
    partial class frm_DanhSachHocSinh
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
            this.panel_DanhSachHocSinh = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.item_DanhSachHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.item_ChiTietDanhSachHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_DanhSachHocSinh
            // 
            this.panel_DanhSachHocSinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.panel_DanhSachHocSinh.Location = new System.Drawing.Point(1, 34);
            this.panel_DanhSachHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_DanhSachHocSinh.Name = "panel_DanhSachHocSinh";
            this.panel_DanhSachHocSinh.Size = new System.Drawing.Size(1750, 965);
            this.panel_DanhSachHocSinh.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_DanhSachHocSinh,
            this.item_ChiTietDanhSachHocSinh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1732, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // item_DanhSachHocSinh
            // 
            this.item_DanhSachHocSinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_DanhSachHocSinh.Name = "item_DanhSachHocSinh";
            this.item_DanhSachHocSinh.Size = new System.Drawing.Size(182, 26);
            this.item_DanhSachHocSinh.Text = "Danh sách học sinh";
            this.item_DanhSachHocSinh.Click += new System.EventHandler(this.item_DanhSachHocSinh_Click);
            // 
            // item_ChiTietDanhSachHocSinh
            // 
            this.item_ChiTietDanhSachHocSinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_ChiTietDanhSachHocSinh.Name = "item_ChiTietDanhSachHocSinh";
            this.item_ChiTietDanhSachHocSinh.Size = new System.Drawing.Size(242, 26);
            this.item_ChiTietDanhSachHocSinh.Text = "Danh sách chi tiết học sinh";
            this.item_ChiTietDanhSachHocSinh.Click += new System.EventHandler(this.item_ChiTietDanhSachHocSinh_Click);
            // 
            // frm_DanhSachHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 918);
            this.Controls.Add(this.panel_DanhSachHocSinh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_DanhSachHocSinh";
            this.Text = "frm_DanhSachHocSinh";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_DanhSachHocSinh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem item_DanhSachHocSinh;
        private System.Windows.Forms.ToolStripMenuItem item_ChiTietDanhSachHocSinh;
    }
}