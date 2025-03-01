using QuanLyXeBus.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.DataAccess
{
    internal class TaiKhoan_DAL
    {
        private DataConnect conn;

        public TaiKhoan_DAL()
        {
            conn = new DataConnect();
        }
        // Thêm tài khoản mới
        public bool ThemTaiKhoan(TaiKhoan taiKhoan, HocSinh hocSinh)
        {
            try
            {
                string sql = "INSERT INTO TaiKhoan (TaiKhoan_ID, MatKhau, LoaiTK_ID) VALUES (@TaiKhoan_ID, @MatKhau, @LoaiTK_ID)";

                // Tạo các tham số SQL
                SqlParameter[] parameters = {
                new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taiKhoan.TaiKhoan_ID },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = taiKhoan.MatKhau },
                new SqlParameter("@LoaiTK_ID", SqlDbType.VarChar) { Value = taiKhoan.LoaiTK_ID }
                };

                // Gọi phương thức getNonQuery để thực thi câu lệnh SQL
                conn.Open();
                int result = conn.getNonQuery(sql, parameters); // Truyền chuỗi SQL và tham số vào đây
                return result > 0; // Trả về true nếu thêm thành công
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi thêm tài khoản", ex);
            }
            finally
            {
                conn.Close();
            }
        }


        // Xóa tài khoản
        public bool XoaTaiKhoan(string taiKhoanID)
        {
            try
            {
                string sql = "DELETE FROM TaiKhoan WHERE TaiKhoan_ID = @TaiKhoan_ID";
                SqlParameter[] parameters = {
                new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taiKhoanID }
                };
                conn.Open();
                int result = conn.getNonQuery(sql, parameters); 
                return result > 0; 
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi xóa tài khoản", ex);
            }
            finally
            {
                conn.Close();
            }
        }


        // Sửa tài khoản
        public bool SuaTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                string sql = "UPDATE TaiKhoan SET MatKhau = @MatKhau, LoaiTK_ID = @LoaiTK_ID WHERE TaiKhoan_ID = @TaiKhoan_ID";

                // Tạo các tham số SQL
                SqlParameter[] parameters = {
                new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taiKhoan.TaiKhoan_ID },
                new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = taiKhoan.MatKhau },
                new SqlParameter("@LoaiTK_ID", SqlDbType.VarChar) { Value = taiKhoan.LoaiTK_ID }
                };   
                conn.Open();
                int result = conn.getNonQuery(sql, parameters); 
                return result > 0;
            }
            catch (Exception ex)
            {
                // Log error if necessary
                throw new ApplicationException("Lỗi khi cập nhật tài khoản", ex);
            }
            finally
            {
                conn.Close();
            }
        }


        // Lấy danh sách tài khoản
        public DataTable LayDanhSachTaiKhoan()
        {
            try
            {
                string sql = "SELECT * FROM TaiKhoan";
                return conn.getTable(sql);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi lấy danh sách tài khoản", ex);
            }
        }

        // Tìm tài khoản theo ID
        public TaiKhoan TimTaiKhoanTheoID(string taiKhoanID)
        {
            try
            {
                string sql = "SELECT * FROM TaiKhoan WHERE TaiKhoan_ID = @TaiKhoan_ID";
                SqlParameter[] parameters = {
                new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taiKhoanID }
                };
                conn.Open();
                DataTable dt = conn.getTable(sql, parameters); 
                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    return new TaiKhoan
                    {
                        TaiKhoan_ID = row["TaiKhoan_ID"].ToString(),
                        MatKhau = row["MatKhau"].ToString(),
                        LoaiTK_ID = row["LoaiTK_ID"].ToString()
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi tìm tài khoản", ex);
            }
            finally
            {
                conn.Close();
            }
        }
        // Lấy tên loại tài khoản từ bảng LoaiTaiKhoan
        public string LayTenLoaiTaiKhoan(string loaiTK_ID)
        {
            try
            {
                string sql = "SELECT TenLoaiTK FROM LoaiTaiKhoan WHERE LoaiTK_ID = @LoaiTK_ID";
                SqlParameter[] parameters = {
                new SqlParameter("@LoaiTK_ID", SqlDbType.VarChar) { Value = loaiTK_ID }
            };
                conn.Open();
                DataTable dt = conn.getTable(sql, parameters);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["TenLoaiTK"].ToString(); // Trả về tên loại tài khoản
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi lấy tên loại tài khoản", ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public bool UpdateMatKhau(string taiKhoanID, string matKhauCu, string matKhauMoi)
        {
            try
            {
                string query = "EXEC UpdateMatKhau @TaiKhoan_ID, @MatKhauCu, @MatKhauMoi";
                SqlParameter[] parameters = {
                new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taiKhoanID },
                new SqlParameter("@MatKhauCu", SqlDbType.VarChar) { Value = matKhauCu },
                new SqlParameter("@MatKhauMoi", SqlDbType.VarChar) { Value = matKhauMoi }
            };

                int result = conn.getNonQuery(query, parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }
        }

    }
}
