using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.Model
{
    internal class HopDongXeBus
    {
        public string HD_ID { get; set; }
        public string PhuHuynh_ID { get; set; } 
        public int ChiPhi { get; set; } 
        public DateTime ThoiGianBatDau { get; set; } 
        public DateTime ThoiGianKetThuc { get; set; } 
        public string TrangThai { get; set; } 
        public PhuHuynh PhuHuynh { get; set; }
    }
}
