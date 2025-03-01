using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
using QuanLyXeBus.DAL;
using QuanLyXeBus.DataAccess;
using QuanLyXeBus.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyXeBus.BLL
{
    
    internal class QuanTriVien_BLL
    {
        private DataConnect conn;
        private QuanTriVien_DAL dal;
        public QuanTriVien_BLL()
        {
            conn = new DataConnect();
            dal = new QuanTriVien_DAL();
        }

        public DataTable GetAllQuanTriVien()
        {
            try
            {
                return dal.GetAllQuanTriVien();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        public string GetTenQuanTriVien(string taiKhoanID)
        {
            try
            {
                return dal.GetTenQuanTriVien(taiKhoanID);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi lấy tên tài xế", ex);
            }
        }

        public DataTable GetChucVu()
        {
            return dal.GetChucVu();
        }

        public bool AddQuanTriVien(string taiKhoanID, string matKhau, string loaiTaiKhoan, string hoTen, string email, string chucVu)
        {
            try
            {
                int result = dal.AddQuanTriVien(taiKhoanID, matKhau, loaiTaiKhoan, hoTen, email, chucVu);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        public bool UpdateQuanTriVien(string taiKhoanID, string matKhau, string loaiTaiKhoan, string hoTen, string email, string chucVu)
        {
            try
            {
                int result = dal.UpdateQuanTriVien(taiKhoanID, matKhau, loaiTaiKhoan, hoTen, email, chucVu);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        // Xóa quản trị viên
        public bool DeleteQuanTriVien(string taiKhoanID)
        {
            try
            {
                int result = dal.DeleteQuanTriVien(taiKhoanID);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        // Tìm kiếm quản trị viên
        public DataTable SearchQuanTriVien(string timKiemQTV)
        {
            try
            {
                return dal.SearchQuanTriVien(timKiemQTV);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }

        }
    }
}
