using QuanLyXeBus.DAL;
using QuanLyXeBus.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.BLL
{
    internal class ChiTietHocSinh_BLL
    {
        private DataConnect conn;
        private ChiTietHocSinh_DAL dal;
        public ChiTietHocSinh_BLL()
        {
            conn = new DataConnect();
            dal = new ChiTietHocSinh_DAL();
        }

        // Tạo mã CT_DSHS_ID tự động (sử dụng dữ liệu trả về từ DAL)
        public string GenerateNewCTDSHSID(string prefix)
        {
            DataTable dt = dal.GetLastCTDSHSID(prefix);

            if (dt.Rows.Count > 0)
            {
                // Lấy ID cuối cùng từ kết quả
                string lastID = dt.Rows[0]["CT_DSHS_ID"].ToString();

                // Tách phần số từ mã cuối cùng và tăng giá trị lên
                int newIDNumber = int.Parse(lastID.Substring(prefix.Length)) + 1;

                // Trả về mã mới với định dạng: <prefix>XXX
                return prefix + newIDNumber.ToString("D3");
            }
            else
            {
                // Nếu không có dữ liệu nào thì bắt đầu với 001
                return prefix + "001";
            }
        }

        public DataTable GetAllChiTietDanhSachHocSinh()
        {
            return dal.GetAllChiTietDanhSachHocSinh();  // Trả về toàn bộ dữ liệu từ bảng
        }

        // Lấy danh sách XeBus
        public DataTable GetXeBusList()
        {
            return dal.GetXeBusList();
        }

        // Lấy danh sách HocSinh
        public DataTable GetHocSinhList()
        {
            return dal.GetHocSinhList();
        }

        public DataTable GetHocSinhChuaCoXeBus()
        {
            return dal.GetHocSinhChuaCoXeBus();
        }

        // Tìm kiếm ChiTietDanhSachHocSinh
        public DataTable SearchChiTietHocSinh(string search)
        {
            return dal.SearchChiTietHocSinh(search);
        }

        // Thêm một ChiTietDanhSachHocSinh
        public bool AddChiTietHocSinh(string CT_DSHS_ID, string Bus_ID, string HocSinh_ID)
        {
            int result = dal.AddChiTietHocSinh(CT_DSHS_ID, Bus_ID, HocSinh_ID);  // Thêm dữ liệu vào cơ sở dữ liệu
            return result > 0;  // Nếu kết quả trả về > 0 tức là thêm thành công
        }

        // Xóa một ChiTietDanhSachHocSinh
        public bool DeleteChiTietHocSinh(string CT_DSHS_ID)
        {
            int result = dal.DeleteChiTietHocSinh(CT_DSHS_ID);  // Xóa dữ liệu khỏi cơ sở dữ liệu
            return result > 0;  // Nếu kết quả trả về > 0 tức là xóa thành công
        }

    }
}
