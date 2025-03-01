using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.Model
{
    internal class QuanTriVien
    {
        public string TaiKhoan_ID { get; set; }
        public string ChucVu_ID { get; set; }
        public string HoTenQTV { get; set; } 
        public string Email { get; set; } 
        public TaiKhoan TaiKhoan { get; set; } 
        public ChucVu ChucVu { get; set; }

    }
}
