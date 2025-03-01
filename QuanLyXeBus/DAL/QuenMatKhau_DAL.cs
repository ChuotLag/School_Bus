using QuanLyXeBus.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.DAL
{
    internal class QuenMatKhau_DAL
    {
        private DataConnect db = new DataConnect();

        // Kiểm tra email có tồn tại trong cơ sở dữ liệu hay không
        public bool KiemTraEmailTonTai(string email)
        {
            string query = @"SELECT COUNT(*) FROM (
                                SELECT Email FROM PhuHuynh
                                UNION ALL
                                SELECT Email FROM TaiXe
                                UNION ALL
                                SELECT Email FROM QuanTriVien
                             ) AS AllEmails
                             WHERE Email = @Email";
            SqlParameter param = new SqlParameter("@Email", email);
            int count = (int)db.getScalar(query, new SqlParameter[] { param });
            return count > 0;
        }

        // Trả về tên người dùng theo email (nếu cần)
        public string LayTaiKhoanTheoEmail(string email)
        {
            try
            {
                string query = @"SELECT TaiKhoan_ID FROM PhuHuynh WHERE Email = @Email
                         UNION
                         SELECT TaiKhoan_ID FROM TaiXe WHERE Email = @Email
                         UNION
                         SELECT TaiKhoan_ID FROM QuanTriVien WHERE Email = @Email";
                SqlParameter param = new SqlParameter("@Email", email);

                object result = db.getScalar(query, new SqlParameter[] { param });
                return result?.ToString() ?? string.Empty; // Trả về chuỗi rỗng nếu không tìm thấy
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL: " + ex.Message);
            }
        }
    }
}
