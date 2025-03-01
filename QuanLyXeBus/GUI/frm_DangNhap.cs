using QuanLyXeBus.BLL;
using QuanLyXeBus.GUI;
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
    public partial class frm_DangNhap : Form
    {

        TaiKhoan_BLL bll = new TaiKhoan_BLL();


        public frm_DangNhap()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txt_TaiKhoan_Enter(object sender, EventArgs e)
        {
            if(txt_TenDangNhap.Text =="Tên đăng nhập")
            {
                txt_TenDangNhap.Text = "";
                txt_TenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txt_TaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txt_TenDangNhap.Text == "")
            {
                txt_TenDangNhap.Text = "Tên đăng nhập";
                txt_TenDangNhap.ForeColor = Color.Silver;
            }
        }

        private void txt_MatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MatKhau.Text))
            {
                txt_MatKhau.PasswordChar = '\0';
                txt_MatKhau.Text = "Mật khẩu";
                txt_MatKhau.ForeColor = Color.Silver;
            }
        }

        private void txt_MatKhau_Enter(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text == "Mật khẩu")
            {
                txt_MatKhau.Text = "";
                txt_MatKhau.ForeColor = Color.Black;
                txt_MatKhau.PasswordChar = '*';
            }
        }
        private void LamMoi()
        {
            txt_TenDangNhap.Text = "Tên đăng nhập";
            txt_TenDangNhap.ForeColor = Color.Silver;
            txt_MatKhau.Text = "Mật khẩu";
            txt_MatKhau.ForeColor = Color.Silver;

        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoanID = txt_TenDangNhap.Text;  // Lấy tên tài khoản
            string matKhau = txt_MatKhau.Text;  // Lấy mật khẩu

            // Gọi phương thức đăng nhập từ BLL
            string loaiTaiKhoan = bll.DangNhap(taiKhoanID, matKhau);

            // Kiểm tra và mở form tương ứng dựa trên kết quả trả về từ DangNhap
            if (!string.IsNullOrEmpty(loaiTaiKhoan))
            {
                // Ẩn form đăng nhập
                this.Hide();

                if (loaiTaiKhoan == "QTV")
                {
                    frm_QuanTriVien formQT = new frm_QuanTriVien(taiKhoanID);
                    //TaiKhoan_BLL.TaiKhoanID = taiKhoanID;
                    formQT.Show();
                    LamMoi();
                }
                else if (loaiTaiKhoan == "TX")
                {
                    frm_TaiXe formTX = new frm_TaiXe(taiKhoanID);
                    //TaiKhoan_BLL.TaiKhoanID = taiKhoanID;
                    formTX.Show();
                    LamMoi();
                }
                else if (loaiTaiKhoan == "PH")
                {
                    frm_PhuHuynh formPH = new frm_PhuHuynh(taiKhoanID);
                    // TaiKhoan_BLL.TaiKhoanID = taiKhoanID;
                    formPH.Show();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Loại tài khoản không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            var thongBao = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongBao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_ALL_OTP_QuenMatKhau frmOTP = new frm_ALL_OTP_QuenMatKhau();

            // Hiển thị form mới
            frmOTP.Show();
        }
        private bool isPasswordVisible = false;
        private void ptb_eyes_Click(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái hiển thị mật khẩu
            if (isPasswordVisible)
            {
                txt_MatKhau.PasswordChar = '*'; // Ẩn mật khẩu
                ptb_eyes.Image = Properties.Resources.eys_c; // Thay đổi hình ảnh thành "mắt đóng"
                isPasswordVisible = false;
            }
            else
            {
                txt_MatKhau.PasswordChar = '\0'; // Hiển thị mật khẩu
                ptb_eyes.Image = Properties.Resources.eye; // Thay đổi hình ảnh thành "mắt mở"
                isPasswordVisible = true;
            }
        }
    }
}
