using QuanLyXeBus.BLL;
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
    public partial class frm_PhuHuynh : Form
    {
        private string taiKhoanID;
        PhuHuynh_BLL phBLL;
        public frm_PhuHuynh(string taiKhoanID)
        {
            InitializeComponent();
            this.taiKhoanID = taiKhoanID;
            this.WindowState = FormWindowState.Maximized;
            phBLL = new PhuHuynh_BLL();
        }

        private void btn_XemLoTrinhBus_Click(object sender, EventArgs e)
        {
            frm_PH_XemLoTrinh frmPH  = new frm_PH_XemLoTrinh(taiKhoanID);
            frmPH.TopLevel = false;
            frmPH.FormBorderStyle = FormBorderStyle.None;
            frmPH.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel_lotrinhPH.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel_lotrinhPH.Controls.Add(frmPH); // Thêm frm_z vào panel_y
            frmPH.Show();
        }

        private void frm_PhuHuynh_Load(object sender, EventArgs e)
        {
            string tenPH = phBLL.GetTenPH(taiKhoanID);

            if (!string.IsNullOrEmpty(tenPH))
            {
                // Hiển thị tên tài xế lên giao diện
                label_TenPH.Text = "Xin chào, " + tenPH + "!";
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin phụ huynh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_PH_ThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau frmPH = new frm_DoiMatKhau(taiKhoanID);
            frmPH.TopLevel = false;
            frmPH.FormBorderStyle = FormBorderStyle.None;
            frmPH.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel_lotrinhPH.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel_lotrinhPH.Controls.Add(frmPH); // Thêm frm_z vào panel_y
            frmPH.Show();
        }

        private void btn_PH_DangXuat_Click(object sender, EventArgs e)
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

        private void frm_PhuHuynh_FormClosing(object sender, FormClosingEventArgs e)
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
