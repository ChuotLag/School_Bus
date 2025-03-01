using QuanLyXeBus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyXeBus.DAL
{
    internal class PhuHuynh_DAL
    {
        private DataConnect conn;

        public PhuHuynh_DAL()
        {
            conn = new DataConnect();
        }

        
        public DataTable GetAllPhuHuynh()
        {
            string sql = "EXEC GetTaiKhoanPhuHuynh";  // Gọi stored procedure GetTaiKhoanPhuHuynh
            return conn.getTable(sql);  // Gọi phương thức getTable để lấy kết quả trả về là DataTable
        }

        public bool IsTaiKhoanExist(string taiKhoanID)
        {
            string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TaiKhoan_ID = @TaiKhoanID";
            SqlParameter[] parameters = { new SqlParameter("@TaiKhoanID", taiKhoanID) };
            return (int)conn.getScalar(sql, parameters) > 0;  // Sử dụng getScalar để kiểm tra sự tồn tại
        }

        // Phương thức thêm phụ huynh
        public int AddPhuHuynh(string taiKhoanID, string matKhau, string loaiTK_ID, string hoTenPH, string email, string soDT)
        {
            string sql = "EXEC InsertTaiKhoanPhuHuynh @TaiKhoanID, @MatKhau, @LoaiTK_ID, @HoTenPH, @Email, @SoDT";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TaiKhoanID", SqlDbType.NVarChar) { Value = taiKhoanID },
                new SqlParameter("@MatKhau", SqlDbType.NVarChar) { Value = matKhau },
                new SqlParameter("@LoaiTK_ID", SqlDbType.NVarChar) { Value = loaiTK_ID },
                new SqlParameter("@HoTenPH", SqlDbType.NVarChar) { Value = hoTenPH },
                new SqlParameter("@Email", SqlDbType.NVarChar) { Value = email },
                new SqlParameter("@SoDT", SqlDbType.NVarChar) { Value = soDT }
                    };
            return conn.getNonQuery(sql, parameters); // ExecuteNonQuery thực thi câu lệnh SQL không trả về kết quả
        }

        // Phương thức cập nhật phụ huynh
        public int UpdatePhuHuynh(string taiKhoanID, string matKhau, string loaiTK_ID, string hoTenPH, string email, string soDT)
        {
            string sql = "EXEC UpdateTaiKhoanPhuHuynh @TaiKhoanID, @MatKhau, @LoaiTK_ID, @HoTenPH, @Email, @SoDT";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TaiKhoanID", SqlDbType.NVarChar) { Value = taiKhoanID },
                new SqlParameter("@MatKhau", SqlDbType.NVarChar) { Value = matKhau },
                new SqlParameter("@LoaiTK_ID", SqlDbType.NVarChar) { Value = loaiTK_ID },
                new SqlParameter("@HoTenPH", SqlDbType.NVarChar) { Value = hoTenPH },
                new SqlParameter("@Email", SqlDbType.NVarChar) { Value = email },
                new SqlParameter("@SoDT", SqlDbType.NVarChar) { Value = soDT }
            };
            return conn.getNonQuery(sql, parameters);
        }

        // Phương thức xóa phụ huynh
        public int DeletePhuHuynh(string taiKhoanID)
        {
            string sql = "EXEC DeleteTaiKhoanPhuHuynh @TaiKhoanID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TaiKhoanID", SqlDbType.NVarChar) { Value = taiKhoanID }
            };
            return conn.getNonQuery(sql, parameters);
        }

        // Phương thức tìm kiếm phụ huynh
        public DataTable SearchPhuHuynh(string searchTerm)
        {
            string sql = "EXEC SearchTaiKhoanPhuHuynh @SearchTerm";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SearchTerm", SqlDbType.NVarChar) { Value = searchTerm }
            };
            return conn.getTable(sql, parameters);
        }
        public string GetTenPH(string taiKhoanID)
        {
            try
            {
                string sql = "SELECT HoTenPH FROM PhuHuynh WHERE TaiKhoan_ID = @TaiKhoan_ID";
                SqlParameter[] parameters = {
                new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taiKhoanID }
                };
                conn.Open();
                DataTable dt = conn.getTable(sql, parameters);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["HoTenPH"].ToString(); 
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi lấy tên phụ huynh", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable GetEmailsPhuHuynhTheoTaiXe(string taiKhoanID)
        {
            try
            {
                string query = "EXEC GetEmailPhuHuynhByTaiXeID @TaiKhoan_ID";
                SqlParameter[] parameters = {
                    new SqlParameter("@TaiKhoan_ID", taiKhoanID)
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
