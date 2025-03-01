using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.Model
{
    internal class DiemDanh
    {
        public string DiemDanh_ID { get; set; } 
        public string Bus_ID { get; set; } 
        public DateTime NgayDiemDanh { get; set; } 
        public string TrangThai { get; set; } 
        public XeBus XeBus { get; set; }
    }
}
