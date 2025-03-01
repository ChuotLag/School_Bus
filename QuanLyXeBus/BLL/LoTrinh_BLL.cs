using QuanLyXeBus.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.BLL
{
    internal class LoTrinh_BLL
    {
        private LoTrinh_DAL dal;
        public LoTrinh_BLL()
        {
           dal  = new LoTrinh_DAL();
        }
        

        public string GetLoTrinhByTaiXeID(string taiXeID)
        {
            try
            {
                return dal.GetLoTrinhByTaiXeID(taiXeID);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public List<string> GetTTLoTrinhByTaiXeID(string taiXeID)
        {
            try
            {
                return dal.GetTTLoTrinhByTaiXeID(taiXeID);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public DataTable GetAllLoTrinh()
        {
            return dal.GetAllLoTrinh();
        }

        public string TaoIDLT_Auto()
        {
            string ma = "LT";
            DataTable dt = dal.GetLastLT(ma);

            if (dt.Rows.Count > 0)
            {
                string lastCTDDID = dt.Rows[0]["LoTrinh_ID"].ToString();
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

        public bool AddLoTrinh(string LoTrinh_ID, string Bus_ID, string GioKhoiHanh, string GioKetThuc)
        {
            try
            {
                TimeSpan gioKhoiHanh;
                TimeSpan gioKetThuc;
                if (!TimeSpan.TryParse(GioKhoiHanh, out gioKhoiHanh))
                {
                    throw new Exception("Giờ khởi hành không hợp lệ.");
                }

                if (!TimeSpan.TryParse(GioKetThuc, out gioKetThuc))
                {
                    throw new Exception("Giờ kết thúc không hợp lệ.");
                }
                int result = dal.AddLoTrinh(LoTrinh_ID, Bus_ID, gioKhoiHanh, gioKetThuc);
                return result > 0; 
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public bool UpdateLoTrinh(string LoTrinh_ID, string Bus_ID, string GioKhoiHanh, string GioKetThuc)
        {
            try
            {
                TimeSpan gioKhoiHanh;
                TimeSpan gioKetThuc;
                if (!TimeSpan.TryParse(GioKhoiHanh, out gioKhoiHanh))
                {
                    throw new Exception("Giờ khởi hành không hợp lệ.");
                }

                if (!TimeSpan.TryParse(GioKetThuc, out gioKetThuc))
                {
                    throw new Exception("Giờ kết thúc không hợp lệ.");
                }

                int result = dal.UpdateLoTrinh(LoTrinh_ID, Bus_ID, gioKhoiHanh, gioKetThuc);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public bool DeleteLoTrinh(string LoTrinh_ID)
        {
            try
            {
                int result = dal.DeleteLoTrinh(LoTrinh_ID);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        public string GetLoTrinhByPhuHuynhID(string phuHuynhID)
        {
            try
            {
                if (string.IsNullOrEmpty(phuHuynhID))
                {
                    throw new Exception("Mã phụ huynh không hợp lệ.");
                }

                string loTrinh = dal.GetLoTrinhByPhuHuynhID(phuHuynhID);

                if (string.IsNullOrEmpty(loTrinh))
                {
                    throw new Exception("Không tìm thấy lộ trình cho phụ huynh này.");
                }

                return loTrinh;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

    }
}
