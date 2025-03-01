using QuanLyXeBus.BLL;
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

namespace QuanLyXeBus.GUI
{
    public partial class frm_TX_DiemDanhCaLam : Form
    {
        private TaiXe_BLL bll;
        private TaiXe_BLL taiXeBLL;
        private DiemDanhTaiXe_BLL danhTXBLL;
        private string taiKhoanID;
        public frm_TX_DiemDanhCaLam(string taiKhoanID)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.taiKhoanID = taiKhoanID;
            this.taiXeBLL = new TaiXe_BLL(); // Khởi tạo taiXeBLL
            this.danhTXBLL = new DiemDanhTaiXe_BLL(); // Khởi tạo danhTXBLL
            
            this.bll = new TaiXe_BLL();
            
        }
        void load_BienSoXe()
        {
            string bienSoXe = taiXeBLL.GetBienSoXeByTaiXe(taiKhoanID);
            if (!string.IsNullOrEmpty(bienSoXe))
            {
                lb_TX_BienSoXe.Text = bienSoXe;
                lb_TX_BienSoXe.ForeColor = Color.Red;
            }
            else
            {
                lb_TX_BienSoXe.Text = "Chưa có xe";
            }
        }

        private void frm_TX_DiemDanhCaLam_Load(object sender, EventArgs e)
        {
            string tenTaiXe = bll.GetTenTaiXe(taiKhoanID);

            if (!string.IsNullOrEmpty(tenTaiXe))
            {
                // Hiển thị tên tài xế lên giao diện
                lb_TX_TenTaiXe.Text = tenTaiXe;
                lb_TX_TenTaiXe.ForeColor = Color.Red; // Màu chữ mặc định
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin tài xế.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load_BienSoXe();
            LoadDiemDanhTaiXe();
        }

        private void btn_Tx_TaoMaDiemDanhTaiXe_Click(object sender, EventArgs e)
        {
            string autoID = danhTXBLL.TaoID_Auto();
            txt_TX_IDDiemDanh.Text = autoID;
        }

       

        private void cbb_TX_CaLam_DropDown(object sender, EventArgs e)
        {
            if (cbb_TX_CaLam.DataSource == null) 
            {
                danhTXBLL = new DiemDanhTaiXe_BLL();  
                var CaLamTaiXeList = danhTXBLL.GetCaLamTaiXelist(); 
                cbb_TX_CaLam.DataSource = CaLamTaiXeList; 
                cbb_TX_CaLam.DisplayMember = "CaLam"; 
                cbb_TX_CaLam.ValueMember = "CaLam_ID"; 
            }
        }

        private void txt_TX_DiemDanhCaLam_Click(object sender, EventArgs e)
        {

            // Lấy dữ liệu từ giao diện
            string diemDanhTX_ID = txt_TX_IDDiemDanh.Text; // Mã điểm danh từ TextBox
            string soXeBus = lb_TX_BienSoXe.Text; // Biển số xe từ Label
            DateTime ngay = DateTime.Now; // Ngày điểm danh là ngày hiện tại
            string caLamID = cbb_TX_CaLam.SelectedValue.ToString(); // Lấy Ca làm từ ComboBox
            string trangThai = "Đúng giờ"; // Giả sử điểm danh luôn đúng giờ

            // Gọi phương thức trong BLL để lưu điểm danh
            danhTXBLL.LuuDiemDanhTaiXe(diemDanhTX_ID, taiKhoanID, soXeBus, ngay, caLamID, trangThai);

            // Thông báo thành công
            MessageBox.Show("Điểm danh tài xế thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDiemDanhTaiXe();
        }

        // Phương thức tải dữ liệu điểm danh tài xế lên GridView
        private void LoadDiemDanhTaiXe()
        {
            DataTable dt = danhTXBLL.GetDiemDanhByTaiKhoanID(taiKhoanID);  // Gọi BLL để lấy dữ liệu
            tbl_TX_DiemDanhTaiXe.DataSource = dt;  // Cập nhật DataSource cho GridView
        }
    }
}
