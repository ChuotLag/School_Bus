using QuanLyXeBus.DAL;
using QuanLyXeBus.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.BLL
{
    internal class ThongKe_BLL
    {
        private ThongKe_DAL thongKeDal;

        public ThongKe_BLL()
        {
            thongKeDal = new ThongKe_DAL(); // Khởi tạo đối tượng DAL
        }

        // Phương thức lấy danh sách học sinh
        public List<HocSinh> GetHocSinhList()
        {
            return thongKeDal.GetHocSinhList(); // Gọi phương thức của DAL để lấy danh sách học sinh
        }
        // Phương thức lấy danh sách LỚP
        public List<Lop> GetLopList()
        {
            return thongKeDal.GetLopList(); // Gọi phương thức của DAL để lấy danh sách  LỚP
        }
        // Phương thức lấy danh sách học sinh theo Lop_ID
        public List<HocSinh> GetHocSinhByLop(string lopId)
        {
            return thongKeDal.GetHocSinhByLop(lopId); // Gọi phương thức của DAL để lấy danh sách học sinh theo lớp
        }
        // Phương thức lấy dữ liệu thống kê theo học sinh
        public DataTable ThongKeTheoHocSinh(string hoTenHocSinh)
        {
            return thongKeDal.ThongKeTheoHocSinh(hoTenHocSinh);
        }
        public List<TaiXe> GetTaiKhoan_IDList()
        {
            return thongKeDal.GetTaiKhoan_IDList(); // Gọi phương thức của DAL để lấy danh sách 
        }
        public DataTable ThongKeTheoTaiXe(string taiKhoanID, int thang, int nam)
        {
            return thongKeDal.ThongKeTheoTaiXe(taiKhoanID, thang, nam); // Gọi phương thức DAL
        }
        public List<string> GetBienSoXeList()
        {
            return thongKeDal.GetBienSoXeList();
        }
        public DataTable ThongKeDanhSachHocSinhTheoXe(string soXeBus, string ngayBatDau, string ngayKetThuc)
        {
            return thongKeDal.ThongKeDanhSachHocSinhTheoXe(soXeBus, ngayBatDau, ngayKetThuc); // Gọi phương thức của DAL
        }


    }
}
