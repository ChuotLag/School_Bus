using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyXeBus.BLL;
using QuanLyXeBus.BusinessLogic;
using QuanLyXeBus.Model;

namespace QuanLyXeBus.view
{
    public partial class frm_QTV_QLDD : Form
    {
        DiemDung_BLL diemDungBLL = new DiemDung_BLL();
        
        public frm_QTV_QLDD()
        {
            InitializeComponent();
        }
        void LoadDiemDung()
        {
            DataTable dt = diemDungBLL.GetAllDiemDung(); 
            dgv_QTV_DiemDung.DataSource = dt;
        }
        void lamMoi_DD()
        {
            txt_QTV_MaDiemDung.Text = "";
            txt_QTV_TimDiemDung.Text = "";
            txt_QTV_ViTri.Text = "";
        }
        void LoadDiemDungSreach(string ma)
        {

            try
            {
                DataTable dt = diemDungBLL.SearchDiemDung(ma);
                if (dt.Rows.Count > 0)
                {
                    dgv_QTV_DiemDung.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cho điểm dừng này.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void frm_QTV_QLDD_Load_1(object sender, EventArgs e)
        {
            LoadDiemDung(); 
        }

        private void btn_QTV_TimDiemDung_Click(object sender, EventArgs e)
        {
            string ma = txt_QTV_TimDiemDung.Text;
            LoadDiemDungSreach(ma);
        }

        private void btn_QTV_ThemDiemDung_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txt_QTV_MaDiemDung.Text;
                string vt = txt_QTV_ViTri.Text;
                if (diemDungBLL.AddDiemDung(ma, vt))
                {
                    MessageBox.Show("Đã thêm điểm dừng");
                    LoadDiemDung();
                    lamMoi_DD();
                }
                else
                {
                    MessageBox.Show("Thêm điểm dừng chưa thành công");
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_QTV_XoaDiemDung_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txt_QTV_MaDiemDung.Text;
                if(diemDungBLL.DeleteDiemDung(ma))
                {
                    MessageBox.Show("Đã xóa điểm dừng");
                    LoadDiemDung();
                    lamMoi_DD();
                }
                else
                {
                    MessageBox.Show("Xóa chưa thành công");
                }
            }
            catch(ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_QTV_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txt_QTV_MaDiemDung.Text;
                string vt = txt_QTV_ViTri.Text;
                if (diemDungBLL.UpdateDiemDung(ma, vt))
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadDiemDung();
                    lamMoi_DD();
                }
                else
                {
                    MessageBox.Show("Sửa chưa thành công");
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_QTV_LamMoi_Click(object sender, EventArgs e)
        {
            lamMoi_DD();
            LoadDiemDung();
        }

        private void btn_QTV_TaoIDDD_Click(object sender, EventArgs e)
        {
            string maDD_Auto = diemDungBLL.TaoIDDD_Auto();
            txt_QTV_MaDiemDung.Text = maDD_Auto;
        }

    }
}
