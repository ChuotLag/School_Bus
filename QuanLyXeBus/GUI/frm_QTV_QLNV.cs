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
    public partial class frm_QTV_QLNV : Form
    {
        QuanTriVien_BLL qtvbll = new QuanTriVien_BLL();
        public frm_QTV_QLNV()
        {
            InitializeComponent();

        }
        
        private void frm_QTV_QLNV_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void ClearForm()
        {
            txt_QTV_IDQuanTriVien.Clear();
            txt_QTV_MatKhauQuanTriVien.Clear();
            txt_QTV_HoTenQuanTriVien.Clear();
            txt_QTV_EmailQuanTriVien.Clear();
            cbb_QTV_ChucVuQuanTriVien.SelectedIndex = -1;
            dgv_QTV_DanhSachQuanTriVien.ClearSelection();
        }

        private void LoadData()
        {
            dgv_QTV_DanhSachQuanTriVien.DataSource = qtvbll.GetAllQuanTriVien();
            cbb_QTV_ChucVuQuanTriVien.DataSource = qtvbll.GetChucVu();
            cbb_QTV_ChucVuQuanTriVien.DisplayMember = "TenChucVu";
            cbb_QTV_ChucVuQuanTriVien.ValueMember = "ChucVu_ID";

            txt_QTV_LoaiTaiKhoanQuanTriVien.Text = "LTK03";
        }

        private void btn_QTV_ThemQuanTriVien_Click(object sender, System.EventArgs e)
        {
            try
            {
                string taiKhoanID = txt_QTV_IDQuanTriVien.Text;
                string matKhau = txt_QTV_MatKhauQuanTriVien.Text;
                string loaiTaiKhoan = txt_QTV_LoaiTaiKhoanQuanTriVien.Text;
                string hoTen = txt_QTV_HoTenQuanTriVien.Text;
                string email = txt_QTV_EmailQuanTriVien.Text;
                string chucVu = cbb_QTV_ChucVuQuanTriVien.SelectedValue.ToString();

                // Kiểm tra xem các trường không bị trống
                if (string.IsNullOrEmpty(taiKhoanID) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                // Gọi phương thức trong BLL để thêm quản trị viên
                bool success = qtvbll.AddQuanTriVien(taiKhoanID, matKhau, loaiTaiKhoan, hoTen, email, chucVu);

                if (success)
                {
                    MessageBox.Show("Thêm quản trị viên thành công!");
                    // Tải lại danh sách quản trị viên nếu cần
                    dgv_QTV_DanhSachQuanTriVien.DataSource = qtvbll.GetAllQuanTriVien();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm quản trị viên. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_QTV_XoaQuanTriVien_Click(object sender, EventArgs e)
        {
            if (dgv_QTV_DanhSachQuanTriVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một quản trị viên để xóa.");
                return;
            }

            string taiKhoanID = dgv_QTV_DanhSachQuanTriVien.SelectedRows[0].Cells["TaiKhoan_ID"].Value.ToString();

            bool success = qtvbll.DeleteQuanTriVien(taiKhoanID);
            if (success)
            {
                MessageBox.Show("Xóa quản trị viên thành công!");
                dgv_QTV_DanhSachQuanTriVien.DataSource = qtvbll.GetAllQuanTriVien(); // Cập nhật lại danh sách
            }
            else
            {
                MessageBox.Show("Xóa quản trị viên thất bại.");
            }
        }

        private void btn_QTV_LuuQuanTriVien_Click(object sender, EventArgs e)
        {
            string taiKhoanID = txt_QTV_IDQuanTriVien.Text;
            string matKhau = txt_QTV_MatKhauQuanTriVien.Text;
            string loaiTaiKhoan = txt_QTV_LoaiTaiKhoanQuanTriVien.Text;
            string hoTen = txt_QTV_HoTenQuanTriVien.Text;
            string email = txt_QTV_EmailQuanTriVien.Text;
            string chucVu = cbb_QTV_ChucVuQuanTriVien.SelectedValue.ToString();

            if (string.IsNullOrEmpty(taiKhoanID) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            bool success = qtvbll.UpdateQuanTriVien(taiKhoanID, matKhau, loaiTaiKhoan, hoTen, email, chucVu);
            if (success)
            {
                MessageBox.Show("Cập nhật quản trị viên thành công!");
                dgv_QTV_DanhSachQuanTriVien.DataSource = qtvbll.GetAllQuanTriVien(); // Cập nhật lại danh sách
            }
            else
            {
                MessageBox.Show("Cập nhật quản trị viên thất bại.");
            }
        }

        private void btn_QTV_TimKiemQuanTriVien_Click(object sender, EventArgs e)
        {
            string searchKeyword = txt_QTV_TimKiemQuanTriVien.Text;
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                dgv_QTV_DanhSachQuanTriVien.DataSource = qtvbll.SearchQuanTriVien(searchKeyword);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
            }
        }

        private void dgv_QTV_DanhSachQuanTriVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy chỉ số của dòng đã được chọn
                int rowIndex = e.RowIndex;

                // Lấy dữ liệu từ các cột của dòng đã chọn và gán vào các textbox, combobox
                txt_QTV_IDQuanTriVien.Text = dgv_QTV_DanhSachQuanTriVien.Rows[rowIndex].Cells["TaiKhoan_ID"].Value.ToString();
                txt_QTV_MatKhauQuanTriVien.Text = dgv_QTV_DanhSachQuanTriVien.Rows[rowIndex].Cells["MatKhau"].Value.ToString();
                txt_QTV_LoaiTaiKhoanQuanTriVien.Text = dgv_QTV_DanhSachQuanTriVien.Rows[rowIndex].Cells["LoaiTK_ID"].Value.ToString();
                txt_QTV_HoTenQuanTriVien.Text = dgv_QTV_DanhSachQuanTriVien.Rows[rowIndex].Cells["HoTenQTV"].Value.ToString();
                txt_QTV_EmailQuanTriVien.Text = dgv_QTV_DanhSachQuanTriVien.Rows[rowIndex].Cells["Email"].Value.ToString();

                // Gán giá trị cho ComboBox Chức Vụ
                cbb_QTV_ChucVuQuanTriVien.SelectedItem = dgv_QTV_DanhSachQuanTriVien.Rows[rowIndex].Cells["TenChucVu"].Value.ToString();

                string trangThai = dgv_QTV_DanhSachQuanTriVien.Rows[rowIndex].Cells["TenChucVu"].Value.ToString();
                if (trangThai == "Quản lý hệ thống")
                {
                    cbb_QTV_ChucVuQuanTriVien.Text = "Nhân viên hỗ trợ kỹ thuật";
                }
                else if(trangThai == "Nhân viên hỗ trợ kỹ thuật")
                {
                    cbb_QTV_ChucVuQuanTriVien.Text = "Nhân viên hỗ trợ kỹ thuật";
                }
                else
                {
                    cbb_QTV_ChucVuQuanTriVien.Text = "Nhân viên điều hành";
                }    
                
            }
        }

        private void btn_QTV_LamMoiQuanTriVien_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
        }
    }
}
