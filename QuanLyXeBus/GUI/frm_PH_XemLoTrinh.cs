using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyXeBus.BLL;
using QuanLyXeBus.BusinessLogic;
using QuanLyXeBus.Model;
namespace QuanLyXeBus.view
{
    public partial class frm_PH_XemLoTrinh : Form
    {
        private string taiKhoanID;
        TaiXe_BLL txBLL;
        HocSinh_BLL hsBLL;
        LoTrinh_BLL ltBLL;
        public frm_PH_XemLoTrinh(string taiKhoanID)
        {
            InitializeComponent();
            this.taiKhoanID = taiKhoanID;
            txBLL = new TaiXe_BLL();
            hsBLL = new HocSinh_BLL();
            ltBLL = new LoTrinh_BLL();
        }
        private void HienThiThongTinTaiXe()
        {
            try
            {

                if (string.IsNullOrEmpty(taiKhoanID))
                {
                    MessageBox.Show("Không tìm thấy tài khoản phụ huynh.");
                    return;
                }

                DataTable dtTaiXe = txBLL.LayThongTinTaiXeTheoPhuHuynh(taiKhoanID);

                if (dtTaiXe.Rows.Count > 0)
                {
                    DataRow row = dtTaiXe.Rows[0];
                    txt_PH_TenTaiXe.Text = row["TenTaiXe"].ToString();
                    txt_PH_SoDienThoai.Text = row["SoDienThoaiTaiXe"].ToString();
                    txt_PH_SoXe.Text = row["BienSoXe"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin tài xế liên quan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void HienThiHocSinh()
        {
            try
            {

                if (string.IsNullOrEmpty(taiKhoanID))
                {
                    MessageBox.Show("Không tìm thấy tài khoản phụ huynh.");
                    return;
                }
                DataTable dtHS = hsBLL.LayHocSinhTheoPhuHuynh(taiKhoanID);

                if (dtHS.Rows.Count > 0)
                {
                    DataRow row = dtHS.Rows[0];
                    txt_PH_TenHocSinh.Text = row["HoTenHS"].ToString();
                    txt_PH_NgaySinh.Text = Convert.ToDateTime(row["NgaySinh"]).ToString("dd/MM/yyyy");
                    txt_PH_DiaChi.Text = row["DiaChi"].ToString();
                    txt_PH_Lop.Text = row["TenLop"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin tài xế liên quan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void HienThiLoTrinh()
        {
            try
            {
                string loTrinhDuongDi = ltBLL.GetLoTrinhByPhuHuynhID(taiKhoanID);

                if (!string.IsNullOrEmpty(loTrinhDuongDi))
                {
                    lb_PH_HienThiTuyenXe.AutoSize = false;
                    lb_PH_HienThiTuyenXe.MaximumSize = new Size(panel2.Width - 20, 0);
                    lb_PH_HienThiTuyenXe.Text = loTrinhDuongDi;
                    lb_PH_HienThiTuyenXe.AutoSize = true;
                }
                else
                {
                    lb_PH_HienThiTuyenXe.Text = "Không tìm thấy lộ trình cho tài khoản này.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void frm_PH_XemLoTrinh_Load(object sender, EventArgs e)
        {
            HienThiThongTinTaiXe();
            HienThiHocSinh();
            HienThiLoTrinh();
        }
    }
}
