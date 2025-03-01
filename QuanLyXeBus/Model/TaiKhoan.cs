using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.Model
{
    internal class TaiKhoan
    {
        public string TaiKhoan_ID { get; set; } // Mã tài khoản
        public string MatKhau { get; set; } // Mật khẩu tài khoản
        public string LoaiTK_ID { get; set; } // Mã loại tài khoản
        public LoaiTaiKhoan LoaiTaiKhoan { get; set; } // Mối quan hệ với LoaiTaiKhoan 
    }
}
