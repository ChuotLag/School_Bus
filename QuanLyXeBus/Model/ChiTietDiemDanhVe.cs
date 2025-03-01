using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.Model
{
    internal class ChiTietDiemDanhVe
    {
        public string CTDDV_ID { get; set; } 
        public string DiemDanh_ID { get; set; } 
        public string HocSinh_ID { get; set; } 
        public string DiemLenXe { get; set; } 
        public string DiemXuongXe { get; set; } 
        public TimeSpan GioLenXe { get; set; } 
        public TimeSpan GioXuongXe { get; set; } 
        public string TrangThai { get; set; } 
        public DiemDanh DiemDanh { get; set; } 
        public HocSinh HocSinh { get; set; }
    }
}
