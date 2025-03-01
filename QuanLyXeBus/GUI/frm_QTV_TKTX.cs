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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyXeBus.view
{
    public partial class frm_QTV_TKTX : Form
    {
        TaiXe_BLL taiXeBLL = new TaiXe_BLL();
        public frm_QTV_TKTX()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            dgv_QTV_TaiKhoanTaiXe.DataSource = taiXeBLL.GetAllTaiXe();
            dgv_QTV_TaiKhoanTaiXe.Columns["TaiKhoan_ID"].HeaderText = "ID Tài Xế";
            dgv_QTV_TaiKhoanTaiXe.Columns["LoaiTK_ID"].HeaderText = "Loại tài khoản";
            dgv_QTV_TaiKhoanTaiXe.Columns["HoTenTX"].HeaderText = "Họ tên tài xế";
            dgv_QTV_TaiKhoanTaiXe.Columns["SoDT"].HeaderText = "Số điện thoại";
            dgv_QTV_TaiKhoanTaiXe.Columns["GiayPhepLaiXe"].HeaderText = "Giấy phép lái xe";
            dgv_QTV_TaiKhoanTaiXe.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgv_QTV_TaiKhoanTaiXe.Columns["Email"].HeaderText = "Email";
        }
 //---------------------------------------------
       
        private void btn_QTV_ThemTX_Click(object sender, EventArgs e)
        {
            string taiKhoanID = txt_QTV_IDTX.Text.Trim();
            string loaiTK_ID = txt_QTV_loaiTK.Text.Trim();
            string hoTenTX = txt_QTV_HoTenTX.Text.Trim();
            string giayPhepLaiXe = txt_QTV_GPLX.Text.Trim();
            string trangThai = cbb_QTV_TrangThaiTX.SelectedItem.ToString();
            string soDT = txt_QTV_SDTTX.Text.Trim();
            string email = txt_QTV_EmailTX.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(taiKhoanID) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(hoTenTX) || string.IsNullOrWhiteSpace(giayPhepLaiXe) ||
                string.IsNullOrWhiteSpace(trangThai) || string.IsNullOrWhiteSpace(soDT))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            if (!Regex.IsMatch(soDT, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }

            if (taiXeBLL.IsTaiKhoanExist(taiKhoanID))
            {
                MessageBox.Show("Tài khoản ID đã tồn tại!");
                return;
            }

            try
            {
                taiXeBLL.AddTaiXe(taiKhoanID, loaiTK_ID, hoTenTX, giayPhepLaiXe, trangThai, soDT, email);
                MessageBox.Show("Thêm tài xế thành công!");
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_QTV_XoaTX_Click(object sender, EventArgs e)
        {
            
            if (dgv_QTV_TaiKhoanTaiXe.SelectedRows.Count > 0)
            {
                string taiKhoanID = dgv_QTV_TaiKhoanTaiXe.SelectedRows[0].Cells["TaiKhoan_ID"].Value.ToString();
                try
                {
                    taiXeBLL.DeleteTaiXe(taiKhoanID);  // Gọi phương thức BLL để xóa tài xế
                    MessageBox.Show("Xóa tài xế thành công!");
                    loaddata();  // Tải lại dữ liệu sau khi xóa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            } 
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
            }
        }

        private void btn_QTV_LuuTX_Click(object sender, EventArgs e)
        {
            string taiKhoanID = txt_QTV_IDTX.Text.Trim();
            string loaiTK_ID = txt_QTV_loaiTK.Text.Trim();
            string hoTenTX = txt_QTV_HoTenTX.Text.Trim();
            string giayPhepLaiXe = txt_QTV_GPLX.Text.Trim();
            string trangThai = cbb_QTV_TrangThaiTX.SelectedItem?.ToString();
            string soDT = txt_QTV_SDTTX.Text.Trim();
            string email = txt_QTV_EmailTX.Text.Trim();
            if (dgv_QTV_TaiKhoanTaiXe.SelectedRows.Count > 0)
            {
                try
                {
                    taiXeBLL.UpdateTaiXe(taiKhoanID, loaiTK_ID, hoTenTX, giayPhepLaiXe, trangThai, soDT, email);
                    MessageBox.Show("Cập nhật tài xế thành công!");
                    loaddata();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài xế để sửa.");
            }
        }

        private void btn_QTV_LamMoi_Click(object sender, EventArgs e)
        {
            txt_QTV_IDTX.Clear();
            txt_QTV_EmailTX.Clear();
            txt_QTV_HoTenTX.Clear();
            txt_QTV_GPLX.Clear();
            cbb_QTV_TrangThaiTX.SelectedIndex = -1;
            txt_QTV_SDTTX.Clear();
            loaddata();
        }

        private void btn_QTV_TimKiemTaiXe_Click(object sender, EventArgs e)
        {
            string tt = txt_QTV_TimKiemTaiKhoanTaiXe.Text.Trim();
            dgv_QTV_TaiKhoanTaiXe.DataSource = taiXeBLL.SearchTaiXe(tt);
        }
        void load_cbb()
        {
            cbb_QTV_TrangThaiTX.Items.Clear();
            cbb_QTV_TrangThaiTX.Items.Add("Đang hoạt động");
            cbb_QTV_TrangThaiTX.Items.Add("Đang tạm vắng");
        }
        private void frm_QTV_TKTX_Load(object sender, EventArgs e)
        {
            loaddata();
            txt_QTV_loaiTK.Text = "LTK02";
            // Thêm các giá trị vào ComboBox trạng thái
            cbb_QTV_TrangThaiTX.Items.Clear(); // Xóa các mục cũ nếu có
            //cbb_QTV_TrangThaiTX.Items.Add("Đang hoạt động");
            //cbb_QTV_TrangThaiTX.Items.Add("Đang tạm vắng");
            load_cbb();
            // Đảm bảo ComboBox chọn giá trị mặc định (Ví dụ: "Hoạt động")
            cbb_QTV_TrangThaiTX.SelectedIndex = 0; // Mặc định chọn "Hoạt động"
        }

        private void dgv_QTV_TaiKhoanTaiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu người dùng đã chọn một dòng hợp lệ
            {
                // Lấy thông tin từ dòng được chọn
                DataGridViewRow row = dgv_QTV_TaiKhoanTaiXe.Rows[e.RowIndex];

                // Gán các giá trị vào các TextBox và ComboBox tương ứng
                txt_QTV_IDTX.Text = row.Cells["TaiKhoan_ID"].Value.ToString();
                txt_QTV_EmailTX.Text = row.Cells["Email"].Value.ToString();
                txt_QTV_loaiTK.Text = row.Cells["LoaiTK_ID"].Value.ToString();
                txt_QTV_HoTenTX.Text = row.Cells["HoTenTX"].Value.ToString();
                txt_QTV_GPLX.Text = row.Cells["GiayPhepLaiXe"].Value.ToString();

                // Đặt giá trị cho ComboBox trạng thái (Hoạt động / Không hoạt động)
                string trangThai = row.Cells["TrangThai"].Value.ToString();
                if (trangThai == "Hoạt động")
                {
                    cbb_QTV_TrangThaiTX.SelectedItem = "Hoạt động";
                }
                else
                {
                    cbb_QTV_TrangThaiTX.SelectedItem = "Không hoạt động";
                }

                txt_QTV_SDTTX.Text = row.Cells["SoDT"].Value.ToString();
            }
        }
    }
}
