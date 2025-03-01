using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyXeBus.BLL;
using QuanLyXeBus.view;
namespace QuanLyXeBus.GUI
{
    public partial class frm_ALL_OTP_QuenMatKhau : Form
    {
        private QuenMatKhau_BLL bll = new QuenMatKhau_BLL();
        private string emailDaGuiOTP;
        public frm_ALL_OTP_QuenMatKhau()
        {
            InitializeComponent();

        }

        private void btn_ALL_GuiOTP_Click(object sender, EventArgs e)
        {
            string email = txt_ALL_Email.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email.");
                return;
            }

            string message = bll.GuiOTP(email);
            if (message.Contains("OTP đã được gửi"))
            {
                emailDaGuiOTP = email;
            }
            MessageBox.Show(message);
        }
        private void btn_ALL_XacNhan_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_ALL_OTP.Text.Trim(), out int otp))
            {
                if (bll.XacNhanOTP(otp))
                {
                    string taiKhoanID = bll.LayTaiKhoanIDTuEmail(emailDaGuiOTP);

                    if (!string.IsNullOrEmpty(taiKhoanID))
                    {
                        MessageBox.Show("Xác nhận thành công!");
                        frm_DoiMatKhau formDoiMatKhau = new frm_DoiMatKhau(taiKhoanID);
                        formDoiMatKhau.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể tìm thấy tài khoản liên kết với email.");
                    }
                }
                else
                {
                    MessageBox.Show("Mã OTP sai, vui lòng thử lại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã OTP hợp lệ.");
            }
        }
    }
}
