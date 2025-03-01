using QuanLyXeBus.BusinessLogic;
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
using QuanLyXeBus.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace QuanLyXeBus.view
{
    public partial class frm_TX_XemLoTrinh : Form
    {
        private TaiXe_BLL taiXeBLL;
        private string taiKhoanID;
        private LoTrinh_BLL ltBLL;
        private PhuHuynh_BLL phBLL;

        private List<string> viTri;
        private int viTriDau = 0;


        public frm_TX_XemLoTrinh(string taiKhoanID)
        {
            InitializeComponent();
            taiXeBLL = new TaiXe_BLL();
            ltBLL = new LoTrinh_BLL();
            phBLL = new PhuHuynh_BLL(); 
            this.taiKhoanID = taiKhoanID;


            //-----------//
            txt_TX_BSX.Enabled = false;
            txt_TX_SoGhe.Enabled = false;

        }




        void load_BienSoXe()
        {
            string bienSoXe = taiXeBLL.GetBienSoXeByTaiXe(taiKhoanID);
            if (!string.IsNullOrEmpty(bienSoXe))
            {
                txt_TX_BSX.Text = bienSoXe;
            }
            else
            {
                txt_TX_BSX.Text = "Chưa có xe";
            }
        }
        void load_SoGhe()
        {
            string soGhe = taiXeBLL.GetSoGheByTaiXe(taiKhoanID);
            if (!string.IsNullOrEmpty(soGhe))
            {
                txt_TX_SoGhe.Text = soGhe;
            }
            else
            {
                txt_TX_SoGhe.Text = "0";
            }
        }

        private void frm_TX_XemLoTrinh_Load(object sender, EventArgs e)
        {
            load_BienSoXe();
            load_SoGhe();

        }

        private void btn_TX_HienThiLoTrinh_Click(object sender, EventArgs e)
        {
            try
            {
                string loTrinhDuongDi = ltBLL.GetLoTrinhByTaiXeID(taiKhoanID);
                lb_TX_LoTrinh.AutoSize = false;
                lb_TX_LoTrinh.Text = loTrinhDuongDi;
                lb_TX_LoTrinh.AutoSize = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_TX_CapNhatViTri_Click(object sender, EventArgs e)
        {

            try
            {
                viTri = ltBLL.GetTTLoTrinhByTaiXeID(taiKhoanID);

                if (viTri != null && viTri.Count > 0)
                {
                    ViTriTiepTheo();
                }
                else
                {
                    lb_TX_ViTriHienTai.Text = "Không tìm thấy lộ trình cho chuyến xe này.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void ViTriTiepTheo()
        {
            if (viTri != null && viTriDau < viTri.Count)
            {
                lb_TX_ViTriHienTai.Text = viTri[viTriDau];
                viTriDau++;
            }
            else
            {
                lb_TX_ViTriHienTai.Text = "Đã hết lộ trình."; 
                viTriDau = 0;
            }
        }

        private void btn_TX_ThongBao_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy vị trí hiện tại từ label
                string viTriHienTai = lb_TX_ViTriHienTai.Text.Trim();
                if (string.IsNullOrEmpty(viTriHienTai))
                {
                    MessageBox.Show("Vị trí hiện tại chưa được cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Nội dung email
                string subject = "Thông báo từ hệ thống Xe Bus";
                string body = $"Xe đang đến vị trí: {viTriHienTai}. Quý phụ huynh vui lòng chuẩn bị đưa đón học sinh đúng giờ. Cảm ơn!";

                // Lấy danh sách email phụ huynh từ cơ sở dữ liệu
                List<string> danhSachEmail = phBLL.GetEmailsPhuHuynhTheoTaiXe(taiKhoanID); // taiKhoanID của tài xế hiện tại

                if (danhSachEmail.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy email của phụ huynh trên xe này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gửi email cho từng phụ huynh trong danh sách
                foreach (string email in danhSachEmail)
                {
                    phBLL.GuiEmail(email, subject, body);
                }

                MessageBox.Show("Thông báo đã được gửi đến các phụ huynh thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi thông báo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TX_KetThucChuyenXe_Click(object sender, EventArgs e)
        {
            try
            {
                // Nội dung email
                string subject = "Thông báo từ hệ thống Xe Bus";
                string body = $"Chuyến xe đã hoàn thành. Cảm ơn!";

                // Lấy danh sách email phụ huynh từ cơ sở dữ liệu
                List<string> danhSachEmail = phBLL.GetEmailsPhuHuynhTheoTaiXe(taiKhoanID); // taiKhoanID của tài xế hiện tại

                if (danhSachEmail.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy email của phụ huynh trên xe này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gửi email cho từng phụ huynh trong danh sách
                foreach (string email in danhSachEmail)
                {
                    phBLL.GuiEmail(email, subject, body);
                }

                MessageBox.Show("Thông báo đã được gửi đến các phụ huynh thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi thông báo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
