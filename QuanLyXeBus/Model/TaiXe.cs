using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.Model
{
    internal class TaiXe
    {
        public string TaiKhoan_ID { get; set; }
        public string HoTenTX { get; set; } 
        public string SoDT { get; set; } 
        public string GiayPhepLaiXe { get; set; } 
        public string TrangThai { get; set; } 
        public TaiKhoan TaiKhoan { get; set; } 
    }
}
