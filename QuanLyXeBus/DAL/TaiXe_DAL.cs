using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyXeBus.DataAccess;

namespace QuanLyXeBus.DAL
{
    internal class TaiXe_DAL
    {
        private DataConnect conn;

        public TaiXe_DAL()
        {
            conn = new DataConnect();
        }
        // Lấy tất cả tài xế
        public DataTable GetAllTaiXe()
        {
            string sql = "EXEC GetTaiKhoanTaiXe";  // Gọi stored procedure

            // Không cần tham số đầu vào trong trường hợp này, nên array tham số là rỗng.
            return conn.getTable(sql);  // Gọi phương thức getTable của DataConnect để thực thi
        }
        // Kiểm tra nếu tài khoản đã tồn tại
        public bool IsTaiKhoanExist(string taiKhoanID)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TaiKhoan_ID = @TaiKhoanID";
            SqlParameter[] parameters = { new SqlParameter("@TaiKhoanID", taiKhoanID) };
            return (int)conn.getScalar(query, parameters) > 0;  // Sử dụng getScalar để kiểm tra sự tồn tại
        }

        // Thêm tài xế
        public int AddTaiXe(string taiKhoanID, string loaiTK_ID, string hoTenTX, string giayPhepLaiXe, string trangThai, string soDT, string email)
        {
            string sql = "EXEC InsertTaiKhoanAndTaiXet @TaiKhoanID, @LoaiTK_ID, @HoTenTX, @GiayPhepLaiXe, @TrangThai, @SoDT, @Email";

            // Các tham số SQL
            SqlParameter[] parameters = {
                new SqlParameter("@TaiKhoanID", taiKhoanID),
                new SqlParameter("@LoaiTK_ID", loaiTK_ID),
                new SqlParameter("@HoTenTX", hoTenTX),
                new SqlParameter("@GiayPhepLaiXe", giayPhepLaiXe),
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@SoDT", soDT),
                new SqlParameter("@Email", email)
            };

            return conn.getNonQuery(sql, parameters);
        }

        // Xóa tài xế
        public void DeleteTaiXe(string taiKhoanID)
        {
            try
            {
                string deleteTaiXeQuery = "DELETE FROM TaiXe WHERE TaiKhoan_ID = @TaiKhoanID";
                SqlParameter[] deleteTaiXeParams = { new SqlParameter("@TaiKhoanID", taiKhoanID) };
                conn.getNonQuery(deleteTaiXeQuery, deleteTaiXeParams);

                string deleteTaiKhoanQuery = "DELETE FROM TaiKhoan WHERE TaiKhoan_ID = @TaiKhoanID";
                SqlParameter[] deleteTaiKhoanParams = { new SqlParameter("@TaiKhoanID", taiKhoanID) };
                conn.getNonQuery(deleteTaiKhoanQuery, deleteTaiKhoanParams);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa tài xế: " + ex.Message);
            }
        }

        // Cập nhật tài xế
        public int UpdateTaiXe(string taiKhoanID, string loaiTK_ID, string hoTenTX,
                string giayPhepLaiXe, string trangThai, string soDT, string email)
        {
            // Câu lệnh SQL gọi stored procedure
            string sql = "EXEC UpdateTaiKhoanAndTaiXe @TaiKhoanID, @LoaiTK_ID, @HoTenTX, @GiayPhepLaiXe, @TrangThai, @SoDT, @Email";

            // Thêm tham số cho câu lệnh SQL
            SqlParameter[] parameters = {
                new SqlParameter("@TaiKhoanID", SqlDbType.NVarChar) { Value = taiKhoanID },
                new SqlParameter("@LoaiTK_ID", SqlDbType.NVarChar) { Value = loaiTK_ID },
                new SqlParameter("@HoTenTX", SqlDbType.NVarChar) { Value = hoTenTX },
                new SqlParameter("@GiayPhepLaiXe", SqlDbType.NVarChar) { Value = giayPhepLaiXe },
                new SqlParameter("@TrangThai", SqlDbType.NVarChar) { Value = trangThai },
                new SqlParameter("@SoDT", SqlDbType.NVarChar) { Value = soDT },
                new SqlParameter("@Email", SqlDbType.NVarChar) { Value = email }
            };

            // Thực thi câu lệnh và trả về kết quả
            return conn.getNonQuery(sql, parameters);
        }

        // Tìm kiếm tài xế
        public DataTable SearchTaiXe(string timKiemTX)
        {
            try
            {
                // Câu lệnh SQL gọi stored procedure
                string sql = "EXEC SearchTaiXe @search";

                // Thêm tham số cho câu lệnh SQL
                SqlParameter[] parameters = {
                    new SqlParameter("@search", SqlDbType.NVarChar) { Value = $"%{timKiemTX}%" }
                };

                // Thực thi stored procedure và trả về DataTable kết quả
                return conn.getTable(sql, parameters);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                throw new Exception("Lỗi khi tìm kiếm tài xế: " + ex.Message);
            }
        }

        public string GetTenTaiXe(string taiKhoanID)
        {
            try
            {
                string sql = "SELECT HoTenTX FROM TaiXe WHERE TaiKhoan_ID = @TaiKhoan_ID";
                SqlParameter[] parameters = {
                new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taiKhoanID }
                };
                conn.Open();
                DataTable dt = conn.getTable(sql, parameters);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["HoTenTX"].ToString(); // Trả về tên tài xế
                }
                return null; // Không tìm thấy tài khoản
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi lấy tên tài xế", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable GetTaiXeByPhuHuynhID(string taiKhoanID)
        {
            try
            {
                string query = "EXEC GetTaiXeByPhuHuynhID @TaiKhoan_ID";
                SqlParameter[] parameters = {
                    new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taiKhoanID }
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
