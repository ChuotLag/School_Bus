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
    internal class XeBus_BLL
    {
        private DataConnect conn;
        private XeBus_DAL dal;
        public XeBus_BLL()
        {
            conn = new DataConnect();
            dal = new XeBus_DAL();
        }

        // Lấy tất cả dữ liệu XeBus
        public DataTable GetAllTaiXe()
        {
            return dal.GetAllTaiXe();  // Gọi DAL để lấy dữ liệu
        }

        // Kiểm tra tài xế có đang lái xe bus nào không
        public bool CheckTaiXeIsAssigned(string taiXeID)
        {
            string query = $@"
                SELECT COUNT(*) 
                FROM XeBus 
                WHERE TaiXe_ID = '{taiXeID}'
            ";
            object result = dal.GetScalar(query);  // Gọi phương thức GetScalar trong DAL
            return result != null && Convert.ToInt32(result) > 0;
        }

        // Thêm xe bus mới
        public bool AddXeBus(string idXeBus, string bienSoXe, int soGhe, string taiXeID, string trangThai)
        {
            return dal.AddXeBus(idXeBus, bienSoXe, soGhe, taiXeID, trangThai);
        }

        // Cập nhật thông tin xe bus
        public bool UpdateXeBus(string idXeBus, string bienSoXe, int soGhe, string taiXeID, string trangThai)
        {
            return dal.UpdateXeBus(idXeBus, bienSoXe, soGhe, taiXeID, trangThai);
        }

        // Xóa xe bus
        public bool DeleteXeBus(string idXeBus)
        {
            return dal.DeleteXeBus(idXeBus);
        }

        // Tìm kiếm xe bus
        public DataTable SearchXeBus(string keyword)
        {
            return dal.SearchXeBus(keyword);
        }

        // Lấy tất cả xe bus
        public DataTable GetAllXeBus()
        {
            return dal.GetAllXeBus();
        }


    }
}
