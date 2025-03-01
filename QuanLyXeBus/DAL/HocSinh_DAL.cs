using QuanLyXeBus.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.DAL
{
    internal class HocSinh_DAL
    {
        private DataConnect conn;

        public HocSinh_DAL()
        {
            conn = new DataConnect();
        }

        public DataTable GetHocSinhByTaiXeID(string taiXeID)
        {
            try
            {
                string sql = "EXEC GetHocSinhByTaiXe @TaiXe_ID";
                SqlParameter[] parameters = {
                new SqlParameter("@TaiXe_ID", SqlDbType.VarChar) { Value = taiXeID }
                };
                return conn.getTable(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }
        }
        public DataTable GetDanhSachHocSinh()
        {
            string sql = "SELECT * FROM HocSinh";
            return conn.getTable(sql);
        }

        public int AddHocSinh(string hocSinhID, string hoTen, DateTime ngaySinh, string diaChi, string phuHuynhID, string lopID)
        {
            string sql = "EXEC InsertHocSinh @HocSinh_ID, @HoTenHS, @NgaySinh, @DiaChi, @PhuHuynh_ID, @Lop_ID";
            SqlParameter[] parameters = {
                new SqlParameter("@HocSinh_ID", SqlDbType.VarChar) { Value = hocSinhID },
                new SqlParameter("@HoTenHS", SqlDbType.NVarChar) { Value = hoTen },
                new SqlParameter("@NgaySinh", SqlDbType.DateTime) { Value = ngaySinh },
                new SqlParameter("@DiaChi", SqlDbType.NVarChar) { Value = diaChi },
                new SqlParameter("@PhuHuynh_ID", SqlDbType.VarChar) { Value = phuHuynhID },
                new SqlParameter("@Lop_ID", SqlDbType.VarChar) { Value = lopID }
            };

            return conn.getNonQuery(sql, parameters);  // Sử dụng phương thức getNonQuery của DataConnect
        }

        // Sửa học sinh
        public int UpdateHocSinh(string hocSinhID, string hoTen, DateTime ngaySinh, string diaChi, string phuHuynhID, string lopID)
        {
            string sql = "EXEC UpdateHocSinh @HocSinh_ID, @HoTenHS, @NgaySinh, @DiaChi, @PhuHuynh_ID, @Lop_ID";
            SqlParameter[] parameters = {
                new SqlParameter("@HocSinh_ID", SqlDbType.VarChar) { Value = hocSinhID },
                new SqlParameter("@HoTenHS", SqlDbType.NVarChar) { Value = hoTen },
                new SqlParameter("@NgaySinh", SqlDbType.DateTime) { Value = ngaySinh },
                new SqlParameter("@DiaChi", SqlDbType.NVarChar) { Value = diaChi },
                new SqlParameter("@PhuHuynh_ID", SqlDbType.VarChar) { Value = phuHuynhID },
                new SqlParameter("@Lop_ID", SqlDbType.VarChar) { Value = lopID }
            };

            return conn.getNonQuery(sql, parameters);  // Sử dụng phương thức getNonQuery của DataConnect
        }

        // Xóa học sinh
        public int DeleteHocSinh(string hocSinhID)
        {
            string sql = "EXEC DeleteHocSinh @HocSinh_ID";  // Gọi stored procedure DeleteHocSinh
            SqlParameter[] parameters = {
                new SqlParameter("@HocSinh_ID", SqlDbType.VarChar) { Value = hocSinhID }
            };

            // Gọi phương thức getNonQuery để thực thi stored procedure
            return conn.getNonQuery(sql, parameters);  // Trả về true nếu xóa thành công
        }

        // Tìm kiếm học sinh
        public DataTable SearchHocSinh(string searchKeyword)
        {
            string sql = "EXEC SearchHocSinh @SearchKeyword";  // Gọi stored procedure SearchHocSinh
            SqlParameter[] parameters = {
                new SqlParameter("@SearchKeyword", SqlDbType.NVarChar) { Value = "%" + searchKeyword + "%" }  // Thêm dấu % vào từ khóa tìm kiếm
            };

            // Gọi phương thức getTable để thực thi stored procedure và lấy kết quả dưới dạng DataTable
            return conn.getTable(sql, parameters);  // Trả về DataTable chứa kết quả tìm kiếm
        }

        // Lấy danh sách phụ huynh
        public DataTable GetDanhSachPhuHuynh()
        {
            string sql = "SELECT TaiKhoan_ID, HoTenPH FROM PhuHuynh";
            return conn.getTable(sql);  // Gọi phương thức getTable của DataConnect
        }

        // Lấy danh sách lớp
        public DataTable GetDanhSachLop()
        {
            string sql = "SELECT Lop_ID, TenLop FROM Lop";
            return conn.getTable(sql);  // Gọi phương thức getTable của DataConnect
        }
        public DataTable GetHocSinhByPhuHuynh(string phuHuynhID)
        {
            try
            {
                string query = "EXEC GetHocSinhByPhuHuynh @PhuHuynh_ID";
                SqlParameter[] parameters = {
                    new SqlParameter("@PhuHuynh_ID", SqlDbType.VarChar) { Value = phuHuynhID }
                };

                return conn.getTable(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }
        }


    }
}
