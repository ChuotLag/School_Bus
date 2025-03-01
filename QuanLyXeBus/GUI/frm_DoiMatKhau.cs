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
    public partial class frm_DoiMatKhau : Form
    {
        private string taiKhoanID;
        private TaiKhoan_BLL bll;

        public frm_DoiMatKhau(string taiKhoanID)
        {
            InitializeComponent();
            this.taiKhoanID = taiKhoanID;
            bll = new TaiKhoan_BLL();
        }

        private void btn_CapNhatMK_Click(object sender, EventArgs e)
        {
            try
            {
                string matKhauCu = txt_NhapMatKhauCu.Text.Trim();
                string matKhauMoi = txt_NhapMatKhauMoi.Text.Trim();
                string nhapLai = txt_NhapLaiMatKhauMoi.Text.Trim();
                if (matKhauMoi != nhapLai)
                {
                    MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(matKhauMoi))
                {
                    MessageBox.Show("Mật khẩu mới không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (bll.DoiMatKhau(taiKhoanID, matKhauCu, matKhauMoi))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    txt_NhapLaiMatKhauMoi.Text = "";
                    txt_NhapMatKhauCu.Text = "";
                    txt_NhapMatKhauMoi.Text = "";
                }
                else
                {
                    MessageBox.Show("Không thể đổi mật khẩu. Kiểm tra lại thông tin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txt_NhapLaiMatKhauMoi.PasswordChar = '*';
            txt_NhapMatKhauCu.PasswordChar = '*';
            txt_NhapMatKhauMoi.PasswordChar = '*';
        }
    }
}
