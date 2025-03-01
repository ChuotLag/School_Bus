using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.Model
{
    internal class ChiTietHocSinhDiemDung
    {
        public string CT_HSDD_ID { get; set; }
        public string DiemDung_ID { get; set; } 
        public string HocSinh_ID { get; set; } 
        public DiemDung DiemDung { get; set; } 
        public HocSinh HocSinh { get; set; }
    }
}
