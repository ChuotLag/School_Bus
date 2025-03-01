using QuanLyXeBus.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.BLL
{
    internal class ChiTietDiemDanh_BLL
    {
        private ChiTietDiemDanh_DAL dal;
        public ChiTietDiemDanh_BLL()
        {
            dal = new ChiTietDiemDanh_DAL();
        }
        public string TaoIDCTDD_Di_Auto()
        {
            string ma = "DI"; 
            DataTable dt = dal.GetLastCTDDID_Di(ma); 

            if (dt.Rows.Count > 0)
            {
                string lastCTDDID = dt.Rows[0]["CTDDD_ID"].ToString();
                int maCu = int.Parse(lastCTDDID.Substring(2, 3)); 
                int maMoi = maCu + 1; 
                if (maMoi < 10)
                {
                    return ma + "00" + maMoi.ToString();
                }
                else if (maMoi < 100)
                {
                    return ma + "0" + maMoi.ToString();
                }
                else
                {
                    return ma + maMoi.ToString();
                }
            }
            else
            {
                return ma + "001";
            }
        }

        public string TaoIDCTDD_Ve_Auto()
        {
            string ma = "VE";
            DataTable dt = dal.GetLastCTDDID_Ve(ma);

            if (dt.Rows.Count > 0)
            {
                string lastCTDDID = dt.Rows[0]["CTDDV_ID"].ToString();
                int maCu = int.Parse(lastCTDDID.Substring(2, 3));
                int maMoi = maCu + 1;
                if (maMoi < 10)
                {
                    return ma + "00" + maMoi.ToString();
                }
                else if (maMoi < 100)
                {
                    return ma + "0" + maMoi.ToString();
                }
                else
                {
                    return ma + maMoi.ToString();
                }
            }
            else
            {
                return ma + "001";
            }
        }

        public bool AddChiTietDiemDanhDi(string ctdddID, string diemDanhID, string hocSinhID, string diemLenXe, string diemXuongXe, string gioLenXe, string gioXuongXe, string trangThai)
        {
            try
            {
                TimeSpan gioLen;
                if (!TimeSpan.TryParse(gioLenXe, out gioLen))
                {
                    throw new Exception("Giờ lên xe không hợp lệ.");
                }
                TimeSpan? gioXuong = null;
                int result = dal.AddChiTietDiemDanhDi(ctdddID, diemDanhID, hocSinhID, diemLenXe, diemXuongXe, gioLen, gioXuong, trangThai);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        public bool UpdateChiTietDiemDanhDi(string ctdddID, string diemXuongXe, string gioXuongXe)
        {
            try
            {
                int result = dal.UpdateChiTietDiemDanhDi(ctdddID, diemXuongXe, gioXuongXe);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public bool AddChiTietDiemDanhVe(string ctddvID, string diemDanhID, string hocSinhID, string diemLenXe, string diemXuongXe, string gioLenXe, string gioXuongXe, string trangThai)
        {
            try
            {
                TimeSpan gioLen;
                if (!TimeSpan.TryParse(gioLenXe, out gioLen))
                {
                    throw new Exception("Giờ lên xe không hợp lệ.");
                }
                TimeSpan? gioXuong = null;
                int result = dal.AddChiTietDiemDanhVe(ctddvID, diemDanhID, hocSinhID, diemLenXe, diemXuongXe, gioLen, gioXuong, trangThai);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public bool UpdateChiTietDiemDanhVe(string ctddvID, string diemXuongXe, string gioXuongXe)
        {
            try
            {
                int result = dal.UpdateChiTietDiemDanhVe(ctddvID, diemXuongXe, gioXuongXe);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public bool DeleteChiTietDiemDanhDi(string ctdddID)
        {
            try
            {
                int result = dal.DeleteChiTietDiemDanhDi(ctdddID);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        public bool DeleteChiTietDiemDanhVe(string ctddvID)
        {
            try
            {
                int result = dal.DeleteChiTietDiemDanhVe(ctddvID);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public bool XuLyVangDi(string ctdddID, string diemDanhID, string hocSinhID, string trangThai)
        {
            try
            {
                int result = dal.XuLyVangDi(ctdddID, diemDanhID, hocSinhID, trangThai);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public bool XuLyVangVe(string ctddvID, string diemDanhID, string hocSinhID, string trangThai)
        {
            try
            {
                int result = dal.XuLyVangVe(ctddvID, diemDanhID, hocSinhID, trangThai);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        public DataTable GetChiTietDiemDanhVe(string diemDanhID)
        {
            try
            {
                return dal.GetChiTietDiemDanhVe(diemDanhID);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public DataTable GetChiTietDiemDanhDi(string diemDanhID)
        {
            try
            {
                return dal.GetChiTietDiemDanhDi(diemDanhID);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public string GetHocSinhNameByID(string hocSinhID)
        {
            try
            {
                return dal.GetHocSinhNameByID(hocSinhID);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

    }
}
