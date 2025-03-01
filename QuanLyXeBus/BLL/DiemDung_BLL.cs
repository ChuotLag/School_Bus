using QuanLyXeBus.DAL;
using QuanLyXeBus.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.BLL
{
    internal class DiemDung_BLL
    {
        private DataConnect conn;
        private DiemDung_DAL dal;
        public DiemDung_BLL()
        {
            conn = new DataConnect();
            dal = new DiemDung_DAL();
        }

        public DataTable GetAllDiemDung()
        {
            return dal.GetAllDiemDung();
        }

        public bool AddDiemDung(string DiemDung_ID, string ViTri)
        {
            try
            {
                int result = dal.AddDiemDung(DiemDung_ID, ViTri);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        public bool UpdateDiemDung(string DiemDung_ID, string ViTri)
        {
            try
            {
                int result = dal.UpdateDiemDung(DiemDung_ID, ViTri);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }


        }

        public bool DeleteDiemDung(string DiemDung_ID)
        {
            try
            {
                int result = dal.DeleteDiemDung(DiemDung_ID);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        public DataTable SearchDiemDung(string ma)
        {
            return dal.SearchDiemDung(ma);
        }

        public string TaoIDDD_Auto()
        {
            string ma = "DD";
            DataTable dt = dal.GetLastDD(ma);

            if (dt.Rows.Count > 0)
            {
                string lastCTDDID = dt.Rows[0]["DiemDung_ID"].ToString();
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

        public DataTable GetListHSDD(string taikhoanID,string diemDungID)
        {
            return dal.GetListHSTheoDDTX(taikhoanID, diemDungID);
        }        
        public DataTable GetListAllHSDD(string taikhoanID)
        {
            return dal.GetListAllHSTheoDD(taikhoanID);
        }
        public DataTable GetListDD()
        {
            return dal.GetListDiemDung();
        }

        public DataTable LayDiemDungTheoTaiKhoanID(string taiKhoanID)
        {
            try
            {
                return dal.GetDiemDungByTaiKhoanID(taiKhoanID);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }



    }
}
