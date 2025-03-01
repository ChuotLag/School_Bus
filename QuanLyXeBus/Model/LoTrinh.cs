using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.Model
{
    internal class LoTrinh
    {
        public string LoTrinh_ID { get; set; }
        public string Bus_ID { get; set; }
        public TimeSpan GioKhoiHanh { get; set; }
        public TimeSpan GioKetThuc { get; set; }
        public XeBus XeBus { get; set; }
    }
}
