using QuanLyXeBus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyXeBus.Model;
using QuanLyXeBus.BLL;
using QuanLyXeBus.DAL;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyXeBus.BusinessLogic
{
    internal class TaiXe_BLL
    {
        private DataConnect conn;
        private TaiXe_DAL dal;
        public TaiXe_BLL()
        {
            conn = new DataConnect();
            dal = new TaiXe_DAL();
        }
        // Lấy tất cả tài xế
        public DataTable GetAllTaiXe()
        {
            return dal.GetAllTaiXe();
        }

        // Kiểm tra nếu tài khoản đã tồn tại
        public bool IsTaiKhoanExist(string taiKhoanID)
        {
            return dal.IsTaiKhoanExist(taiKhoanID);
        }

        // Thêm tài xế
        public void AddTaiXe(string taiKhoanID, string loaiTK_ID, string hoTenTX, string giayPhepLaiXe, string trangThai, string soDT, string email)
        {
            dal.AddTaiXe(taiKhoanID, loaiTK_ID, hoTenTX, giayPhepLaiXe, trangThai, soDT, email);
        }

        // Xóa tài xế
        public void DeleteTaiXe(string taiKhoanID)
        {
            try
            {
                dal.DeleteTaiXe(taiKhoanID);  // Gọi phương thức DAL
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực hiện xóa tài xế: " + ex.Message);
            }
        }

        // Cập nhật tài xế
        public void UpdateTaiXe(string taiKhoanID, string loaiTK_ID, string hoTenTX,
                         string giayPhepLaiXe, string trangThai, string soDT, string email)
        {
            dal.UpdateTaiXe(taiKhoanID, loaiTK_ID, hoTenTX, giayPhepLaiXe, trangThai, soDT, email);
        }
        // Tìm kiếm tài xế
        public DataTable SearchTaiXe(string searchValue)
        {
            return dal.SearchTaiXe(searchValue);
        }

        public string GetTenTaiXe(string taiKhoanID)
        {
            try
            {
                return dal.GetTenTaiXe(taiKhoanID); 
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi lấy tên tài xế", ex);
            }
        }
        public string GetBienSoXeByTaiXe(string taiKhoanID)
        {
            string bienSoXe = string.Empty;

            string sql = "SELECT SoXeBus FROM XeBus WHERE TaiXe_ID = @TaiXe_ID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TaiXe_ID", SqlDbType.VarChar) { Value = taiKhoanID }
            };

            DataTable dt = conn.getTable(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                bienSoXe = dt.Rows[0]["SoXeBus"].ToString();
            }

            return bienSoXe;
        }

        public string GetSoGheByTaiXe(string taiKhoanID)
        {
            string soGhe = string.Empty;

            string sql = "SELECT SoGhe FROM XeBus WHERE TaiXe_ID = @TaiXe_ID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TaiXe_ID", SqlDbType.VarChar) { Value = taiKhoanID }
            };

            DataTable dt = conn.getTable(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                soGhe = dt.Rows[0]["SoGhe"].ToString();
            }

            return soGhe;
        }


        public string GetBusIDByBienSoXe(string bienSoXe)
        {
            string busID = string.Empty;

            string sql = "SELECT Bus_ID FROM XeBus WHERE SoXeBus = @SoXeBus";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SoXeBus", SqlDbType.VarChar) { Value = bienSoXe }
            };

            DataTable dt = conn.getTable(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                busID = dt.Rows[0]["Bus_ID"].ToString();
            }

            return busID;
        }

        public DataTable LayThongTinTaiXeTheoPhuHuynh(string taiKhoanID)
        {
            try
            {
                return dal.GetTaiXeByPhuHuynhID(taiKhoanID);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }



    }
}
