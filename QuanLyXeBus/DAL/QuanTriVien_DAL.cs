using QuanLyXeBus.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.DAL
{
    internal class QuanTriVien_DAL
    {
        private DataConnect conn;

        public QuanTriVien_DAL()
        {
            conn = new DataConnect();
        }

        public DataTable GetAllQuanTriVien()
        {
            string sql = "EXEC GetTaiKhoanQuanTriVien";  // Gọi stored procedure GetAllAdmins
            return conn.getTable(sql);  // Thực thi và trả về DataTable
        }
        public DataTable GetChucVu()
        {
            string sql = "SELECT * FROM ChucVu";
            return conn.getTable(sql);
        }

        public int AddQuanTriVien(string taiKhoanID, string matKhau, string loaiTaiKhoan, string hoTen, string email, string chucVu)
        {
            string sql = "EXEC AddQuanTriVien @TaiKhoan_ID, @MatKhau, @LoaiTK_ID, @HoTenQTV, @Email, @ChucVu_ID";
            SqlParameter[] parameters = {
            new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taiKhoanID },
            new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = matKhau },
            new SqlParameter("@LoaiTK_ID", SqlDbType.VarChar) { Value = loaiTaiKhoan },
            new SqlParameter("@HoTenQTV", SqlDbType.NVarChar) { Value = hoTen },
            new SqlParameter("@Email", SqlDbType.VarChar) { Value = email },
            new SqlParameter("@ChucVu_ID", SqlDbType.VarChar) { Value = chucVu }
        };

            return conn.getNonQuery(sql, parameters);
        }

        // Cập nhật quản trị viên
        public int UpdateQuanTriVien(string taiKhoanID, string matKhau, string loaiTaiKhoan, string hoTen, string email, string chucVu)
        {
            string sql = "EXEC UpdateQuanTriVien @TaiKhoan_ID, @MatKhau, @LoaiTK_ID, @HoTenQTV, @Email, @ChucVu_ID";
            SqlParameter[] parameters = {
            new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taiKhoanID },
            new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = matKhau },
            new SqlParameter("@LoaiTK_ID", SqlDbType.VarChar) { Value = loaiTaiKhoan },
            new SqlParameter("@HoTenQTV", SqlDbType.NVarChar) { Value = hoTen },
            new SqlParameter("@Email", SqlDbType.VarChar) { Value = email },
            new SqlParameter("@ChucVu_ID", SqlDbType.VarChar) { Value = chucVu }
            };

            return conn.getNonQuery(sql, parameters);
        }

        // Xóa quản trị viên
        public int DeleteQuanTriVien(string taiKhoanID)
        {
            string sql = "EXEC DeleteQuanTriVien @TaiKhoan_ID";
            SqlParameter[] parameters = {
            new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taiKhoanID }
        };

            return conn.getNonQuery(sql, parameters);
        }

        // Tìm kiếm quản trị viên
        public DataTable SearchQuanTriVien(string searchKeyword)
        {
            string sql = "EXEC SearchQuanTriVien @SearchKeyword";
            SqlParameter[] parameters = {
            new SqlParameter("@SearchKeyword", SqlDbType.NVarChar) { Value = "%" + searchKeyword + "%" }
        };

            return conn.getTable(sql, parameters);
        }
        public string GetTenQuanTriVien(string taiKhoanID)
        {
            try
            {
                string sql = "SELECT HoTenQTV FROM QuanTriVien WHERE TaiKhoan_ID = @TaiKhoan_ID";
                SqlParameter[] parameters = {
                new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taiKhoanID }
                };
                conn.Open();
                DataTable dt = conn.getTable(sql, parameters);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["HoTenQTV"].ToString(); // Trả về tên tài xế
                }
                return null; // Không tìm thấy tài khoản
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi lấy tên quản trị viên", ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
