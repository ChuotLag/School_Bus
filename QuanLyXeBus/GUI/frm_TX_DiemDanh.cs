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
using QuanLyXeBus.BusinessLogic;
using QuanLyXeBus.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyXeBus.view
{
    public partial class frm_TX_DiemDanh : Form
    {
        private DiemDung_BLL dungBLL;
        private DiemDanh_BLL danhBLL;
        private ChiTietDiemDanh_BLL ctddBLL;
        private TaiXe_BLL taiXeBLL;
        private HocSinh_BLL hsBLL;
        private Timer thGian;
        private string taiKhoanID;
        public frm_TX_DiemDanh(string taiKhoanID)
        {
            InitializeComponent();
            dungBLL = new DiemDung_BLL();
            danhBLL = new DiemDanh_BLL();
            ctddBLL = new ChiTietDiemDanh_BLL();
            taiXeBLL = new TaiXe_BLL();
            hsBLL = new HocSinh_BLL();
            //-----------//
            thGian = new Timer();
            thGian.Interval = 1000; // Cập nhật mỗi giây
            thGian.Tick += demThoiGian; // Gán sự kiện Tick
            thGian.Start(); // Bắt đầu Timer
            this.taiKhoanID = taiKhoanID;

            //-----------//
            txt_TX_BienSoXe.Enabled = false;
        }
        void load_BienSoXe()
        {
            string bienSoXe = taiXeBLL.GetBienSoXeByTaiXe(taiKhoanID);
            if (!string.IsNullOrEmpty(bienSoXe))
            {
                txt_TX_BienSoXe.Text = bienSoXe;
            }
            else
            {
                txt_TX_BienSoXe.Text = "Chưa có xe";
            }
        }

        private void demThoiGian(object sender, EventArgs e)
        {
            capNhatThoiGian(); // Cập nhật thời gian mỗi giây
        }
        private void capNhatThoiGian()
        {
            DateTime thoiGian = DateTime.Now; // Lấy thời gian hiện tại
            string format = thoiGian.ToString("dd-MM-yyyy HH:mm:ss"); // Định dạng thời gian
            lb_thGian.Text = format; // Cập nhật nội dung của Label

            string format_Ngay = thoiGian.ToString("yyyy-MM-dd");
            lb_TX_thGianDD.Text = format_Ngay;

            string format_GioPhut = thoiGian.ToString(@"HH\:mm\:ss");
            lb_TX_GioLenXe.Text = format_GioPhut;
            lb_TX_GioXuongXe.Text = format_GioPhut;

        }
        void load_cbHS_Di()
        {
            if (cbb_TX_DiemLenXe.SelectedIndex != -1)
            {
                string diemDungID = cbb_TX_DiemLenXe.SelectedValue.ToString();
                DataTable dt = dungBLL.GetListHSDD(taiKhoanID, diemDungID);
                DataRow dr = dt.NewRow();
                dr["HoTenHS"] = "Vui lòng chọn học sinh";
                dr["HocSinh_ID"] = DBNull.Value;
                dt.Rows.InsertAt(dr, 0);
                cbb_TX_HocSinh.DataSource = dt;
                cbb_TX_HocSinh.DisplayMember = "HoTenHS";
                cbb_TX_HocSinh.ValueMember = "HocSinh_ID";
            }
        }       
        void load_cbHS_Ve()
        {
            if (cbb_TX_DiemLenXe.SelectedIndex != -1)
            {
                string diemDungID = cbb_TX_DiemLenXe.SelectedValue.ToString();
                DataTable dt = dungBLL.GetListAllHSDD(taiKhoanID);
                DataRow dr = dt.NewRow();
                dr["HoTenHS"] = "Vui lòng chọn học sinh";
                dr["HocSinh_ID"] = DBNull.Value;
                dt.Rows.InsertAt(dr, 0);
                cbb_TX_HocSinh.DataSource = dt;
                cbb_TX_HocSinh.DisplayMember = "HoTenHS";
                cbb_TX_HocSinh.ValueMember = "HocSinh_ID";
            }
        }

        void load_DiemLen()
        {
            DataTable dt = dungBLL.LayDiemDungTheoTaiKhoanID(taiKhoanID);
            cbb_TX_DiemLenXe.DataSource = dt;
            cbb_TX_DiemLenXe.DisplayMember = "TenDiemDung";
            cbb_TX_DiemLenXe.ValueMember = "DiemDung_ID";
        }
        void load_DiemXuong()
        {
            DataTable dt = dungBLL.LayDiemDungTheoTaiKhoanID(taiKhoanID);
            cbb_TX_DiemXuongXe.DataSource = dt;
            cbb_TX_DiemXuongXe.DisplayMember = "TenDiemDung";
            cbb_TX_DiemXuongXe.ValueMember = "DiemDung_ID";
        }

        void load_DataGrid_Ve(string diemDanhID)
        {
            try
            {
                DataTable dt = ctddBLL.GetChiTietDiemDanhVe(diemDanhID);
                if (dt.Rows.Count > 0)
                {
                    dgv_TX_DiemDanhHocSinh.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cho điểm danh này.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        void load_DataGrid_Di(string diemDanhID)
        {
            try
            {
                DataTable dt = ctddBLL.GetChiTietDiemDanhDi(diemDanhID);
                if (dt.Rows.Count > 0)
                {
                    dgv_TX_DiemDanhHocSinh.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cho điểm danh này.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void cbb_TX_DiemLenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chb_DiemDanhDi.Checked)
            {
                if (cbb_TX_DiemLenXe.SelectedIndex != -1) // Kiểm tra xem có giá trị được chọn không
                {
                    load_cbHS_Di();
                }
                else
                {
                    // Nếu không có lựa chọn, hiển thị "Vui lòng chọn học sinh" làm mặc định
                    DataTable dt = new DataTable();
                    dt.Columns.Add("HoTenHS");
                    dt.Columns.Add("HocSinh_ID");
                    dt.Rows.Add("Vui lòng chọn học sinh", DBNull.Value);  // Thêm dòng mặc định
                    cbb_TX_HocSinh.DataSource = dt;
                    cbb_TX_HocSinh.DisplayMember = "HoTenHS";
                    cbb_TX_HocSinh.ValueMember = "HocSinh_ID";
                }
            }
            else if (chb_DiemDanhVe.Checked)
            {
                load_cbHS_Ve();
            }

        }

        private void btn_TX_TaoMoi_Click(object sender, EventArgs e)
        {
            string autoID = danhBLL.TaoID_Auto();
            txt_TX_IDDiemDanh.Text = autoID;
        }

        private void btn_TX_TaoMoiID_Click(object sender, EventArgs e)
        {
            if(chb_DiemDanhDi.Checked)
            {
                string autoID = ctddBLL.TaoIDCTDD_Di_Auto();
                txt_TX_ChiTietDiemDanhID.Text = autoID;
            }
            else if(chb_DiemDanhVe.Checked)
            {
                string autoID = ctddBLL.TaoIDCTDD_Ve_Auto();
                txt_TX_ChiTietDiemDanhID.Text = autoID;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chuyến đi hoặc về!!!");
            }

        }
        private void chb_DiemDanhDi_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_DiemDanhDi.Checked)
            {
                chb_DiemDanhVe.Checked = false;
            }
        }

        private void chb_DiemDanhVe_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_DiemDanhVe.Checked)
            {
                chb_DiemDanhDi.Checked = false;
            }
        }

        private void btn_TX_LamMoiDD_Click(object sender, EventArgs e)
        {
            txt_TX_IDDiemDanh.Text = "";
        }

        private void btn_TX_LuuLaiDD_Click(object sender, EventArgs e)
        {
            try
            {
                string diemDanhID = txt_TX_IDDiemDanh.Text;
                string bienSoXe = txt_TX_BienSoXe.Text;
                string busID = taiXeBLL.GetBusIDByBienSoXe(bienSoXe); 
                string ngayDiemDanh = lb_TX_thGianDD.Text;
                string trangThai = "Chưa hoàn thành";

                if (danhBLL.ThemDiemDanh(diemDanhID, busID, ngayDiemDanh, trangThai))
                {
                    MessageBox.Show("Đã lưu");
                }
                else
                {
                    MessageBox.Show("Chưa lưu");
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void frm_TX_DiemDanh_Load(object sender, EventArgs e)
        {
            load_BienSoXe();
            load_DiemLen();
            load_DiemXuong();
        }

        private void btn_TX_HoanThanh_Click(object sender, EventArgs e)
        {
            try
            {
                string diemDanhID = txt_TX_IDDiemDanh.Text;
                string trangThai = "Hoàn thành";
                if (danhBLL.CapNhatTrangThai(diemDanhID, trangThai))
                {
                    MessageBox.Show("Trạng thái đã được cập nhật thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật trạng thái.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo");
            }
        }

        private void btn_TX_XoaDD_Click(object sender, EventArgs e)
        {
            try
            {
                string diemDanhID = txt_TX_IDDiemDanh.Text; 
                if (danhBLL.XoaDiemDanh(diemDanhID))
                {
                    MessageBox.Show("Đã xóa điểm danh thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể xóa điểm danh.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo");
            }
        }

        private void btn_TX_LamMoi_Click(object sender, EventArgs e)
        {
            txt_TX_ChiTietDiemDanhID.Text = "";
        }

        private void btn_TX_DiemDanh_Click(object sender, EventArgs e)
        {
            if (chb_DiemDanhDi.Checked)
            {
                try
                {
                    string ctdddID = txt_TX_ChiTietDiemDanhID.Text;
                    string diemDanhID = txt_TX_IDDiemDanh.Text;
                    string hocSinhID = cbb_TX_HocSinh.SelectedValue.ToString();
                    string diemLenXe = cbb_TX_DiemLenXe.Text;
                    string diemXuongXe = DBNull.Value.ToString(); ;
                    string gioLenXe = lb_TX_GioLenXe.Text;
                    string gioXuongXe = DBNull.Value.ToString(); ;
                    string trangThai = "Có mặt";
                    bool result = ctddBLL.AddChiTietDiemDanhDi(ctdddID, diemDanhID, hocSinhID, diemLenXe, diemXuongXe, gioLenXe, gioXuongXe, trangThai);
                    TimeSpan gioLen;
                    if (!TimeSpan.TryParse(gioLenXe, out gioLen))
                    {
                        MessageBox.Show("Giờ lên xe không hợp lệ.");
                        return;
                    }
                    if (result)
                    {
                        MessageBox.Show("Chi tiết điểm danh đi đã được thêm.");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thêm chi tiết điểm danh đi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else if(chb_DiemDanhVe.Checked)
            {
                try
                {
                    string ctddvID = txt_TX_ChiTietDiemDanhID.Text;
                    string diemDanhID = txt_TX_IDDiemDanh.Text;
                    string hocSinhID = cbb_TX_HocSinh.SelectedValue.ToString();
                    string diemLenXe = cbb_TX_DiemLenXe.Text;
                    string diemXuongXe = DBNull.Value.ToString(); ;
                    string gioLenXe = lb_TX_GioLenXe.Text;
                    string gioXuongXe = DBNull.Value.ToString(); ;
                    string trangThai = "Có mặt";
                    bool result = ctddBLL.AddChiTietDiemDanhVe(ctddvID, diemDanhID, hocSinhID, diemLenXe, diemXuongXe, gioLenXe, gioXuongXe, trangThai);
                    TimeSpan gioLen;
                    if (!TimeSpan.TryParse(gioLenXe, out gioLen))
                    {
                        MessageBox.Show("Giờ lên xe không hợp lệ.");
                        return;
                    }
                    if (result)
                    {
                        MessageBox.Show("Chi tiết điểm danh về đã được thêm.");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thêm chi tiết điểm danh về.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else if(txt_TX_ChiTietDiemDanhID.Text=="")
            {
                MessageBox.Show("Vui lòng không để ID chi tiết điểm danh trống!!!");
                txt_TX_ChiTietDiemDanhID.Focus();
            }
        }

        private void btn_TX_CapNhat_Click(object sender, EventArgs e)
        {
            if (chb_DiemDanhDi.Checked)
            {
                try
                {
                    string ctdddID = txt_TX_ChiTietDiemDanhID.Text;  
                    string diemXuongXe = cbb_TX_DiemXuongXe.Text;    
                    string gioXuongXe = lb_TX_GioXuongXe.Text;    
                    TimeSpan gioXuong;
                    if (!TimeSpan.TryParse(gioXuongXe, out gioXuong))
                    {
                        MessageBox.Show("Giờ xuống xe không hợp lệ.");
                        return;
                    }
                    bool result = ctddBLL.UpdateChiTietDiemDanhDi(ctdddID, diemXuongXe, gioXuong.ToString(@"hh\:mm\:ss"));
                    if (result)
                    {
                        MessageBox.Show("Cập nhật chi tiết điểm danh đi thành công.");
                        txt_TX_ChiTietDiemDanhID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi cập nhật chi tiết điểm danh đi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else if (chb_DiemDanhVe.Checked)
            {
                try
                {
                    string ctddvID = txt_TX_ChiTietDiemDanhID.Text;
                    string diemXuongXe = cbb_TX_DiemXuongXe.Text;
                    string gioXuongXe = lb_TX_GioXuongXe.Text;
                    TimeSpan gioXuong;
                    if (!TimeSpan.TryParse(gioXuongXe, out gioXuong))
                    {
                        MessageBox.Show("Giờ xuống xe không hợp lệ.");
                        return;
                    }
                    bool result = ctddBLL.UpdateChiTietDiemDanhVe(ctddvID, diemXuongXe, gioXuong.ToString(@"hh\:mm\:ss"));
                    if (result)
                    {
                        MessageBox.Show("Cập nhật chi tiết điểm danh về thành công.");
                        txt_TX_ChiTietDiemDanhID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi cập nhật chi tiết điểm danh về.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }


        }
        private void btn_TX_Xoa_Click(object sender, EventArgs e)
        {
            if(chb_DiemDanhDi.Checked)
            {
                try
                {
                    string ctdddID = txt_TX_ChiTietDiemDanhID.Text;
                    if (!string.IsNullOrEmpty(ctdddID))
                    {
                        bool result = ctddBLL.DeleteChiTietDiemDanhDi(ctdddID);
                        if (result)
                        {
                            MessageBox.Show("Chi tiết điểm danh đi đã được xóa.");
                            txt_TX_ChiTietDiemDanhID.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy ID chi tiết điểm danh để xóa.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập ID chi tiết điểm danh.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            if (chb_DiemDanhVe.Checked)
            {
                try
                {
                    string ctddvID = txt_TX_ChiTietDiemDanhID.Text;
                    if (!string.IsNullOrEmpty(ctddvID))
                    {
                        bool result = ctddBLL.DeleteChiTietDiemDanhVe(ctddvID);
                        if (result)
                        {
                            MessageBox.Show("Chi tiết điểm danh về đã được xóa.");
                            txt_TX_ChiTietDiemDanhID.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy ID chi tiết điểm danh để xóa.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập ID chi tiết điểm danh.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void btn_TX_Vang_Click(object sender, EventArgs e)
        {
            if (chb_DiemDanhDi.Checked)
            {
                try
                {
                    string ctdddID = txt_TX_ChiTietDiemDanhID.Text;
                    string diemDanhID = txt_TX_IDDiemDanh.Text;
                    string hocSinhID = cbb_TX_HocSinh.SelectedValue.ToString();
                    string trangThai = "Vắng";
                    bool result = ctddBLL.XuLyVangDi(ctdddID, diemDanhID, hocSinhID, trangThai);
                    if (result)
                    {
                        MessageBox.Show("Xử lý vắng đi thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xử lý.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else if (chb_DiemDanhVe.Checked)
            {
                try
                {
                    string ctddvID = txt_TX_ChiTietDiemDanhID.Text;
                    string diemDanhID = txt_TX_IDDiemDanh.Text;
                    string hocSinhID = cbb_TX_HocSinh.SelectedValue.ToString();
                    string trangThai = "Vắng";
                    bool result = ctddBLL.XuLyVangVe(ctddvID, diemDanhID, hocSinhID, trangThai);
                    if (result)
                    {
                        MessageBox.Show("Xử lý vắng về thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xử lý.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_TX_CapNhatDanhSach_Click(object sender, EventArgs e)
        {
            string IDDD = txt_TX_IDDiemDanh.Text;
            if (chb_DiemDanhDi.Checked)
            {
                load_DataGrid_Di(IDDD);
            }
            else if (chb_DiemDanhVe.Checked)
            {
                load_DataGrid_Ve(IDDD);
            }
        }

        private void dgv_TX_DiemDanhHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(chb_DiemDanhDi.Checked)
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = dgv_TX_DiemDanhHocSinh.Rows[e.RowIndex];
                        string IDCT = row.Cells["CTDDD_ID"].Value.ToString();
                        string hocSinhID = row.Cells["HocSinh_ID"].Value.ToString();
                        string hoTenHS = ctddBLL.GetHocSinhNameByID(hocSinhID);
                        string diemLenXe = row.Cells["DiemLenXe"].Value.ToString();
                        string diemXuongXe = row.Cells["DiemXuongXe"].Value.ToString();
                        txt_TX_ChiTietDiemDanhID.Text = IDCT;
                        cbb_TX_HocSinh.SelectedValue = hocSinhID;
                        cbb_TX_HocSinh.Text = hoTenHS;
                        cbb_TX_DiemLenXe.Text = diemLenXe;
                        cbb_TX_DiemXuongXe.Text = diemXuongXe;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            if (chb_DiemDanhVe.Checked)
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = dgv_TX_DiemDanhHocSinh.Rows[e.RowIndex];
                        string IDCT = row.Cells["CTDDV_ID"].Value.ToString();
                        string hocSinhID = row.Cells["HocSinh_ID"].Value.ToString();
                        string hoTenHS = ctddBLL.GetHocSinhNameByID(hocSinhID);
                        string diemLenXe = row.Cells["DiemLenXe"].Value.ToString();
                        string diemXuongXe = row.Cells["DiemXuongXe"].Value.ToString();
                        txt_TX_ChiTietDiemDanhID.Text = IDCT;
                        cbb_TX_HocSinh.SelectedValue = hocSinhID;
                        cbb_TX_HocSinh.Text = hoTenHS;
                        cbb_TX_DiemLenXe.Text = diemLenXe;
                        cbb_TX_DiemXuongXe.Text = diemXuongXe;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
