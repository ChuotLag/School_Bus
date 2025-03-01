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
    internal class LoTrinh_DAL
    {
        private DataConnect conn;

        public LoTrinh_DAL()
        {
            conn = new DataConnect();   
        }

        public string GetLoTrinhByTaiXeID(string taiXeID)
        {
            try
            {
                string query = "EXEC GetLoTrinhByTaiXeID @TaiXe_ID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@TaiXe_ID", SqlDbType.VarChar) { Value = taiXeID }
                };
                DataTable dt = conn.getTable(query, parameters);

                if (dt.Rows.Count > 0 && dt.Rows[0]["LoTrinhDuongDi"] != DBNull.Value)
                {
                    return dt.Rows[0]["LoTrinhDuongDi"].ToString();
                }
                else
                {
                    return "Không tìm thấy lộ trình cho chuyến xe này.";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }
        }
        public List<string> GetTTLoTrinhByTaiXeID(string taiXeID)
        {
            try
            {
                string query = "EXEC GetTTLoTrinhByTaiXeID @TaiXe_ID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@TaiXe_ID", SqlDbType.VarChar) { Value = taiXeID }
                };

                DataTable dt = conn.getTable(query, parameters);
                List<string> viTriList = new List<string>();

                foreach (DataRow row in dt.Rows)
                {
                    viTriList.Add(row["ViTri"].ToString());
                }

                return viTriList;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }
        }

        public DataTable GetAllLoTrinh()
        {
            try
            {
                string query = "SELECT * FROM LoTrinh";
                return conn.getTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }

        }
        public DataTable GetLastLT(string ma)
        {
            string sql = "SELECT top 1 * FROM LoTrinh WHERE LoTrinh_ID LIKE @ma ORDER BY LoTrinh_ID DESC";
            SqlParameter[] parameters = {
            new SqlParameter("@ma", SqlDbType.VarChar) { Value = ma + "%" }
        };

            return conn.getTable(sql, parameters);
        }


        public int AddLoTrinh(string LoTrinh_ID, string Bus_ID, TimeSpan GioKhoiHanh, TimeSpan GioKetThuc)
        {
            string query = "EXEC AddLoTrinh @LoTrinh_ID, @Bus_ID, @GioKhoiHanh, @GioKetThuc";

            SqlParameter[] parameters = {
                new SqlParameter("@LoTrinh_ID", SqlDbType.VarChar) { Value = LoTrinh_ID },
                new SqlParameter("@Bus_ID", SqlDbType.VarChar) { Value = Bus_ID },
                new SqlParameter("@GioKhoiHanh", SqlDbType.Time) { Value = GioKhoiHanh },
                new SqlParameter("@GioKetThuc", SqlDbType.Time) { Value = GioKetThuc }
            };

            return conn.getNonQuery(query, parameters);
        }
        public int UpdateLoTrinh(string LoTrinh_ID, string Bus_ID, TimeSpan GioKhoiHanh, TimeSpan GioKetThuc)
        {
            string query = "EXEC UpdateLoTrinh @LoTrinh_ID, @Bus_ID, @GioKhoiHanh, @GioKetThuc";
            SqlParameter[] parameters = {
                new SqlParameter("@LoTrinh_ID", SqlDbType.VarChar) { Value = LoTrinh_ID },
                new SqlParameter("@Bus_ID", SqlDbType.VarChar) { Value = Bus_ID },
                new SqlParameter("@GioKhoiHanh", SqlDbType.Time) { Value = GioKhoiHanh },
                new SqlParameter("@GioKetThuc", SqlDbType.Time) { Value = GioKetThuc }
            };

            return conn.getNonQuery(query, parameters);
        }
        public int DeleteLoTrinh(string LoTrinh_ID)
        {
            string query = "EXEC DeleteLoTrinh @LoTrinh_ID";
            SqlParameter[] parameters = {
                new SqlParameter("@LoTrinh_ID", SqlDbType.VarChar) { Value = LoTrinh_ID }
            };
            return conn.getNonQuery(query, parameters);
        }

        public string GetLoTrinhByPhuHuynhID(string phuHuynhID)
        {
            try
            {
                string query = "EXEC GetLoTrinhByPhuHuynhID @PhuHuynh_ID";
                SqlParameter[] parameters = {
                new SqlParameter("@PhuHuynh_ID", SqlDbType.VarChar) { Value = phuHuynhID }
            };

                DataTable dt = conn.getTable(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["LoTrinhDuongDi"].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }
        }





    }
}
