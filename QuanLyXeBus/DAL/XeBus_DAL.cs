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
    internal class XeBus_DAL
    {
        private DataConnect conn;

        public XeBus_DAL()
        {
            conn = new DataConnect();
        }

        // Lấy tất cả dữ liệu xe bus
        // Lấy danh sách tất cả tài xế
        public DataTable GetAllTaiXe()
        {
            try
            {
                // Câu lệnh gọi stored procedure
                string sql = "EXEC GetAllTaiXe";

                // Gọi phương thức getTable để thực thi câu lệnh SQL và trả về kết quả
                return conn.getTable(sql);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                throw new Exception("Lỗi khi lấy danh sách tài xế: " + ex.Message);
            }
        }

        // Thêm một xe bus mới
        public bool AddXeBus(string idXeBus, string bienSoXe, int soGhe, string taiXeID, string trangThai)
        {
            try
            {
                // Câu lệnh gọi stored procedure
                string query = "EXEC InsertXeBus @Bus_ID, @SoXeBus, @SoGhe, @TaiXe_ID, @TrangThai";

                // Các tham số truyền vào stored procedure
                SqlParameter[] parameters = {
                    new SqlParameter("@Bus_ID", SqlDbType.NVarChar) { Value = idXeBus },
                    new SqlParameter("@SoXeBus", SqlDbType.NVarChar) { Value = bienSoXe },
                    new SqlParameter("@SoGhe", SqlDbType.Int) { Value = soGhe },
                    new SqlParameter("@TaiXe_ID", SqlDbType.NVarChar) { Value = string.IsNullOrEmpty(taiXeID) ? DBNull.Value : (object)taiXeID },
                    new SqlParameter("@TrangThai", SqlDbType.NVarChar) { Value = trangThai }
                };

                // Gọi phương thức getNonQuery để thực thi stored procedure và trả về số dòng bị ảnh hưởng
                return conn.getNonQuery(query, parameters) > 0;  // Trả về true nếu có ít nhất một dòng bị ảnh hưởng
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                throw new Exception("Lỗi khi thêm xe buýt: " + ex.Message);
            }
        }

        // Cập nhật thông tin xe bus
        public bool UpdateXeBus(string idXeBus, string bienSoXe, int soGhe, string taiXeID, string trangThai)
        {
            try
            {
                // Câu lệnh gọi stored procedure
                string query = "EXEC UpdateXeBus @Bus_ID, @SoXeBus, @SoGhe, @TaiXe_ID, @TrangThai";

                // Các tham số truyền vào stored procedure
                SqlParameter[] parameters = {
                    new SqlParameter("@Bus_ID", SqlDbType.NVarChar) { Value = idXeBus },
                    new SqlParameter("@SoXeBus", SqlDbType.NVarChar) { Value = bienSoXe },
                    new SqlParameter("@SoGhe", SqlDbType.Int) { Value = soGhe },
                    new SqlParameter("@TaiXe_ID", SqlDbType.NVarChar) { Value = string.IsNullOrEmpty(taiXeID) ? DBNull.Value : (object)taiXeID },
                    new SqlParameter("@TrangThai", SqlDbType.NVarChar) { Value = trangThai }
                };

                // Gọi phương thức getNonQuery để thực thi stored procedure và trả về số dòng bị ảnh hưởng
                return conn.getNonQuery(query, parameters) > 0;  // Trả về true nếu có ít nhất một dòng bị ảnh hưởng
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                throw new Exception("Lỗi khi cập nhật xe buýt: " + ex.Message);
            }
        }

        // Xóa một xe bus
        public bool DeleteXeBus(string idXeBus)
        {
            try
            {
                // Câu lệnh gọi stored procedure
                string query = "EXEC DeleteXeBus @Bus_ID";

                // Khai báo tham số truyền vào stored procedure
                SqlParameter[] parameters = {
                    new SqlParameter("@Bus_ID", SqlDbType.NVarChar) { Value = idXeBus }
                };

                // Gọi phương thức getNonQuery để thực thi stored procedure và trả về số dòng bị ảnh hưởng
                return conn.getNonQuery(query, parameters) > 0;  // Trả về true nếu có ít nhất một dòng bị ảnh hưởng
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                throw new Exception("Lỗi khi xóa xe buýt: " + ex.Message);
            }
        }

        // Tìm kiếm xe bus theo từ khóa
        public DataTable SearchXeBus(string keyword)
        {
            try
            {
                // Câu lệnh gọi stored procedure
                string query = "EXEC SearchXeBus @Keyword";

                // Khai báo tham số truyền vào stored procedure
                SqlParameter[] parameters = {
                    new SqlParameter("@Keyword", SqlDbType.NVarChar) { Value = keyword }
                };

                // Gọi phương thức getTable để thực thi stored procedure và trả về DataTable kết quả
                return conn.getTable(query, parameters);  // Trả về DataTable chứa kết quả
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                throw new Exception("Lỗi khi tìm kiếm xe buýt: " + ex.Message);
            }
        }

        // Lấy tất cả thông tin xe bus
        public DataTable GetAllXeBus()
        {
            string query = "SELECT Bus_ID, SoXeBus, SoGhe, TaiXe_ID, TrangThai FROM XeBus";
            return conn.getTable(query);
        }
        // Phương thức để thực thi câu truy vấn trả về 1 giá trị (Scalar)
        public object GetScalar(string query)
        {
            return conn.getScalar(query, null); // Gọi getScalar của DataConnect
        }








    }
}
