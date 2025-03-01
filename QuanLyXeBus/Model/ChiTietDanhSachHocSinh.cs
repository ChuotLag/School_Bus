using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.Model
{
    internal class ChiTietDanhSachHocSinh
    {
        public string CT_DSHS_ID { get; set; } 
        public string Bus_ID { get; set; } 
        public string HocSinh_ID { get; set; } 
        public XeBus XeBus { get; set; }
        public HocSinh HocSinh { get; set; }
    }
}
