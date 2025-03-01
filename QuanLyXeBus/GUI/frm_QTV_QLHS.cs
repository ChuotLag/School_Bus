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

namespace QuanLyXeBus.GUI
{
    public partial class frm_QTV_QLHS : Form
    {
        HocSinh_BLL bll = new HocSinh_BLL();
        public frm_QTV_QLHS()
        {
            InitializeComponent();
            bll = new HocSinh_BLL();
            LoadData();
        }
        private void LoadData()
        {
            dgv_QTV_DanhSachHocSinh.DataSource = bll.GetDanhSachHocSinh();
            //-----------------------------------------------------------
            dgv_QTV_DanhSachHocSinh.Columns["HocSinh_ID"].HeaderText = "ID Học sinh";
            dgv_QTV_DanhSachHocSinh.Columns["HoTenHS"].HeaderText = "Họ tên học sinh";
            dgv_QTV_DanhSachHocSinh.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgv_QTV_DanhSachHocSinh.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgv_QTV_DanhSachHocSinh.Columns["PhuHuynh_ID"].HeaderText = "Phụ huynh học sinh";
            dgv_QTV_DanhSachHocSinh.Columns["Lop_ID"].HeaderText = "Lớp";
            //-----------------------------------------------------------
            cbb_QTV_IDPhuHuynhHocSinh.DataSource = bll.GetDanhSachPhuHuynh();
            cbb_QTV_IDPhuHuynhHocSinh.DisplayMember = "HoTenPH";
            cbb_QTV_IDPhuHuynhHocSinh.ValueMember = "TaiKhoan_ID";

            cbb_QTV_LopHocSinh.DataSource = bll.GetDanhSachLop();
            cbb_QTV_LopHocSinh.DisplayMember = "TenLop";
            cbb_QTV_LopHocSinh.ValueMember = "Lop_ID";
        }

        //Thêm học sinh
        private void btn_QTV_ThemHocSinh_Click(object sender, EventArgs e)
        {
            string hocSinhID = txt_QTV_IDHocSinh.Text;
            string hoTen = txt_QTV_HoTenHocSinh.Text;
            DateTime ngaySinh = dtp_QTV_NgaySinhHocSinh.Value; // Lấy giá trị từ DateTimePicker
            string diaChi = txt_QTV_DiaChiHocSinh.Text;
            string phuHuynhID = cbb_QTV_IDPhuHuynhHocSinh.SelectedValue.ToString();
            string lopID = cbb_QTV_LopHocSinh.SelectedValue.ToString();

            // Gọi hàm thêm học sinh trong BLL
            bool success = bll.AddHocSinh(hocSinhID, hoTen, ngaySinh, diaChi, phuHuynhID, lopID);

            if (success)
            {
                MessageBox.Show("Thêm học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Cập nhật danh sách học sinh sau khi thêm
            }
            else
            {
                MessageBox.Show("Thêm học sinh thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Xóa học sinh
        private void btn_QTV_XoaHocSinh_Click(object sender, EventArgs e)
        {
            string hocSinhID = txt_QTV_IDHocSinh.Text;
            string hoTen = txt_QTV_HoTenHocSinh.Text;
            DateTime ngaySinh = dtp_QTV_NgaySinhHocSinh.Value;
            string diaChi = txt_QTV_DiaChiHocSinh.Text;
            string phuHuynhID = cbb_QTV_IDPhuHuynhHocSinh.SelectedValue.ToString();
            string lopID = cbb_QTV_LopHocSinh.SelectedValue.ToString();
            if (bll.DeleteHocSinh(hocSinhID))
            {
                MessageBox.Show("Xóa học sinh thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi xóa học sinh");
            }
        }

        private void btn_QTV_LuuHocSinh_Click(object sender, EventArgs e)
        {
            string hocSinhID = txt_QTV_IDHocSinh.Text;
            string hoTen = txt_QTV_HoTenHocSinh.Text;
            DateTime ngaySinh = dtp_QTV_NgaySinhHocSinh.Value;
            string diaChi = txt_QTV_DiaChiHocSinh.Text;
            string phuHuynhID = cbb_QTV_IDPhuHuynhHocSinh.SelectedValue.ToString();
            string lopID = cbb_QTV_LopHocSinh.SelectedValue.ToString();

            if (bll.UpdateHocSinh(hocSinhID, hoTen, ngaySinh, diaChi, phuHuynhID, lopID))
            {
                MessageBox.Show("Cập nhật học sinh thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật học sinh");
            }
        }

        private void btn_QTV_TimKiemHocSinh_Click(object sender, EventArgs e)
        {
            string tt = txt_QTV_TimKiemHocSinh.Text;
            dgv_QTV_DanhSachHocSinh.DataSource = bll.SearchHocSinh(tt);
        }

        private void dgv_QTV_DanhSachHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấn vào một dòng (e.RowIndex != -1)
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu của dòng được chọn
                DataGridViewRow row = dgv_QTV_DanhSachHocSinh.Rows[e.RowIndex];

                // Gán dữ liệu từ dòng vào các điều khiển tương ứng
                txt_QTV_IDHocSinh.Text = row.Cells["HocSinh_ID"].Value.ToString();
                txt_QTV_HoTenHocSinh.Text = row.Cells["HoTenHS"].Value.ToString();
                dtp_QTV_NgaySinhHocSinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);  // Chuyển đổi ngày thành DateTime
                txt_QTV_DiaChiHocSinh.Text = row.Cells["DiaChi"].Value.ToString();

                // Gán Phụ huynh ID vào ComboBox
                cbb_QTV_IDPhuHuynhHocSinh.SelectedValue = row.Cells["PhuHuynh_ID"].Value.ToString();

                // Gán Lớp ID vào ComboBox
                cbb_QTV_LopHocSinh.SelectedValue = row.Cells["Lop_ID"].Value.ToString();
            }
        }

        private void btn_QTV_LamMoi_Click(object sender, EventArgs e)
        {
            // Đặt lại các giá trị TextBox về rỗng
            txt_QTV_IDHocSinh.Clear();
            txt_QTV_HoTenHocSinh.Clear();
            txt_QTV_DiaChiHocSinh.Clear();

            // Đặt lại giá trị DateTimePicker về ngày hiện tại (hoặc ngày mặc định)
            dtp_QTV_NgaySinhHocSinh.Value = DateTime.Now;  // Đặt lại ngày sinh về ngày hiện tại

            // Đặt lại ComboBox về giá trị mặc định (thường là không chọn gì)
            cbb_QTV_IDPhuHuynhHocSinh.SelectedIndex = -1;  // Hoặc SelectedValue = null tùy thuộc vào cấu hình
            cbb_QTV_LopHocSinh.SelectedIndex = -1;          // Cũng có thể là SelectedValue = null

            // Nếu cần, có thể làm sạch DataGridView hoặc các điều khiển khác nếu có
            dgv_QTV_DanhSachHocSinh.ClearSelection();       // Bỏ chọn bất kỳ dòng nào trong DataGridView

        }
    }
}
