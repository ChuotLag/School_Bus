using QuanLyXeBus.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeBus.GUI
{
    public partial class frm_DanhSachHocSinh : Form
    {
        public frm_DanhSachHocSinh()
        {
            InitializeComponent();
        }

        private void item_DanhSachHocSinh_Click(object sender, EventArgs e)
        {
            frm_QTV_QLHS frmQLHS = new frm_QTV_QLHS();
            frmQLHS.TopLevel = false;
            frmQLHS.FormBorderStyle = FormBorderStyle.None;
            frmQLHS.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel_DanhSachHocSinh.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel_DanhSachHocSinh.Controls.Add(frmQLHS); // Thêm frm_z vào panel_y
            frmQLHS.Show();
        }

        private void item_ChiTietDanhSachHocSinh_Click(object sender, EventArgs e)
        {
            frm_QTV_QLCTHS frmQLCTHS = new frm_QTV_QLCTHS();
            frmQLCTHS.TopLevel = false;
            frmQLCTHS.FormBorderStyle = FormBorderStyle.None;
            frmQLCTHS.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel_DanhSachHocSinh.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel_DanhSachHocSinh.Controls.Add(frmQLCTHS); // Thêm frm_z vào panel_y
            frmQLCTHS.Show();
        }
    }
}
