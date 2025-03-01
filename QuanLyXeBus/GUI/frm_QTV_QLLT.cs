using QuanLyXeBus.BLL;
using QuanLyXeBus.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeBus.view
{
    public partial class frm_QTV_QLLT : Form
    {
        LoTrinh_BLL ltbll = new LoTrinh_BLL();
        TaiXe_BLL taiXeBLL = new TaiXe_BLL();
        XeBus_BLL xbll = new XeBus_BLL();
        ChiTietLoTrinh_BLL ctltbll = new ChiTietLoTrinh_BLL();
        DiemDung_BLL dungBLL = new DiemDung_BLL();
        public frm_QTV_QLLT()
        {
            InitializeComponent();
            txt_QTV_GioKhoiHanh.Text = "00:00:00";
            txt_QTV_GioKetThuc.Text = "00:00:00";
            txt_QTV_ThoiGianDung.Text = "00:00:00";
        }
        void loadLT()
        {
            DataTable dt = ltbll.GetAllLoTrinh();
            dgv_QTV_LoTrinh.DataSource = dt;
        }
        void loadCTLT()
        {
            DataTable dt = ctltbll.GetAllCTLoTrinh();
            dgv_QTV_ChiTietLoTrinh.DataSource = dt;

        }
        void loadBus()
        {
            DataTable dt = xbll.GetAllXeBus();
            cbb_QTV_IDXeBus.DataSource = dt;
            cbb_QTV_IDXeBus.DisplayMember = "SoXeBus";
            cbb_QTV_IDXeBus.ValueMember = "Bus_ID";
        }
        void lamMoi_LT()
        {
            txt_QTV_IDLoTrinh.Text = "";
            txt_QTV_GioKhoiHanh.Text = "00:00:00";
            txt_QTV_GioKetThuc.Text = "00:00:00";
        }
        void lamMoi_CTLT()
        {
            txt_QTV_CTLT.Text = "";
            txt_QTV_ThoiGianDung.Text = "00:00:00";
            txt_QTV_STT.Text = "";
        }

        void load_cbbLT()
        {
            DataTable dt = ltbll.GetAllLoTrinh();
            cbb_QTV_IDLoTrinh.DataSource = dt;
            cbb_QTV_IDLoTrinh.DisplayMember = "LoTrinh_ID";
            cbb_QTV_IDLoTrinh.ValueMember = "LoTrinh_ID";
        }
        void load_cbbDD()
        {
            DataTable dt = dungBLL.GetListDD();
            cbb_QTV_DiemDung.DataSource = dt;
            cbb_QTV_DiemDung.DisplayMember = "ViTri";
            cbb_QTV_DiemDung.ValueMember = "DiemDung_ID";
        }

        private void btn_QTV_ThemLoTrinh_Click(object sender, EventArgs e)
        {
            try
            {
                string loTrinhID = txt_QTV_IDLoTrinh.Text;
                string bienSoXe = cbb_QTV_IDXeBus.Text;
                string busID = taiXeBLL.GetBusIDByBienSoXe(bienSoXe);
                string gioKhoiHanh = txt_QTV_GioKhoiHanh.Text;
                string gioKetThuc = txt_QTV_GioKetThuc.Text;

                if (ltbll.AddLoTrinh(loTrinhID, busID, gioKhoiHanh, gioKetThuc))
                {
                    MessageBox.Show("Lộ trình đã được thêm thành công!");
                    loadLT();
                    lamMoi_LT();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm lộ trình.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void frm_QTV_QLLT_Load(object sender, EventArgs e)
        {
            loadLT();
            loadBus();
            load_cbbLT();
            load_cbbDD();
            loadCTLT();
        }

        private void btn_QTV_NewIDLT_Click(object sender, EventArgs e)
        {
            string maAuto = ltbll.TaoIDLT_Auto();
            txt_QTV_IDLoTrinh.Text = maAuto;

        }

        private void btn_QTV_XoaLoTrinh_Click(object sender, EventArgs e)
        {
            try
            {
                string loTrinhID = txt_QTV_IDLoTrinh.Text;

                if (ltbll.DeleteLoTrinh(loTrinhID))
                {
                    MessageBox.Show("Lộ trình đã xóa thành công!");
                    lamMoi_LT();
                    loadLT();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa lộ trình.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void btn_QTV_SuaLoTirnh_Click(object sender, EventArgs e)
        {
            try
            {
                string loTrinhID = txt_QTV_IDLoTrinh.Text;
                string bienSoXe = cbb_QTV_IDXeBus.Text;
                string busID = taiXeBLL.GetBusIDByBienSoXe(bienSoXe);
                string gioKhoiHanh = txt_QTV_GioKhoiHanh.Text;
                string gioKetThuc = txt_QTV_GioKetThuc.Text;

                if (ltbll.UpdateLoTrinh(loTrinhID, busID, gioKhoiHanh, gioKetThuc))
                {
                    MessageBox.Show("Lộ trình đã cập nhật thành công!");
                    lamMoi_LT();
                    loadLT();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi cập nhật lộ trình.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void btn_QTV_LamMoiLoTrinh_Click(object sender, EventArgs e)
        {
            lamMoi_LT();
            loadLT();
        }

        private void btn_QTV_TaoIDCT_Click(object sender, EventArgs e)
        {
            string maAuto = ctltbll.TaoIDCTLT_Auto();
            txt_QTV_CTLT.Text = maAuto;
        }

        private void btn_QTV_ThemCTLT_Click(object sender, EventArgs e)
        {
            try
            {
                string ctlt = txt_QTV_CTLT.Text;
                string idlt = cbb_QTV_IDLoTrinh.Text;
                string dd = cbb_QTV_DiemDung.SelectedValue.ToString();
                string giodung = txt_QTV_ThoiGianDung.Text;
                string stt = txt_QTV_STT.Text;

                if (ctltbll.AddChiTietLoTrinhXe(ctlt, idlt, dd, stt, giodung))
                {
                    MessageBox.Show("Chi tiết lộ trình đã được thêm thành công!");
                    loadCTLT();
                    lamMoi_CTLT();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm chi tiết lộ trình.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void btn_QTV_CapNhatChiTietLoTrinh_Click(object sender, EventArgs e)
        {
            try
            {
                string ctlt = txt_QTV_CTLT.Text;
                string idlt = cbb_QTV_IDLoTrinh.Text;
                string dd = cbb_QTV_DiemDung.SelectedValue.ToString();
                string giodung = txt_QTV_ThoiGianDung.Text;
                string stt = txt_QTV_STT.Text;

                if (ctltbll.UpdateChiTietLoTrinhXe(ctlt, idlt, dd, stt, giodung))
                {
                    MessageBox.Show("Chi tiết lộ trình đã được sửa thành công!");
                    loadCTLT();
                    lamMoi_CTLT();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa chi tiết lộ trình.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void btn_QTV_XoaCTLT_Click(object sender, EventArgs e)
        {
            try
            {
                string CTloTrinhID = txt_QTV_CTLT.Text;

                if (ctltbll.DeleteChiTietLoTrinhXe(CTloTrinhID))
                {
                    MessageBox.Show("Chi tiết lộ trình đã xóa thành công!");
                    lamMoi_CTLT();
                    loadCTLT();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa chi tiết lộ trình.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void dgv_QTV_ChiTietLoTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string ctlt = dgv_QTV_ChiTietLoTrinh.Rows[e.RowIndex].Cells["CTLT_ID"].Value.ToString();
                string idlt = dgv_QTV_ChiTietLoTrinh.Rows[e.RowIndex].Cells["LoTrinh_ID"].Value.ToString();
                string dd = dgv_QTV_ChiTietLoTrinh.Rows[e.RowIndex].Cells["DiemDung_ID"].Value.ToString();
                string giodung = dgv_QTV_ChiTietLoTrinh.Rows[e.RowIndex].Cells["ThoiGianDung"].Value.ToString();
                string stt = dgv_QTV_ChiTietLoTrinh.Rows[e.RowIndex].Cells["ThuTu"].Value.ToString();
                txt_QTV_CTLT.Text = ctlt;
                cbb_QTV_IDLoTrinh.Text = idlt;
                cbb_QTV_DiemDung.SelectedValue = dd;
                txt_QTV_ThoiGianDung.Text = giodung;
                txt_QTV_STT.Text = stt;
            }
        }

        private void btn_QTV_LamMoiCT_Click(object sender, EventArgs e)
        {
            loadCTLT();
            lamMoi_CTLT();
        }

        private void dgv_QTV_LoTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string loTrinhID = dgv_QTV_LoTrinh.Rows[e.RowIndex].Cells["LoTrinh_ID"].Value.ToString();  
                string busID = dgv_QTV_LoTrinh.Rows[e.RowIndex].Cells["Bus_ID"].Value.ToString(); 
                string soXe = ctltbll.GetSoXeByID(busID);
                string gioKhoiHanh = dgv_QTV_LoTrinh.Rows[e.RowIndex].Cells["GioKhoiHanh"].Value.ToString(); 
                string gioKetThuc = dgv_QTV_LoTrinh.Rows[e.RowIndex].Cells["GioKetThuc"].Value.ToString();   

                txt_QTV_IDLoTrinh.Text = loTrinhID;
                cbb_QTV_IDXeBus.Text = soXe; 
                txt_QTV_GioKhoiHanh.Text = gioKhoiHanh;
                txt_QTV_GioKetThuc.Text = gioKetThuc;
            }
        }
    }
}
