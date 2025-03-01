using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.Model
{
    internal class ChiTietLoTrinhXe
    {
        public string CTLT_ID { get; set; } 
        public string LoTrinh_ID { get; set; } 
        public string DiemDung_ID { get; set; } 
        public int ThuTu { get; set; } 
        public TimeSpan ThoiGianDung { get; set; } 
        public LoTrinh LoTrinh { get; set; } 
        public DiemDung DiemDung { get; set; }
    }
}
