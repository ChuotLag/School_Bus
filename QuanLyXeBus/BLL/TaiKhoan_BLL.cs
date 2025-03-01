using QuanLyXeBus.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyXeBus.Model;
using QuanLyXeBus.BLL;

namespace QuanLyXeBus.BLL
{
    internal class TaiKhoan_BLL
    {
        private DataConnect conn;
        private TaiKhoan_DAL dal;
        public TaiKhoan_BLL()
        {
            conn = new DataConnect();
            dal = new TaiKhoan_DAL();
        }

        public string DangNhap(string taiKhoanID, string matKhau)
        {
            try
            {
                // Truy vấn tài khoản theo ID
                TaiKhoan taiKhoan = dal.TimTaiKhoanTheoID(taiKhoanID);

                // Kiểm tra mật khẩu
                if (taiKhoan != null && taiKhoan.MatKhau == matKhau)
                {
                    // Lấy tên loại tài khoản từ bảng LoaiTaiKhoan
                    string tenLoaiTaiKhoan = dal.LayTenLoaiTaiKhoan(taiKhoan.LoaiTK_ID);

                    // Dựa vào tên loại tài khoản để chuyển đến form phù hợp
                    if (tenLoaiTaiKhoan == "Quản Trị Viên")
                    {
                        return "QTV"; // Mở form quản trị viên
                    }
                    else if (tenLoaiTaiKhoan == "Tài Xế")
                    {
                        return "TX"; // Mở form tài xế
                    }
                    else if (tenLoaiTaiKhoan == "Phụ Huynh")
                    {
                        return "PH"; // Mở form phụ huynh
                    }
                    else
                    {
                        return null; // Nếu loại tài khoản không hợp lệ
                    }
                }
                else
                {
                    return null;  // Tài khoản hoặc mật khẩu sai
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi đăng nhập", ex);
            }
        }


        public bool DoiMatKhau(string taiKhoanID, string matKhauCu, string matKhauMoi)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(matKhauMoi))
                {
                    throw new Exception("Mật khẩu mới không được để trống.");
                }

                if (matKhauCu == matKhauMoi)
                {
                    throw new Exception("Mật khẩu mới không được giống mật khẩu cũ.");
                }

                return dal.UpdateMatKhau(taiKhoanID, matKhauCu, matKhauMoi);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }



    }
}
