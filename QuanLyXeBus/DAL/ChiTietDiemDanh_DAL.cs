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
    internal class ChiTietDiemDanh_DAL
    {
        private DataConnect conn;

        public ChiTietDiemDanh_DAL()
        {
            conn = new DataConnect();
        }

        public DataTable GetLastCTDDID_Di(string ma)
        {
            string sql = "SELECT top 1 * FROM ChiTietDiemDanhDi WHERE CTDDD_ID LIKE @ma ORDER BY CTDDD_ID DESC";
            SqlParameter[] parameters = {
            new SqlParameter("@ma", SqlDbType.VarChar) { Value = ma + "%" }
        };

            return conn.getTable(sql, parameters);
        }

        public DataTable GetLastCTDDID_Ve(string ma)
        {
            string sql = "SELECT top 1 * FROM ChiTietDiemDanhVe WHERE CTDDV_ID LIKE @ma ORDER BY CTDDV_ID DESC";
            SqlParameter[] parameters = {
            new SqlParameter("@ma", SqlDbType.VarChar) { Value = ma + "%" }
        };

            return conn.getTable(sql, parameters);
        }
        public string GetHocSinhNameByID(string hocSinhID)
        {
            string query = "SELECT HoTenHS FROM HocSinh WHERE HocSinh_ID = @HocSinh_ID";
            SqlParameter[] parameters = {
                new SqlParameter("@HocSinh_ID", SqlDbType.VarChar) { Value = hocSinhID }
            };

            DataTable dt = conn.getTable(query, parameters);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["HoTenHS"].ToString();
            }
            else
            {
                return string.Empty;
            }
        }



        public int AddChiTietDiemDanhDi(string ctdddID, string diemDanhID, string hocSinhID, string diemLenXe, string diemXuongXe, TimeSpan gioLenXe, TimeSpan? gioXuongXe, string trangThai)
        {
            string sql = "EXEC InsertChiTietDiemDanhDi @CTDDD_ID, @DiemDanh_ID, @HocSinh_ID, @DiemLenXe, @DiemXuongXe, @GioLenXe, @GioXuongXe, @TrangThai";

            SqlParameter[] parameters = {
                new SqlParameter("@CTDDD_ID", SqlDbType.VarChar) { Value = ctdddID },
                new SqlParameter("@DiemDanh_ID", SqlDbType.VarChar) { Value = diemDanhID },
                new SqlParameter("@HocSinh_ID", SqlDbType.VarChar) { Value = hocSinhID },
                new SqlParameter("@DiemLenXe", SqlDbType.NVarChar) { Value = diemLenXe ?? (object)DBNull.Value },
                new SqlParameter("@DiemXuongXe", SqlDbType.NVarChar) { Value = diemXuongXe ?? (object)DBNull.Value },
                new SqlParameter("@GioLenXe", SqlDbType.Time) { Value = gioLenXe },
                new SqlParameter("@GioXuongXe", SqlDbType.Time) { Value = gioXuongXe.HasValue ? (object)gioXuongXe.Value : DBNull.Value },
                new SqlParameter("@TrangThai", SqlDbType.NVarChar) { Value = trangThai }
            };

            return conn.getNonQuery(sql, parameters);
        }

        public int UpdateChiTietDiemDanhDi(string ctdddID, string diemXuongXe, string gioXuongXe)
        {
            string sql = "EXEC UpdateChiTietDiemDanhDi @CTDDD_ID, @DiemXuongXe, @GioXuongXe";

            SqlParameter[] parameters = {
                new SqlParameter("@CTDDD_ID", SqlDbType.VarChar) { Value = ctdddID },
                new SqlParameter("@DiemXuongXe", SqlDbType.NVarChar) { Value = diemXuongXe },
                new SqlParameter("@GioXuongXe", SqlDbType.Time) { Value = gioXuongXe ?? (object)DBNull.Value }
            };

            return conn.getNonQuery(sql, parameters);
        }
        public int AddChiTietDiemDanhVe(string ctddvID, string diemDanhID, string hocSinhID, string diemLenXe, string diemXuongXe, TimeSpan gioLenXe, TimeSpan? gioXuongXe, string trangThai)
        {
            string sql = "EXEC InsertChiTietDiemDanhVe @CTDDV_ID, @DiemDanh_ID, @HocSinh_ID, @DiemLenXe, @DiemXuongXe, @GioLenXe, @GioXuongXe, @TrangThai";

            SqlParameter[] parameters = {
                new SqlParameter("@CTDDV_ID", SqlDbType.VarChar) { Value = ctddvID },
                new SqlParameter("@DiemDanh_ID", SqlDbType.VarChar) { Value = diemDanhID },
                new SqlParameter("@HocSinh_ID", SqlDbType.VarChar) { Value = hocSinhID },
                new SqlParameter("@DiemLenXe", SqlDbType.NVarChar) { Value = diemLenXe ?? (object)DBNull.Value },
                new SqlParameter("@DiemXuongXe", SqlDbType.NVarChar) { Value = diemXuongXe ?? (object)DBNull.Value },
                new SqlParameter("@GioLenXe", SqlDbType.Time) { Value = gioLenXe },
                new SqlParameter("@GioXuongXe", SqlDbType.Time) { Value = gioXuongXe.HasValue ? (object)gioXuongXe.Value : DBNull.Value },
                new SqlParameter("@TrangThai", SqlDbType.NVarChar) { Value = trangThai }
            };

            return conn.getNonQuery(sql, parameters);
        }
        public int UpdateChiTietDiemDanhVe(string ctddvID, string diemXuongXe, string gioXuongXe)
        {
            string sql = "EXEC UpdateChiTietDiemDanhVe @CTDDV_ID, @DiemXuongXe, @GioXuongXe";

            SqlParameter[] parameters = {
                new SqlParameter("@CTDDV_ID", SqlDbType.VarChar) { Value = ctddvID },
                new SqlParameter("@DiemXuongXe", SqlDbType.NVarChar) { Value = diemXuongXe },
                new SqlParameter("@GioXuongXe", SqlDbType.Time) { Value = gioXuongXe ?? (object)DBNull.Value }
            };

            return conn.getNonQuery(sql, parameters);
        }
        public int DeleteChiTietDiemDanhDi(string ctdddID)
        {
            try
            {
                string sql = "EXEC DeleteChiTietDiemDanhDi @CTDDD_ID";
                SqlParameter[] parameters = {
                new SqlParameter("@CTDDD_ID", SqlDbType.VarChar) { Value = ctdddID }
            };
                return conn.getNonQuery(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }
        }
        public int DeleteChiTietDiemDanhVe(string ctddvID)
        {
            try
            {
                string sql = "EXEC DeleteChiTietDiemDanhVe @CTDDV_ID";
                SqlParameter[] parameters = {
                new SqlParameter("@CTDDV_ID", SqlDbType.VarChar) { Value = ctddvID }
            };
                return conn.getNonQuery(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }
        }
        public int XuLyVangDi(string ctdddID, string diemDanhID, string hocSinhID, string trangThai)
        {
            try
            {
                string sql = "EXEC XuLyVangDi @CTDDD_ID, @DiemDanh_ID, @HocSinh_ID, @TrangThai";
                SqlParameter[] parameters = {
                new SqlParameter("@CTDDD_ID", SqlDbType.VarChar) { Value = ctdddID },
                new SqlParameter("@DiemDanh_ID", SqlDbType.VarChar) { Value = diemDanhID },
                new SqlParameter("@HocSinh_ID", SqlDbType.VarChar) { Value = hocSinhID },
                new SqlParameter("@TrangThai", SqlDbType.NVarChar) { Value = trangThai }
            };
                return conn.getNonQuery(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }
        }
        public int XuLyVangVe(string ctddvID, string diemDanhID, string hocSinhID, string trangThai)
        {
            try
            {
                string sql = "EXEC XuLyVangVe @CTDDV_ID, @DiemDanh_ID, @HocSinh_ID, @TrangThai";
                SqlParameter[] parameters = {
                new SqlParameter("@CTDDV_ID", SqlDbType.VarChar) { Value = ctddvID },
                new SqlParameter("@DiemDanh_ID", SqlDbType.VarChar) { Value = diemDanhID },
                new SqlParameter("@HocSinh_ID", SqlDbType.VarChar) { Value = hocSinhID },
                new SqlParameter("@TrangThai", SqlDbType.NVarChar) { Value = trangThai }
            };
                return conn.getNonQuery(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }
        }

        public DataTable GetChiTietDiemDanhVe(string diemDanhID)
        {
            try
            {
                string sql = "EXEC GetChiTietDiemDanhVe @DiemDanh_ID";
                SqlParameter[] parameters = {
                    new SqlParameter("@DiemDanh_ID", SqlDbType.VarChar) { Value = diemDanhID }
                };
                return conn.getTable(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }
        }

        public DataTable GetChiTietDiemDanhDi(string diemDanhID)
        {
            try
            {
                string sql = "EXEC GetChiTietDiemDanhDi @DiemDanh_ID";
                SqlParameter[] parameters = {
                    new SqlParameter("@DiemDanh_ID", SqlDbType.VarChar) { Value = diemDanhID }
                };
                return conn.getTable(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }
        }





    }
}
