using QuanLyXeBus.DAL;
using QuanLyXeBus.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.BLL
{
    internal class DiemDanh_BLL
    {
        private DiemDanh_DAL dal;
        public DiemDanh_BLL()
        {
            dal = new DiemDanh_DAL();
        }

        public string TaoID_Auto()
        {
            string Ma = "DD";  // Tiền tố mặc định cho DiemDanh_ID
            DataTable dt = dal.GetLastDiemDanhID(Ma);

            if (dt.Rows.Count == 0)
            {
                Ma += "001";  // Nếu không có dữ liệu, bắt đầu từ "DD001"
            }
            else
            {
                string sttmax = dt.Rows[0]["DiemDanh_ID"].ToString();
                int stt = int.Parse(sttmax.Substring(2, 3)) + 1;  // Lấy số cuối và cộng thêm 1

                // Tạo mã theo số tự động tăng
                if (stt < 10)
                {
                    Ma += "00" + stt;
                }
                else if (stt < 100)
                {
                    Ma += "0" + stt;
                }
                else
                {
                    Ma += stt;
                }
            }
            return Ma;
        }

        public bool KiemTraTrungMaDD(string diemDanhID)
        {
            return !dal.KiemTraMaDDTrung(diemDanhID);
        }
        public bool KiemTraTrungMaCTDD_Di(string ma)
        {
            return dal.KiemTraTrungMaCTDD_Di(ma);
        }
        public bool KiemTraTrungMaCTDD_Ve(string ma)
        {
            return dal.KiemTraTrungMaCTDD_Ve(ma);
        }

        public bool ThemDiemDanh(string diemDanhID, string busID, string ngayDiemDanh, string trangThai)
        {
            try
            {
                if (KiemTraTrungMaDD(diemDanhID))
                {
                    int result = dal.ThemDiemDanh(diemDanhID, busID, ngayDiemDanh, trangThai);
                    return result > 0;
                }
                else
                {
                    throw new ApplicationException("Mã điểm danh bị trùng!");
                }
            }
            catch (Exception ex)
            {
                // Log lỗi và xử lý lỗi ở đây (nếu cần)
                throw new ApplicationException("Có lỗi xảy ra khi thêm điểm danh: " + ex.Message);
            }
        }

        public bool CapNhatTrangThai(string diemDanhID, string trangThai)
        {
            return dal.CapNhatTrangThai(diemDanhID, trangThai);
        }

        public bool XoaDiemDanh(string diemDanhID)
        {
            return dal.XoaDiemDanh(diemDanhID);
        }



    }
}
