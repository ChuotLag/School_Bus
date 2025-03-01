namespace QuanLyXeBus.view
{
    partial class frm_QLXEBUS
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
            this.item_QTV_QuanLyXeBus = new System.Windows.Forms.ToolStripMenuItem();
            this.item_QTV_QuanLyDiemDung = new System.Windows.Forms.ToolStripMenuItem();
            this.item_QLLT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // item_QTV_QuanLyXeBus
            // 
            this.item_QTV_QuanLyXeBus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_QTV_QuanLyXeBus.Name = "item_QTV_QuanLyXeBus";
            this.item_QTV_QuanLyXeBus.Size = new System.Drawing.Size(129, 23);
            this.item_QTV_QuanLyXeBus.Text = "Quản lý xe bus";
            this.item_QTV_QuanLyXeBus.Click += new System.EventHandler(this.item_QTV_QuanLyXeBus_Click);
            // 
            // item_QTV_QuanLyDiemDung
            // 
            this.item_QTV_QuanLyDiemDung.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.item_QTV_QuanLyDiemDung.Name = "item_QTV_QuanLyDiemDung";
            this.item_QTV_QuanLyDiemDung.Size = new System.Drawing.Size(162, 23);
            this.item_QTV_QuanLyDiemDung.Text = "Quản lý điểm dừng";
            this.item_QTV_QuanLyDiemDung.Click += new System.EventHandler(this.item_QTV_QuanLyDiemDung_Click);
            // 
            // item_QLLT
            // 
            this.item_QLLT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.item_QLLT.Name = "item_QLLT";
            this.item_QLLT.Size = new System.Drawing.Size(141, 23);
            this.item_QLLT.Text = "Quản lý lộ trình";
            this.item_QLLT.Click += new System.EventHandler(this.item_QLLT_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_QTV_QuanLyXeBus,
            this.item_QTV_QuanLyDiemDung,
            this.item_QLLT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1306, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 812);
            this.panel1.TabIndex = 3;
            // 
            // frm_QLXEBUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 868);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_QLXEBUS";
            this.Text = "frm_QLXEBUS";
            this.Load += new System.EventHandler(this.frm_QLXEBUS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem item_QTV_QuanLyXeBus;
        private System.Windows.Forms.ToolStripMenuItem item_QTV_QuanLyDiemDung;
        private System.Windows.Forms.ToolStripMenuItem item_QLLT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}