using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyXeBus.DAL;

namespace QuanLyXeBus.BLL
{
    internal class ChiTietLoTrinh_BLL
    {
        private ChiTietLoTrinh_DAL dal;

        public ChiTietLoTrinh_BLL()
        {
            dal = new ChiTietLoTrinh_DAL();
        }
        public string TaoIDCTLT_Auto()
        {
            string ma = "CTLT";
            DataTable dt = dal.GetLastCTLT(ma);

            if (dt.Rows.Count > 0)
            {
                string lastCTDDID = dt.Rows[0]["CTLT_ID"].ToString();
                int maCu = int.Parse(lastCTDDID.Substring(4, 3));
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

        public bool AddChiTietLoTrinhXe(string CTLT_ID, string LoTrinh_ID, string DiemDung_ID, string stt, string ThoiGianDung)
        {
            try
            {
                int thuTu;
                if (!int.TryParse(stt, out thuTu))
                {
                    throw new Exception("Thứ tự không hợp lệ.");
                }
                TimeSpan thoiGianDung;
                if (!TimeSpan.TryParse(ThoiGianDung, out thoiGianDung))
                {
                    throw new Exception("Thời gian dừng không hợp lệ.");
                }
                int result = dal.AddChiTietLoTrinhXe(CTLT_ID, LoTrinh_ID, DiemDung_ID, thuTu, thoiGianDung);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        public bool UpdateChiTietLoTrinhXe(string CTLT_ID, string LoTrinh_ID, string DiemDung_ID, string stt, string ThoiGianDung)
        {
            try
            {
                int thuTu;
                if (!int.TryParse(stt, out thuTu))
                {
                    throw new Exception("Thứ tự không hợp lệ.");
                }
                TimeSpan thoiGianDung;
                if (!TimeSpan.TryParse(ThoiGianDung, out thoiGianDung))
                {
                    throw new Exception("Thời gian dừng không hợp lệ.");
                }
                int result = dal.UpdateChiTietLoTrinhXe(CTLT_ID, LoTrinh_ID, DiemDung_ID, thuTu, thoiGianDung);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }
        public bool DeleteChiTietLoTrinhXe(string CTLT_ID)
        {
            try
            {
                int result = dal.DeleteChiTietLoTrinhXe(CTLT_ID);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        public DataTable GetAllCTLoTrinh()
        {
            return dal.GetAllCTLoTrinh();
        }

        public string GetSoXeByID(string bus)
        {
            try
            {
                return dal.GetSoXeByID(bus);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

    }
}
