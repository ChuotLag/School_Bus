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
    internal class DiemDanh_DAL
    {
        private DataConnect conn;

        public DiemDanh_DAL()
        {
            conn = new DataConnect();
        }
        public DataTable GetLastDiemDanhID(string ma)
        {
            string sql = "select top 1 * from DiemDanh where DiemDanh_ID like @ma order by DiemDanh_ID desc";
            SqlParameter[] parameters = {
            new SqlParameter("@ma", SqlDbType.VarChar) { Value = ma + "%" }
        };
            return conn.getTable(sql, parameters);
        }

        public bool KiemTraTrungMaCTDD_Di(string ma)
        {
            string chuoiTV = "SELECT COUNT(*) FROM ChiTietDiemDanhDi WHERE CTDDD_ID = @ma";
            SqlParameter[] parameters = {
            new SqlParameter("@ma", SqlDbType.VarChar) { Value = ma }
            };

            int count = (int)conn.getScalar(chuoiTV, parameters);
            return count == 0; 
        }

        public bool KiemTraTrungMaCTDD_Ve(string ma)
        {
            string chuoiTV = "SELECT COUNT(*) FROM ChiTietDiemDanhVe WHERE CTDDV_ID = @ma";
            SqlParameter[] parameters = {
            new SqlParameter("@ma", SqlDbType.VarChar) { Value = ma }
            };

            int count = (int)conn.getScalar(chuoiTV, parameters);
            return count == 0;
        }

        public int ThemDiemDanh(string diemDanhID, string busID, string ngayDiemDanh, string trangThai)
        {
            string sql = "EXEC InsertDiemDanh @DiemDanh_ID, @Bus_ID, @NgayDiemDanh, @TrangThai";
            SqlParameter[] parameters = {
            new SqlParameter("@DiemDanh_ID", SqlDbType.VarChar) { Value = diemDanhID },
            new SqlParameter("@Bus_ID", SqlDbType.VarChar) { Value = busID },
            new SqlParameter("@NgayDiemDanh", SqlDbType.DateTime) { Value = DateTime.Parse(ngayDiemDanh) },
            new SqlParameter("@TrangThai", SqlDbType.NVarChar) { Value = trangThai }
        };

            return conn.getNonQuery(sql, parameters);
        }

        public bool KiemTraMaDDTrung(string diemDanhID)
        {
            string sql = "SELECT COUNT(*) FROM DiemDanh WHERE DiemDanh_ID = @DiemDanh_ID";
            SqlParameter[] parameters = {
            new SqlParameter("@DiemDanh_ID", SqlDbType.VarChar) { Value = diemDanhID }
        };

            int count = (int)conn.getScalar(sql, parameters);
            return count > 0;
        }
        public bool CapNhatTrangThai(string diemDanhID, string trangThai)
        {
            string sql = "EXEC UpdateDiemDanhTrangThai @DiemDanh_ID, @TrangThai";
            SqlParameter[] parameters = {
            new SqlParameter("@DiemDanh_ID", SqlDbType.VarChar) { Value = diemDanhID },
            new SqlParameter("@TrangThai", SqlDbType.NVarChar) { Value = trangThai }
            };
            int result = conn.getNonQuery(sql, parameters);
            return result > 0;
        }
        public bool XoaDiemDanh(string diemDanhID)
        {
            string sql = "EXEC DeleteDiemDanh @DiemDanh_ID";
            SqlParameter[] parameters = {
            new SqlParameter("@DiemDanh_ID", SqlDbType.VarChar) { Value = diemDanhID }
            };
            int result = conn.getNonQuery(sql, parameters);
            return result > 0;
        }



    }
}
