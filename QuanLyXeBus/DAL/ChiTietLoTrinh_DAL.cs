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
    internal class ChiTietLoTrinh_DAL
    {
        DataConnect conn;

        public ChiTietLoTrinh_DAL()
        {
            conn = new DataConnect();
        }

        public DataTable GetLastCTLT(string ma)
        {
            string sql = "SELECT top 1 * FROM ChiTietLoTrinhXe WHERE CTLT_ID LIKE @ma ORDER BY CTLT_ID DESC";
            SqlParameter[] parameters = {
            new SqlParameter("@ma", SqlDbType.VarChar) { Value = ma + "%" }
        };

            return conn.getTable(sql, parameters);
        }
        public int AddChiTietLoTrinhXe(string CTLT_ID, string LoTrinh_ID, string DiemDung_ID, int ThuTu, TimeSpan ThoiGianDung)
        {
            string query = "EXEC AddChiTietLoTrinhXe @CTLT_ID, @LoTrinh_ID, @DiemDung_ID, @ThuTu, @ThoiGianDung";

            SqlParameter[] parameters = {
                new SqlParameter("@CTLT_ID", SqlDbType.VarChar) { Value = CTLT_ID },
                new SqlParameter("@LoTrinh_ID", SqlDbType.VarChar) { Value = LoTrinh_ID },
                new SqlParameter("@DiemDung_ID", SqlDbType.VarChar) { Value = DiemDung_ID },
                new SqlParameter("@ThuTu", SqlDbType.Int) { Value = ThuTu },
                new SqlParameter("@ThoiGianDung", SqlDbType.Time) { Value = ThoiGianDung }
            };

            return conn.getNonQuery(query, parameters);
        }
        public int UpdateChiTietLoTrinhXe(string CTLT_ID, string LoTrinh_ID, string DiemDung_ID, int ThuTu, TimeSpan ThoiGianDung)
        {
            string query = "EXEC UpdateChiTietLoTrinhXe @CTLT_ID, @LoTrinh_ID, @DiemDung_ID, @ThuTu, @ThoiGianDung";

            SqlParameter[] parameters = {
                new SqlParameter("@CTLT_ID", SqlDbType.VarChar) { Value = CTLT_ID },
                new SqlParameter("@LoTrinh_ID", SqlDbType.VarChar) { Value = LoTrinh_ID },
                new SqlParameter("@DiemDung_ID", SqlDbType.VarChar) { Value = DiemDung_ID },
                new SqlParameter("@ThuTu", SqlDbType.Int) { Value = ThuTu },
                new SqlParameter("@ThoiGianDung", SqlDbType.Time) { Value = ThoiGianDung }
            };

            return conn.getNonQuery(query, parameters);
        }
        public int DeleteChiTietLoTrinhXe(string CTLT_ID)
        {
            string query = "EXEC DeleteChiTietLoTrinhXe @CTLT_ID";

            SqlParameter[] parameters = {
                new SqlParameter("@CTLT_ID", SqlDbType.VarChar) { Value = CTLT_ID }
            };

            return conn.getNonQuery(query, parameters);
        }

        public DataTable GetAllCTLoTrinh()
        {
            try
            {
                string query = "SELECT * FROM ChiTietLoTrinhXe";
                return conn.getTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }

        }

        public string GetSoXeByID(string bus)
        {
            string query = "SELECT SoXeBus FROM XeBus WHERE Bus_ID = @Bus_ID";
            SqlParameter[] parameters = {
                new SqlParameter("@Bus_ID", SqlDbType.VarChar) { Value = bus }
            };

            DataTable dt = conn.getTable(query, parameters);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["SoXeBus"].ToString();
            }
            else
            {
                return string.Empty;
            }
        }


    }
}
