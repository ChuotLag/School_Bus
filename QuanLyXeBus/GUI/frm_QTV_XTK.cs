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
using QuanLyXeBus.Model;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System.IO;

namespace QuanLyXeBus.view
{
    public partial class frm_QTV_XTK : Form
    {
        private ThongKe_BLL ThongKe_BLL;

        public frm_QTV_XTK()
        {
            InitializeComponent();
        }
        private void frm_QTV_XTK_Load(object sender, EventArgs e)
        {

        }

        private void btn_ThongkeTheoHocSinh_Click(object sender, EventArgs e)
        {
            if (cbb_HocSInh.SelectedValue != null)
            {
                string hoTenHocSinh = cbb_HocSInh.Text;
                string tenLopHoc = cbb_TenLopHoc.Text;

                // Lấy dữ liệu thống kê
                ThongKe_BLL thongKeBll = new ThongKe_BLL();
                DataTable data = thongKeBll.ThongKeTheoHocSinh(hoTenHocSinh);

                // Thiết lập LicenseContext cho EPPlus (dùng đầy đủ namespace để tránh mơ hồ)
                OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                // Xuất dữ liệu ra Excel
                using (var package = new OfficeOpenXml.ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("ThongKe");

                    // Ghi dữ liệu vào Excel
                    worksheet.Cells["A1"].LoadFromDataTable(data, true);
                    // Định dạng cột ngày tháng (ví dụ: cột B chứa ngày tháng)
                    worksheet.Column(2).Style.Numberformat.Format = "dd/MM/yyyy"; // Định dạng ngày tháng theo kiểu dd/MM/yyyy

                    // Lưu file Excel
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel files (*.xlsx)|*.xlsx",
                        Title = "Save Excel File",
                        FileName = $"{tenLopHoc}_{hoTenHocSinh}.xlsx"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());
                        MessageBox.Show("Xuất Excel thành công!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học sinh.");
            }
        }

        private void cbb_HocSInh_DropDown(object sender, EventArgs e)
        {
            //if (cbb_HocSInh.DataSource == null) // Chỉ tải dữ liệu nếu chưa có
            //{
            //    ThongKe_BLL = new ThongKe_BLL();  // Khởi tạo đối tượng ThongKe_BLL
            //    var hocSinhList = ThongKe_BLL.GetHocSinhList(); // Lấy danh sách học sinh từ BLL
            //    cbb_HocSInh.DataSource = hocSinhList; // Gán danh sách học sinh vào ComboBox
            //    cbb_HocSInh.DisplayMember = "HoTenHS"; // Hiển thị tên học sinh trong ComboBox
            //    cbb_HocSInh.ValueMember = "HocSinh_ID"; // Lưu trữ ID học sinh
            //}
        }

        private void cbb_TenLopHoc_DropDown(object sender, EventArgs e)
        {
            if (cbb_TenLopHoc.DataSource == null) // Chỉ tải dữ liệu nếu chưa có
            {
                ThongKe_BLL = new ThongKe_BLL();  // Khởi tạo đối tượng ThongKe_BLL
                var LopList = ThongKe_BLL.GetLopList(); // Lấy danh sách học sinh từ BLL
                cbb_TenLopHoc.DataSource = LopList; // Gán danh sách học sinh vào ComboBox
                cbb_TenLopHoc.DisplayMember = "TenLop"; // Hiển thị tên học sinh trong ComboBox
                cbb_TenLopHoc.ValueMember = "Lop_ID"; // Lưu trữ ID học sinh
            }
        }

