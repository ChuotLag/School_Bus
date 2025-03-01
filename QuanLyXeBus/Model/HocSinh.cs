using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.Model
{
    internal class HocSinh
    {
        public string HocSinh_ID { get; set; } 
        public string HoTenHS { get; set; } 
        public DateTime NgaySinh { get; set; } 
        public string DiaChi { get; set; } 
        public string PhuHuynh_ID { get; set; } 
        public string TrangThai { get; set; } 
        public string Lop_ID { get; set; } 
        public PhuHuynh PhuHuynh { get; set; }
        public Lop Lop { get; set; }
    }
}
