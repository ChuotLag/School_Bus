using QuanLyXeBus.BLL;
using QuanLyXeBus.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeBus.view
{
    public partial class frm_QuanTriVien : Form
    {
        QuanTriVien_BLL bll = new QuanTriVien_BLL();
        private string taiKhoanID;
        public frm_QuanTriVien(string taiKhoanID)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.taiKhoanID = taiKhoanID;
        }

        private void frm_QuanTriVien_Load(object sender, EventArgs e)
        {
            string tenQuanTriVien = bll.GetTenQuanTriVien(taiKhoanID);

            if (!string.IsNullOrEmpty(tenQuanTriVien))
            {
                // Hiển thị tên tài xế lên giao diện
                label_TenAD.Text = tenQuanTriVien;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin Quản trị viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            frm_QTV_XTK frmTK = new frm_QTV_XTK();
            frmTK.TopLevel = false;
            frmTK.FormBorderStyle = FormBorderStyle.None;
            frmTK.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel2.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel2.Controls.Add(frmTK); // Thêm frm_z vào panel_y
            frmTK.Show();
        }

        private void btn_TaiKhoanPhuHuynh_Click(object sender, EventArgs e)
        {
            frm_QVT_TKPH frmPH = new frm_QVT_TKPH();
            frmPH.TopLevel = false;
            frmPH.FormBorderStyle = FormBorderStyle.None;
            frmPH.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel2.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel2.Controls.Add(frmPH); // Thêm frm_z vào panel_y
            frmPH.Show();
        }

        private void btn_TaiKhoanTaiXe_Click(object sender, EventArgs e)
        {
            frm_QTV_TKTX frmPH = new frm_QTV_TKTX();
            frmPH.TopLevel = false;
            frmPH.FormBorderStyle = FormBorderStyle.None;
            frmPH.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel2.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel2.Controls.Add(frmPH); // Thêm frm_z vào panel_y
            frmPH.Show();
        }

        private void btn_DanhSachHocSinh_Click(object sender, EventArgs e)
        {
            //    frm_DanhSachHocSinh frmDSHS = new frm_DanhSachHocSinh();
            //    frmDSHS.TopLevel = false;
            //    frmDSHS.FormBorderStyle = FormBorderStyle.None;
            //    frmDSHS.Dock = DockStyle.Fill;

            //    // Thêm frm_z vào panel_y và hiển thị
            //    panel2.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            //    panel2.Controls.Add(frmDSHS); // Thêm frm_z vào panel_y
            //    frmDSHS.Show();

            frm_QTV_QLHS frmDSHS = new frm_QTV_QLHS();
            frmDSHS.TopLevel = false;
            frmDSHS.FormBorderStyle = FormBorderStyle.None;
            frmDSHS.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel2.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel2.Controls.Add(frmDSHS); // Thêm frm_z vào panel_y
            frmDSHS.Show();
        }

        private void btn_LoTrinhBus_Click(object sender, EventArgs e)
        {
            frm_QTV_XEBUS frmQLXB = new frm_QTV_XEBUS();
            frmQLXB.TopLevel = false;
            frmQLXB.FormBorderStyle = FormBorderStyle.None;
            frmQLXB.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel2.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel2.Controls.Add(frmQLXB); // Thêm frm_z vào panel_y
            frmQLXB.Show();
        }

        private void btn_TaiKhoanNhanVien_Click(object sender, EventArgs e)
        {
            frm_QTV_QLNV frmQLQTV = new frm_QTV_QLNV();
            frmQLQTV.TopLevel = false;
            frmQLQTV.FormBorderStyle = FormBorderStyle.None;
            frmQLQTV.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel2.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel2.Controls.Add(frmQLQTV); // Thêm frm_z vào panel_y
            frmQLQTV.Show();
        }

        private void btn_DangXuat_QTV_Click(object sender, EventArgs e)
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


        private void btn_CTDSHS_Click(object sender, EventArgs e)
        {
            frm_QTV_QLCTHS frmQLQTV = new frm_QTV_QLCTHS();
            frmQLQTV.TopLevel = false;
            frmQLQTV.FormBorderStyle = FormBorderStyle.None;
            frmQLQTV.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel2.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel2.Controls.Add(frmQLQTV); // Thêm frm_z vào panel_y
            frmQLQTV.Show();
        }

        private void btn_QLLT_Click(object sender, EventArgs e)
        {
            frm_QTV_QLLT frmQLQTV = new frm_QTV_QLLT();
            frmQLQTV.TopLevel = false;
            frmQLQTV.FormBorderStyle = FormBorderStyle.None;
            frmQLQTV.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel2.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel2.Controls.Add(frmQLQTV); // Thêm frm_z vào panel_y
            frmQLQTV.Show();
        }

        private void btn_QLDD_Click(object sender, EventArgs e)
        {
            frm_QTV_QLDD frmQLQTV = new frm_QTV_QLDD();
            frmQLQTV.TopLevel = false;
            frmQLQTV.FormBorderStyle = FormBorderStyle.None;
            frmQLQTV.Dock = DockStyle.Fill;

            // Thêm frm_z vào panel_y và hiển thị
            panel2.Controls.Clear();   // Xóa các control hiện tại trong panel_y
            panel2.Controls.Add(frmQLQTV); // Thêm frm_z vào panel_y
            frmQLQTV.Show();
        }

        private void frm_QuanTriVien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_SaoLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị hộp thoại chọn thư mục lưu file sao lưu
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        string backupPath = Path.Combine(fbd.SelectedPath, "Backup_QLXeBus.bak");

                        // Câu lệnh SQL sao lưu dữ liệu
                        string query = $"BACKUP DATABASE QLXEBUS01 TO DISK = '{backupPath}'";

                        // Kết nối đến SQL Server và thực thi lệnh
                        using (SqlConnection conn = new SqlConnection("Server=DESKTOP-FF9BMG1; Database=QLXEBUS01; Integrated Security=True;"))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Sao lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sao lưu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_PhucHoi_Click(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị hộp thoại chọn file .bak để phục hồi
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Backup Files (*.bak)|*.bak";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string backupPath = ofd.FileName;

                        // Kết nối đến SQL Server và thực thi lệnh phục hồi
                        string query = $@"
                    USE master;
                    ALTER DATABASE QLXEBUS01 SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                    RESTORE DATABASE QLXEBUS01 FROM DISK = '{backupPath}' WITH REPLACE;
                    ALTER DATABASE QLXEBUS01 SET MULTI_USER;";

                        using (SqlConnection conn = new SqlConnection("Server=DESKTOP-FF9BMG1; Database=QLXEBUS01; Integrated Security=True;"))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Phục hồi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi phục hồi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
