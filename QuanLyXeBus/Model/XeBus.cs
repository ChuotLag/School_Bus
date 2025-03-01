using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.Model
{
    internal class XeBus
    {
        public string Bus_ID { get; set; } 
        public string SoXeBus { get; set; } 
        public int SoGhe { get; set; } 
        public string TaiXe_ID { get; set; }
        public string TrangThai { get; set; }
        public TaiXe TaiXe { get; set; }
    }
}
