using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeBus.BLL
{
    internal class QuenMatKhau_BLL
    {
        private DAL.QuenMatKhau_DAL dal = new DAL.QuenMatKhau_DAL();
        private Random random = new Random();
        private int otp;
        private string emailDaGuiOTP;
        //public string LayTaiKhoanIDTuEmail()
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(emailDaGuiOTP))
        //        {
        //            throw new Exception("Email chưa được xác nhận OTP. Vui lòng gửi OTP và xác nhận email.");
        //        }

        //        string taiKhoanID = dal.LayTaiKhoanTheoEmail(emailDaGuiOTP);

        //        if (string.IsNullOrEmpty(taiKhoanID))
        //        {
        //            throw new Exception("Không tìm thấy tài khoản tương ứng với email đã cung cấp.");
        //        }

        //        return taiKhoanID;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Lỗi: " + ex.Message);
        //    }
        //}
        public string LayTaiKhoanIDTuEmail(string email)
        {
            return dal.LayTaiKhoanTheoEmail(email);
        }

        // Kiểm tra email và gửi mã OTP
        public string GuiOTP(string email)
        {
            if (!dal.KiemTraEmailTonTai(email))
            {
                return "Email không tồn tại.";
            }

            // Tạo mã OTP ngẫu nhiên
            otp = random.Next(100000, 1000000);

            // Gửi OTP qua email
            try
            {
                var fromAddress = new System.Net.Mail.MailAddress("khoint9125@gmail.com");
                var toAddress = new System.Net.Mail.MailAddress(email);
                const string fromPassword = "rpyq xnbq cuse evmr";
                const string subject = "OTP Code";
                string body = $"Mã OTP của bạn là: {otp}";

                var smtp = new System.Net.Mail.SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword),
                    Timeout = 20000
                };

                using (var message = new System.Net.Mail.MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                emailDaGuiOTP = email;

                return "OTP đã được gửi qua email.";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi gửi OTP: {ex.Message}";
            }
        }

        // Xác nhận OTP
        public bool XacNhanOTP(int nhapOTP)
        {
            return nhapOTP == otp;
        }
    }
}
