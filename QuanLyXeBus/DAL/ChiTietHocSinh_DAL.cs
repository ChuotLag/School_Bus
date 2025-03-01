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
    internal class ChiTietHocSinh_DAL
    {
        private DataConnect conn;

        public ChiTietHocSinh_DAL()
        {
            conn = new DataConnect();
        }

        // Lấy mã CT_DSHS_ID mới nhất (Để tạo mã tự động)
        public DataTable GetLastCTDSHSID(string ma)
        {
            string sql = "select top 1 * from ChiTietDanhSachHocSinh where CT_DSHS_ID like @ma order by CT_DSHS_ID desc";
            SqlParameter[] parameters = {
            new SqlParameter("@ma", SqlDbType.VarChar) { Value = ma + "%" }
            };
            return conn.getTable1(sql, parameters);
        }

        public DataTable GetAllChiTietDanhSachHocSinh()
        {
            string sql = "SELECT * FROM ChiTietDanhSachHocSinh";
            return conn.getTable1(sql, null);  // Trả về tất cả dữ liệu của bảng
        }

        // Lấy danh sách XeBus
        public DataTable GetXeBusList()
        {
            string sql = "SELECT Bus_ID FROM XeBus";
            return conn.getTable1(sql, null);
        }

        public DataTable GetHocSinhChuaCoXeBus()
        {
            string sql = @"
                SELECT hs.HocSinh_ID, hs.HoTenHS
                FROM HocSinh hs
                LEFT JOIN ChiTietDanhSachHocSinh ctdshs 
                ON hs.HocSinh_ID = ctdshs.HocSinh_ID
                WHERE ctdshs.HocSinh_ID IS NULL";
            return conn.getTable1(sql, null);
        }


        // Lấy danh sách HocSinh
        public DataTable GetHocSinhList()
        {
            string sql = "SELECT HocSinh_ID FROM HocSinh";
            return conn.getTable1(sql, null);
        }

        // Tìm kiếm ChiTietDanhSachHocSinh
        public DataTable SearchChiTietHocSinh(string search)
        {
            string sql = "SELECT * FROM ChiTietDanhSachHocSinh WHERE CT_DSHS_ID LIKE @search OR Bus_ID LIKE @search OR HocSinh_ID LIKE @search";
            SqlParameter[] parameters = {
                new SqlParameter("@search", SqlDbType.VarChar) { Value = "%" + search + "%" }
            };
            return conn.getTable1(sql, parameters);
        }

        // Thêm một ChiTietDanhSachHocSinh
        public int AddChiTietHocSinh(string CT_DSHS_ID, string Bus_ID, string HocSinh_ID)
        {
            string sql = "INSERT INTO ChiTietDanhSachHocSinh (CT_DSHS_ID, Bus_ID, HocSinh_ID) VALUES (@CT_DSHS_ID, @Bus_ID, @HocSinh_ID)";
            SqlParameter[] parameters = {
                new SqlParameter("@CT_DSHS_ID", SqlDbType.VarChar) { Value = CT_DSHS_ID },
                new SqlParameter("@Bus_ID", SqlDbType.VarChar) { Value = Bus_ID },
                new SqlParameter("@HocSinh_ID", SqlDbType.VarChar) { Value = HocSinh_ID }
            };
            return conn.getNonQuery(sql, parameters);  // Thực hiện câu lệnh Insert
        }

        // Xóa một ChiTietDanhSachHocSinh
        public int DeleteChiTietHocSinh(string CT_DSHS_ID)
        {
            string sql = "DELETE FROM ChiTietDanhSachHocSinh WHERE CT_DSHS_ID = @CT_DSHS_ID";
            SqlParameter[] parameters = {
                new SqlParameter("@CT_DSHS_ID", SqlDbType.VarChar) { Value = CT_DSHS_ID }
            };
            return conn.getNonQuery(sql, parameters);  // Thực hiện câu lệnh Delete
        }

    }
}
