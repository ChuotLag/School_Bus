using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.DataAccess
{
    internal class DataConnect
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FF9BMG1;Initial Catalog=QLXEBUS01;Integrated Security=True;");

        public DataConnect()
        {

        }

        // Đóng mở kết nối
        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

        }
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        // Phương thức thực thi câu lệnh SQL không trả về dữ liệu (INSERT, UPDATE, DELETE)
        public int getNonQuery(string sql, params SqlParameter[] parameters)
        {
            try
            {
                // Đảm bảo kết nối được mở trước khi thực thi
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();  // Thực thi câu lệnh SQL và trả về số dòng bị ảnh hưởng
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi hoặc xử lý ngoại lệ nếu cần
                throw new ApplicationException("Lỗi SQL: " + ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối luôn được đóng sau khi thực thi xong
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        // Phương thức lấy giá trị đơn (SELECT với 1 giá trị)
        public object getScalar(string sql, SqlParameter[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);  // Thêm tham số vào SqlCommand
                }

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                return cmd.ExecuteScalar();  // Trả về kết quả đầu tiên
            }
        }


        // Phương thức lấy DataTable từ câu lệnh SQL
        public DataTable getTable(string sql, params SqlParameter[] parameters)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds.Tables[0];  // Trả về DataTable đầu tiên từ DataSet
                }
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                throw new ApplicationException("Lỗi khi lấy dữ liệu", ex);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataTable getTable1(string sql, params SqlParameter[] parameters)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)  // Kiểm tra tham số không null
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables.Count > 0)
                        return ds.Tables[0];
                    else
                        throw new Exception("Không có bảng dữ liệu nào trả về.");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi lấy dữ liệu từ SQL: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }


        // Phương thức cập nhật bảng (INSERT, UPDATE, DELETE) với DataTable
        public int updateTable(DataTable dtnew, string sql)
        {
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                return da.Update(dtnew); // Cập nhật bảng với DataTable
            }

        }

        internal void ExecuteNonQuery(string sqlQuery, SqlParameter[] parameters)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    // Thêm tham số vào câu lệnh SQL
                    cmd.Parameters.AddRange(parameters);

                    // Mở kết nối nếu chưa mở
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    // Thực thi câu lệnh SQL và trả về kết quả
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Log lỗi hoặc ném ngoại lệ tùy nhu cầu
                throw new ApplicationException("Lỗi khi thực thi câu lệnh SQL: " + ex.Message, ex);
            }
            finally
            {
                // Đảm bảo đóng kết nối sau khi thực thi
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        internal SqlConnection GetConnection()
        {
            return conn;  // Trả về đối tượng SqlConnection hiện tại
        }
    }
}
