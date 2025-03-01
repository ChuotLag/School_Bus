using QuanLyXeBus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyXeBus.Model;

namespace QuanLyXeBus.DAL
{
    internal class ThongKe_DAL
    {
        private DataConnect conn;

        public ThongKe_DAL()
        {
            conn = new DataConnect();
        }
        // Phương thức lấy danh sách học sinh từ cơ sở dữ liệu
        public List<HocSinh> GetHocSinhList()
        {
            List<HocSinh> hocSinhList = new List<HocSinh>();
            string sql = "SELECT HocSinh_ID, HoTenHS FROM HocSinh"; // Truy vấn lấy danh sách học sinh

            // Gọi phương thức getTable của DataConnect để lấy dữ liệu
            DataTable dt = conn.getTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                HocSinh hs = new HocSinh
                {
                    HocSinh_ID = row["HocSinh_ID"].ToString(),
                    HoTenHS = row["HoTenHS"].ToString()
                };
                hocSinhList.Add(hs);
            }
            return hocSinhList;
        }
        // Phương thức lấy danh sách LỚP từ cơ sở dữ liệu
        public List<Lop> GetLopList()
        {
            List<Lop> LopList = new List<Lop>();
            string sql = "SELECT Lop_ID, TenLop FROM Lop"; // Truy vấn lấy danh sách LOP
            // Gọi phương thức getTable của DataConnect để lấy dữ liệu
            DataTable dt = conn.getTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                Lop lop = new Lop
                {
                    Lop_ID = row["Lop_ID"].ToString(),
                    TenLop = row["TenLop"].ToString()
                };
                LopList.Add(lop);
            }
            return LopList;

        }
        // Phương thức lấy danh sách học sinh theo Lop_ID
        public List<HocSinh> GetHocSinhByLop(string lopId)
        {
            List<HocSinh> hocSinhList = new List<HocSinh>();
            string sql = "SELECT HocSinh_ID, HoTenHS FROM HocSinh WHERE Lop_ID = @Lop_ID"; // Truy vấn lấy danh sách học sinh theo lớp

            // Tạo SqlParameter để tránh SQL Injection
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Lop_ID", lopId)
            };

            // Gọi phương thức getTable của DataConnect để lấy dữ liệu
            DataTable dt = conn.getTable(sql, parameters);

            foreach (DataRow row in dt.Rows)
            {
                HocSinh hs = new HocSinh
                {
                    HocSinh_ID = row["HocSinh_ID"].ToString(),
                    HoTenHS = row["HoTenHS"].ToString()
                };
                hocSinhList.Add(hs);
            }
            return hocSinhList;
        }

        // Phương thức lấy dữ liệu thống kê từ stored procedure
        public DataTable ThongKeTheoHocSinh(string hoTenHocSinh)
        {
            string sql = "EXEC ThongKeHocSinhLeXuongTramTheoNgay @HoTenHS";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@HoTenHS", hoTenHocSinh)
            };

            return conn.getTable(sql, parameters); // Gọi getTable để thực thi stored procedure
        }
        //Phương thức lấy danh sách TaiKhoan_ID
        public List<TaiXe> GetTaiKhoan_IDList()
        {
            List<TaiXe> TaiKhoanIDList = new List<TaiXe>();
            string sql = "SELECT TaiKhoan_ID, HoTenTX FROM TaiXe"; // Truy vấn lấy danh sách TX

            // Gọi phương thức getTable của DataConnect để lấy dữ liệu
            DataTable dt = conn.getTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                TaiXe taiKhoanID = new TaiXe
                {
                    TaiKhoan_ID = row["TaiKhoan_ID"].ToString(),
                    HoTenTX = row["HoTenTX"].ToString()
                };
                TaiKhoanIDList.Add(taiKhoanID); // Sửa 'lop' thành 'taiKhoan'
            }

            return TaiKhoanIDList; // Sửa 'LopList' thành 'TaiKhoanIDList'
        }
        // thống kê tài xế
        public DataTable ThongKeTheoTaiXe(string taiKhoanID, int thang, int nam)
        {
            string sql = "EXEC TaiXe_TinhTongCaLamTrongThang @Thang, @Nam, @TaiKhoan_ID";

            // Tạo tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Thang", thang),
        new SqlParameter("@Nam", nam),
        new SqlParameter("@TaiKhoan_ID", taiKhoanID)
            };

            return conn.getTable(sql, parameters); // Gọi phương thức getTable để thực thi stored procedure
        }
        public List<string> GetBienSoXeList()
        {
            List<string> bienSoXeList = new List<string>();
            string sql = "SELECT SoXeBus FROM XeBus"; // Câu lệnh SQL lấy danh sách biển số xe

            // Gọi phương thức getTable của DataConnect để lấy dữ liệu
            DataTable dt = conn.getTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                bienSoXeList.Add(row["SoXeBus"].ToString());
            }

            return bienSoXeList;
        }
        public DataTable ThongKeDanhSachHocSinhTheoXe(string soXeBus, string ngayBatDau, string ngayKetThuc)
        {
            string sql = "EXEC sp_DanhSachHocSinhTheoXe @SoXeBus, @NgayBatDau, @NgayKetThuc";

            // Tạo tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@SoXeBus", soXeBus),
        new SqlParameter("@NgayBatDau", ngayBatDau),
        new SqlParameter("@NgayKetThuc", ngayKetThuc)
            };

            return conn.getTable(sql, parameters); // Gọi getTable để thực thi stored procedure và trả về kết quả
        }


    }
}
