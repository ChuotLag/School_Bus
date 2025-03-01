using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.Model
{
    internal class DiemDanhTaiXe
    {
        public string DiemDanhTX_ID { get; set; }
        public string TaiKhoan_ID { get; set; }
        public string SoXeBus { get; set; }
        public DateTime Ngay { get; set; }
        public string CaLam_ID { get; set; }
        public string TrangThai { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
        public XeBus XeBus { get; set; }
        public CaLamTaiXe CaLamTaiXe { get; set; }
    }
}
