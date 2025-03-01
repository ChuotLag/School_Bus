using QuanLyXeBus.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;


namespace QuanLyXeBus.DAL
{
    internal class DiemDung_DAL
    {
        private DataConnect conn;

        public DiemDung_DAL()
        {
            conn = new DataConnect();
        }

        // Lấy tất cả điểm dừng
        public DataTable GetAllDiemDung()
        {
            try
            {
                string query = "SELECT * FROM DiemDung";
                return conn.getTable(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }

        }

        // Thêm điểm dừng
        public int AddDiemDung(string DiemDung_ID, string ViTri)
        {
            string query = "INSERT INTO DiemDung (DiemDung_ID, ViTri) VALUES (@DiemDung_ID, @ViTri)";
            SqlParameter[] parameters = {
                new SqlParameter("@DiemDung_ID", DiemDung_ID),
                new SqlParameter("@ViTri", ViTri)
            };
            return conn.getNonQuery(query, parameters);
        }

        // Cập nhật điểm dừng
        public int UpdateDiemDung(string DiemDung_ID, string ViTri)
        {
            string query = "UPDATE DiemDung SET ViTri = @ViTri WHERE DiemDung_ID = @DiemDung_ID";
            SqlParameter[] parameters = {
                new SqlParameter("@DiemDung_ID", DiemDung_ID),
                new SqlParameter("@ViTri", ViTri)
            };
            return conn.getNonQuery(query, parameters);
        }

        // Xóa điểm dừng
        public int DeleteDiemDung(string DiemDung_ID)
        {
            string query = "DELETE FROM DiemDung WHERE DiemDung_ID = @DiemDung_ID";
            SqlParameter[] parameters = {
                new SqlParameter("@DiemDung_ID", DiemDung_ID)
            };
            return conn.getNonQuery(query, parameters);
        }

        // Tìm kiếm điểm dừng
        public DataTable SearchDiemDung(string ma)
        {
            string query = "SELECT DiemDung_ID, ViTri FROM DiemDung WHERE DiemDung_ID LIKE @ma";
            SqlParameter[] parameters = {
                new SqlParameter("@ma", "%" + ma + "%")
            };
            return conn.getTable(query, parameters);
        }
        public DataTable GetLastDD(string ma)
        {
            string sql = "SELECT top 1 * FROM DiemDung WHERE DiemDung_ID LIKE @ma ORDER BY DiemDung_ID DESC";
            SqlParameter[] parameters = {
            new SqlParameter("@ma", SqlDbType.VarChar) { Value = ma + "%" }
        };

            return conn.getTable(sql, parameters);
        }

        public DataTable GetListHSTheoDDTX(string taikhoanID, string diemDungID)
        {
            // Tên stored procedure
            string sql = "EXEC GetHocSinhByDiemDungAndTaiXe @TaiKhoan_ID, @DiemDung_ID";

            // Tạo tham số cho stored procedure
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taikhoanID },
                new SqlParameter("@DiemDung_ID", SqlDbType.VarChar) { Value = diemDungID }
            };

            // Gọi phương thức getTable để thực thi stored procedure và trả về DataTable
            return conn.getTable(sql, parameters);
        }
        public DataTable GetListAllHSTheoDD(string taikhoanID)
        {
            // Tên stored procedure
            string sql = "EXEC GetAllHocSinhByTaiXe @TaiKhoan_ID";

            // Tạo tham số cho stored procedure
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taikhoanID }
            };

            // Gọi phương thức getTable để thực thi stored procedure và trả về DataTable
            return conn.getTable(sql, parameters);
        }
        // Hàm lấy tất cả các DiemDung
        public DataTable GetListDiemDung()
        {
            string sql = "SELECT * FROM DiemDung";
            return conn.getTable(sql); // Trả về DataTable
        }
        public DataTable GetDiemDungByTaiKhoanID(string taiKhoanID)
        {
            try
            {
                string query = "EXEC GetDiemDungByTaiKhoanID @TaiKhoan_ID";
                SqlParameter[] parameters = {
                new SqlParameter("@TaiKhoan_ID", SqlDbType.VarChar) { Value = taiKhoanID }
            };

                return conn.getTable(query, parameters); // Trả về DataTable
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }
        }
    }   
}
