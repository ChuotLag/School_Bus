using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.Model
{
    internal class PhuHuynh
    {
        public string TaiKhoan_ID { get; set; } 
        public string HoTenPH { get; set; } 
        public string Email { get; set; } 
        public string SoDT { get; set; }
        public TaiKhoan TaiKhoan { get; set; } 
    }
}
