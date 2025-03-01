using QuanLyXeBus.DAL;
using QuanLyXeBus.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.BLL
{
    internal class DiemDanhTaiXe_BLL
    {
        private DiemDanhTaiXe_DAL dal;

        public DiemDanhTaiXe_BLL()
        {
            dal = new DiemDanhTaiXe_DAL();
        }
        // hàm tạo mã điểm danh tài xế tự động
        public string TaoID_Auto()
        {
            string Ma = "DDTX";  // Tiền tố mặc định cho DiemDanhTX_ID
            DataTable dt = dal.GetLastDiemDanhTX_ID(Ma);  // Gọi DAL để lấy mã điểm danh tài xế mới nhất

            if (dt.Rows.Count == 0)
            {
                Ma += "001";  // Nếu không có dữ liệu, bắt đầu từ "DDTX001"
            }
            else
            {
                string sttmax = dt.Rows[0]["DiemDanhTX_ID"].ToString();

                // Lấy 3 ký tự từ vị trí thứ 5 trở đi (giả sử mã là "DDTXxxx")
                string sttSubstring = sttmax.Substring(4, 3);

                // Kiểm tra xem chuỗi có phải là số không trước khi chuyển đổi
                if (int.TryParse(sttSubstring, out int stt))
                {
                    stt += 1;  // Tăng số lên 1

                    // Tạo mã theo số tự động tăng, đảm bảo 3 chữ số
                    Ma += stt.ToString("D3");  // D3 sẽ đảm bảo có ít nhất 3 chữ số (ví dụ: 001, 002, 100, 999, ...)
                }
                else
                {
                    // Nếu không thể chuyển đổi thành số, bắt đầu lại từ "001"
                    Ma += "001";
                }
            }

            return Ma;
        }

        public List<CaLamTaiXe> GetCaLamTaiXelist()
        {
            return dal.GetCaLamTaiXeList(); // Gọi phương thức của DAL để lấy danh sách học sinh
        }

        //phương thức lưu thông tin điểm danh tài xế
        // Phương thức gọi DAL để lưu điểm danh tài xế
        public void LuuDiemDanhTaiXe(string diemDanhTX_ID, string taiKhoanID, string soXeBus, DateTime ngay, string caLamID, string trangThai)
        {
            dal.LuuDiemDanhTaiXe(diemDanhTX_ID, taiKhoanID, soXeBus, ngay, caLamID, trangThai);
        }
        // Gọi DAL để lấy danh sách điểm danh tài xế
        public DataTable GetDiemDanhByTaiKhoanID(string taiKhoanID)
        {
            return dal.GetDiemDanhByTaiKhoanID(taiKhoanID);
        }
    }
}