        private void cbb_TenLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_TenLopHoc.SelectedValue != null)
            {
                string lopId = cbb_TenLopHoc.SelectedValue.ToString();

                // Lấy danh sách học sinh theo Lop_ID
                ThongKe_BLL thongKeBll = new ThongKe_BLL();
                List<HocSinh> hocSinhList = thongKeBll.GetHocSinhByLop(lopId);

                // Gắn dữ liệu vào ComboBox_HocSinh
                cbb_HocSInh.DataSource = hocSinhList;
                cbb_HocSInh.DisplayMember = "HoTenHS";
                cbb_HocSInh.ValueMember = "HocSinh_ID";
            }
        }

        private void cbb_HocSInh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbb_MaTaiXe_DropDown(object sender, EventArgs e)
        {
            if (cbb_MaTaiXe.DataSource == null) // Chỉ tải dữ liệu nếu chưa có
            {
                ThongKe_BLL = new ThongKe_BLL();  // Khởi tạo đối tượng ThongKe_BLL
                var TaiKhoanIDList = ThongKe_BLL.GetTaiKhoan_IDList(); // Lấy danh sách tài khoản (phương thức chính xác)

                if (TaiKhoanIDList != null && TaiKhoanIDList.Count > 0) // Kiểm tra danh sách không rỗng
                {
                    cbb_MaTaiXe.DataSource = TaiKhoanIDList; // Gán danh sách tài khoản vào ComboBox
                    cbb_MaTaiXe.DisplayMember = "HoTenTX"; // Hiển thị tên tài xế
                    cbb_MaTaiXe.ValueMember = "TaiKhoan_ID"; // Lưu trữ ID tài khoản
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu tài khoản để hiển thị.");
                }
            }
        }

        private void btn_ThongkeTheoTaiXe_Click(object sender, EventArgs e)
        {
            if (cbb_MaTaiXe.SelectedValue != null && Picker_MMdd.Value != null)
            {
                string taiKhoanID = cbb_MaTaiXe.SelectedValue.ToString();  // Lấy mã tài xế
                string thangNam = Picker_MMdd.Value.ToString("MMyyyy");  // Lấy tháng và năm từ Picker_MMdd
                int thang = int.Parse(thangNam.Substring(0, 2));  // Tách tháng
                int nam = int.Parse(thangNam.Substring(2, 4));  // Tách năm

                // Gọi phương thức thống kê từ BLL
                ThongKe_BLL thongKeBll = new ThongKe_BLL();
                DataTable data = thongKeBll.ThongKeTheoTaiXe(taiKhoanID, thang, nam); // Lấy dữ liệu thống kê

                // Thiết lập LicenseContext cho EPPlus
                OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                // Xuất dữ liệu ra Excel
                using (var package = new OfficeOpenXml.ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("ThongKe");

                    // Ghi dữ liệu vào Excel
                    worksheet.Cells["A1"].LoadFromDataTable(data, true);
                    worksheet.Column(2).Style.Numberformat.Format = "dd/MM/yyyy"; // Định dạng ngày tháng (nếu cần)

                    // Lưu file Excel
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel files (*.xlsx)|*.xlsx",
                        Title = "Save Excel File",
                        FileName = $"{taiKhoanID}_{thangNam}.xlsx"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());
                        MessageBox.Show("Xuất Excel thành công!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài xế và tháng/năm.");
            }
        }

        private void Picker_MMdd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbb_BienSoXe_DropDown(object sender, EventArgs e)
        {
            ThongKe_BLL thongKeBll = new ThongKe_BLL(); // Tạo đối tượng BLL

            // Lấy danh sách biển số xe từ BLL
            List<string> bienSoXeList = thongKeBll.GetBienSoXeList();

            // Xóa dữ liệu cũ trong ComboBox
            cbb_BienSoXe.Items.Clear();

            // Thêm dữ liệu mới vào ComboBox
            foreach (string soXe in bienSoXeList)
            {
                cbb_BienSoXe.Items.Add(soXe);
            }

        }

        private void btn_XTK_BS_HS_tuan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbb_BienSoXe.Text))  // Dùng cbb_BienSoXe.Text thay vì SelectedValue
            {
                try
                {
                    // Lấy dữ liệu từ ComboBox và DateTimePicker
                    string soXeBus = cbb_BienSoXe.Text;  // Lấy biển số xe từ Text của ComboBox
                    string ngayBatDau = Tu_ddMMyyyy.Value.ToString("dd/MM/yyyy"); // Ngày bắt đầu
                    string ngayKetThuc = Den_ddMMyyyy.Value.ToString("dd/MM/yyyy"); // Ngày kết thúc

                    // Gọi phương thức BLL để lấy dữ liệu
                    ThongKe_BLL thongKeBll = new ThongKe_BLL();
                    DataTable data = thongKeBll.ThongKeDanhSachHocSinhTheoXe(soXeBus, ngayBatDau, ngayKetThuc);

                    // Kiểm tra nếu có dữ liệu
                    if (data.Rows.Count > 0)
                    {
                        // Thiết lập LicenseContext cho EPPlus
                        OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                        using (var package = new ExcelPackage())
                        {
                            var worksheet = package.Workbook.Worksheets.Add("DanhSachHocSinh");

                            // Ghi tiêu đề từ DataTable và dữ liệu vào Excel
                            worksheet.Cells["A1"].LoadFromDataTable(data, true);

                            // Định dạng cột ngày tháng (ví dụ: cột C chứa ngày)
                            worksheet.Column(3).Style.Numberformat.Format = "dd/MM/yyyy"; // Định dạng ngày tháng

                            // Định dạng cột thời gian (ví dụ: cột D chứa giờ)
                            worksheet.Column(4).Style.Numberformat.Format = "hh:mm"; // Định dạng thời gian
                            worksheet.Column(5).Style.Numberformat.Format = "hh:mm";
                            // Định dạng tiêu đề cho nổi bật
                            using (var range = worksheet.Cells["A1:G1"]) // Giả định 7 cột
                            {
                                range.Style.Font.Bold = true;
                                range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                            }

                            // Hiển thị hộp thoại lưu file
                            SaveFileDialog saveFileDialog = new SaveFileDialog
                            {
                                Filter = "Excel Files (*.xlsx)|*.xlsx",
                                Title = "Lưu File Excel",
                                FileName = $"DanhSachHocSinh_{soXeBus}_{ngayBatDau.Replace("/", "")}_{ngayKetThuc.Replace("/", "")}.xlsx"
                            };

                            // Nếu người dùng chọn đường dẫn lưu file
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                // Lưu file Excel
                                File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());
                                MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn biển số xe.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
}
