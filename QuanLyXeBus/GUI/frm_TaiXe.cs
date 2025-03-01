using QuanLyXeBus.BusinessLogic;
using QuanLyXeBus.GUI;
using QuanLyXeBus.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeBus.view
{
    public partial class frm_TaiXe : Form
    {

        private TaiXe_BLL bll;
        private string taiKhoanID;
        public frm_TaiXe(string taiKhoanID)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.taiKhoanID = taiKhoanID;
            this.bll = new TaiXe_BLL();
        }
        private void btn_DanhSachHocSinh_Click(object sender, EventArgs e)
        {
            frm_TX_DiemDanh frmPH = new frm_TX_DiemDanh(taiKhoanID);
            frmPH.TopLevel = false;
            frmPH.FormBorderStyle = FormBorderStyle.None;
            frmPH.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel_TX.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel_TX.Controls.Add(frmPH); // Thêm frm_z vào panel_y
            frmPH.Show();
        }
        private void btn_XemLoTrinhBus_Click(object sender, EventArgs e)
        {
            frm_TX_XemLoTrinh frmPH = new frm_TX_XemLoTrinh(taiKhoanID);
            frmPH.TopLevel = false;
            frmPH.FormBorderStyle = FormBorderStyle.None;
            frmPH.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel_TX.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel_TX.Controls.Add(frmPH); // Thêm frm_z vào panel_y
            frmPH.Show();
        }
        private void btn_TX_DangXuat_Click(object sender, EventArgs e)
        {
            var thongBao = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongBao == DialogResult.Yes)
            {
                this.Close();
                // Kiểm tra xem form đăng nhập đã mở chưa
                bool isLoginFormOpen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f is frm_DangNhap)
                    {
                        // Nếu form đăng nhập đã mở, hiển thị lại và ẩn các form khác
                        isLoginFormOpen = true;
                        f.Show(); // Hiển thị form đăng nhập
                        break;
                    }
                }

                if (!isLoginFormOpen)
                {
                    // Nếu chưa có form đăng nhập, mở mới
                    frm_DangNhap frmLogin = new frm_DangNhap();
                    frmLogin.Show();
                }

                // Ẩn tất cả các form khác ngoài form đăng nhập
                foreach (Form f in Application.OpenForms)
                {
                    if (!(f is frm_DangNhap))
                    {
                        f.Hide(); // Ẩn các form khác
                    }
                }
            }
        }

        private void frm_TaiXe_Load(object sender, EventArgs e)
        {
            string tenTaiXe = bll.GetTenTaiXe(taiKhoanID);

            if (!string.IsNullOrEmpty(tenTaiXe))
            {
                // Hiển thị tên tài xế lên giao diện
                label_TenTX.Text = "Xin chào, " + tenTaiXe + "!";
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin tài xế.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TX_DiemDanhCaLam_Click(object sender, EventArgs e)
        {
            // Đảm bảo rằng `taiKhoanID` đã được khởi tạo
            if (string.IsNullOrEmpty(taiKhoanID))
            {
                MessageBox.Show("Tài khoản ID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frm_TX_DiemDanhCaLam frmPH = new frm_TX_DiemDanhCaLam(taiKhoanID); // Truyền taiKhoanID
            frmPH.TopLevel = false;
            frmPH.FormBorderStyle = FormBorderStyle.None;
            frmPH.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel_TX.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel_TX.Controls.Add(frmPH); // Thêm frm_z vào panel_y
            frmPH.Show();
        }

        private void btn_TX_ThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau frmPH = new frm_DoiMatKhau(taiKhoanID);
            frmPH.TopLevel = false;
            frmPH.FormBorderStyle = FormBorderStyle.None;
            frmPH.Dock = DockStyle.Fill;
            panel_TX.Controls.Clear();   
            panel_TX.Controls.Add(frmPH);
            frmPH.Show();
        }

        private void btn_TX_DiemDanhCaLam_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(taiKhoanID))
            {
                MessageBox.Show("Tài khoản ID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frm_TX_DiemDanhCaLam frmPH = new frm_TX_DiemDanhCaLam(taiKhoanID); // Truyền taiKhoanID
            frmPH.TopLevel = false;
            frmPH.FormBorderStyle = FormBorderStyle.None;
            frmPH.Dock = DockStyle.Fill;
            panel_TX.Controls.Clear();  
            panel_TX.Controls.Add(frmPH);
            frmPH.Show();
        }

        private void frm_TaiXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
