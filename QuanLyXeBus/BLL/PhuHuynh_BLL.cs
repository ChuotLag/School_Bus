using QuanLyXeBus.DAL;
using QuanLyXeBus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyXeBus.Model;
using QuanLyXeBus.BLL;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace QuanLyXeBus.BLL
{
    internal class PhuHuynh_BLL
    {
        private DataConnect conn;
        private PhuHuynh_DAL dal;
        public PhuHuynh_BLL()
        {
            conn = new DataConnect();
            dal = new PhuHuynh_DAL();
        }

        // Lấy tất cả dữ liệu phụ huynh
        public DataTable GetAllPhuHuynh()
        {
            return dal.GetAllPhuHuynh();
        }

        public bool IsTaiKhoanExist(string taiKhoanID)
        {
            return dal.IsTaiKhoanExist(taiKhoanID);
        }

        // Thêm phụ huynh
        public void AddPhuHuynh(string taiKhoanID, string matKhau, string loaiTK_ID, string hoTenPH, string email, string soDT)
        {
            dal.AddPhuHuynh(taiKhoanID, matKhau, loaiTK_ID, hoTenPH, email, soDT);
        }

        // Cập nhật thông tin phụ huynh
        public void UpdatePhuHuynh(string taiKhoanID, string matKhau, string loaiTK_ID, string hoTenPH, string email, string soDT)
        {
            dal.UpdatePhuHuynh(taiKhoanID, matKhau, loaiTK_ID, hoTenPH, email, soDT);
        }

        // Xóa phụ huynh
        public void DeletePhuHuynh(string taiKhoanID)
        {
            dal.DeletePhuHuynh(taiKhoanID);
        }

        // Tìm kiếm phụ huynh
        public DataTable SearchPhuHuynh(string searchTerm)
        {
            return dal.SearchPhuHuynh(searchTerm);
        }

        public string GetTenPH(string taiKhoanID)
        {
            try
            {
                return dal.GetTenPH(taiKhoanID);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi lấy tên phụ huynh", ex);
            }
        }

        public List<string> GetEmailsPhuHuynhTheoTaiXe(string taiKhoanID)
        {
            try
            {
                DataTable dt = dal.GetEmailsPhuHuynhTheoTaiXe(taiKhoanID);
                List<string> emails = new List<string>();

                foreach (DataRow row in dt.Rows)
                {
                    emails.Add(row["Email"].ToString());
                }

                return emails;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL: " + ex.Message);
            }
        }

        public void GuiEmail(string toEmail, string subject, string body)
        {
            try
            {
                var fromAddress = new System.Net.Mail.MailAddress("khoint9125@gmail.com", "Hệ thống Xe Bus");
                var toAddress = new System.Net.Mail.MailAddress(toEmail);
                const string fromPassword = "rpyq xnbq cuse evmr";

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
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi gửi email đến {toEmail}: {ex.Message}");
            }
        }



    }
}
