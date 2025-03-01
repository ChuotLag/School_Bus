using QuanLyXeBus.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.BLL
{
    internal class HocSinh_BLL
    {
        private HocSinh_DAL dal;
        public HocSinh_BLL()
        {
            dal = new HocSinh_DAL();
        }
        public DataTable GetHocSinhByTaiXeID(string taiXeID)
        {
            try
            {
                return dal.GetHocSinhByTaiXeID(taiXeID);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        // Lấy danh sách học sinh
        public DataTable GetDanhSachHocSinh()
        {
            try
            {
                return dal.GetDanhSachHocSinh();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        // Thêm học sinh
        public bool AddHocSinh(string hocSinhID, string hoTen, DateTime ngaySinh, string diaChi, string phuHuynhID, string lopID)
        {
            try
            {
                int result = dal.AddHocSinh(hocSinhID, hoTen, ngaySinh, diaChi, phuHuynhID, lopID);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        // Sửa học sinh
        public bool UpdateHocSinh(string hocSinhID, string hoTen, DateTime ngaySinh, string diaChi, string phuHuynhID, string lopID)
        {
            try
            {
                int result = dal.UpdateHocSinh(hocSinhID, hoTen, ngaySinh, diaChi, phuHuynhID, lopID);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }

        }

        // Xóa học sinh
        public bool DeleteHocSinh(string hocSinhID)
        {
            try
            {
                int result = dal.DeleteHocSinh(hocSinhID);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        // Tìm kiếm học sinh
        public DataTable SearchHocSinh(string searchKeyword)
        {
            return dal.SearchHocSinh(searchKeyword);
        }

        // Lấy danh sách phụ huynh
        public DataTable GetDanhSachPhuHuynh()
        {
            return dal.GetDanhSachPhuHuynh();
        }

        // Lấy danh sách lớp
        public DataTable GetDanhSachLop()
        {
            return dal.GetDanhSachLop();
        }
        public DataTable LayHocSinhTheoPhuHuynh(string phuHuynhID)
        {
            try
            {
                return dal.GetHocSinhByPhuHuynh(phuHuynhID);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

    }
}
