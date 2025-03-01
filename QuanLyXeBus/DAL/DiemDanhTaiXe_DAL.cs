using QuanLyXeBus.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyXeBus.Model;

namespace QuanLyXeBus.DAL
{
    internal class DiemDanhTaiXe_DAL
    {
        private DataConnect conn;

        public DiemDanhTaiXe_DAL()
        {
            conn = new DataConnect();
        }

        public DataTable GetLastDiemDanhTX_ID(string ma)
        {
            string sql = "select top 1 * from DiemDanhTaiXe where DiemDanhTX_ID like @ma order by DiemDanhTX_ID desc";
            SqlParameter[] parameters =
             {
                new SqlParameter("@ma", SqlDbType.VarChar) { Value = ma + "%" }
             };
            return conn.getTable(sql, parameters);
        }
        // Phương thức lấy danh sách học sinh từ cơ sở dữ liệu
        public List<CaLamTaiXe> GetCaLamTaiXeList()
        {
            List<CaLamTaiXe> CaLamTaiXeList = new List<CaLamTaiXe>();
            string sql = "SELECT CaLam_ID, CaLam FROM CaLamTaiXe"; // Truy vấn lấy danh sách ca làm của tài xế

            // Gọi phương thức getTable của DataConnect để lấy dữ liệu
            DataTable dt = conn.getTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                CaLamTaiXe cltx = new CaLamTaiXe
                {
                    CaLam_ID = row["CaLam_ID"].ToString(),
                    CaLam = row["CaLam"].ToString()
                };
                CaLamTaiXeList.Add(cltx);
            }
            return CaLamTaiXeList;
        }
        // thêm thông tin điểm danh tài xế
        // Phương thức gọi stored procedure để lưu điểm danh tài xế
        public void LuuDiemDanhTaiXe(string diemDanhTX_ID, string taiKhoanID, string soXeBus, DateTime ngay, string caLamID, string trangThai)
        {
            string sql = "EXEC LuuDiemDanhTaiXe @DiemDanhTX_ID, @TaiKhoan_ID, @SoXeBus, @Ngay, @CaLam_ID, @TrangThai";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@DiemDanhTX_ID", SqlDbType.VarChar) { Value = diemDanhTX_ID },
        new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taiKhoanID },
        new SqlParameter("@SoXeBus", SqlDbType.VarChar) { Value = soXeBus },
        new SqlParameter("@Ngay", SqlDbType.Date) { Value = ngay },
        new SqlParameter("@CaLam_ID", SqlDbType.VarChar) { Value = caLamID },
        new SqlParameter("@TrangThai", SqlDbType.NVarChar) { Value = trangThai }
            };

            // Gọi phương thức getNonQuery để thực thi câu lệnh SQL
            conn.getNonQuery(sql, parameters);
        }
        // Lấy danh sách điểm danh tài xế từ CSDL theo TaiKhoan_ID
        public DataTable GetDiemDanhByTaiKhoanID(string taiKhoanID)
        {
            string sql = "EXEC GetDiemDanhByTaiKhoanID @TaiKhoan_ID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taiKhoanID }
            };
            return conn.getTable(sql, parameters);
        }


    }
}

