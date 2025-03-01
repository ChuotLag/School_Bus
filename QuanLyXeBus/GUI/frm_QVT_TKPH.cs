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

namespace QuanLyXeBus.view
{
    public partial class frm_QVT_TKPH : Form
    {
        PhuHuynh_BLL phuhuynh_BLL = new PhuHuynh_BLL();
        public frm_QVT_TKPH()
        {
            InitializeComponent();
        }

        // Tải dữ liệu vào DataGridView
        private void loaddata()
        {
            dgv_QTV_QuanLyTaiKhoanPhuHuynh.DataSource = phuhuynh_BLL.GetAllPhuHuynh();
            dgv_QTV_QuanLyTaiKhoanPhuHuynh.Columns["TaiKhoan_ID"].HeaderText = "ID Phụ huynh";
            dgv_QTV_QuanLyTaiKhoanPhuHuynh.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dgv_QTV_QuanLyTaiKhoanPhuHuynh.Columns["LoaiTK_ID"].HeaderText = "Loại tài khoản";
            dgv_QTV_QuanLyTaiKhoanPhuHuynh.Columns["HoTenPH"].HeaderText = "Họ tên phụ huynh";
            dgv_QTV_QuanLyTaiKhoanPhuHuynh.Columns["Email"].HeaderText = "Email";
            dgv_QTV_QuanLyTaiKhoanPhuHuynh.Columns["SoDT"].HeaderText = "Số điện thoại";
        }
       

        //--------------------------------------------------------------

        private void btn_QTV_ThemPH_Click(object sender, EventArgs e)
        {
            string taiKhoanID = txt_QTV_IDTaiKhoan.Text;
            string matKhau = txt_QTV_MatKhauPhuHuynh.Text;
            string loaiTK_ID = txt_QTV_LoaiTaiKhoanPhuHuynh.Text;
            string hoTenPH = txt_QTV_HoVaTenPhuHuynh.Text;
            string email = txt_QTV_EmailPhuHuynh.Text;
            string soDT = txt_QTV_SoDienThoaiPhuHuynh.Text;

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(taiKhoanID) || string.IsNullOrWhiteSpace(matKhau) ||
                string.IsNullOrWhiteSpace(hoTenPH) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(soDT))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            if (phuhuynh_BLL.IsTaiKhoanExist(taiKhoanID))
            {
                MessageBox.Show("Tài khoản ID đã tồn tại!");
                return;
            }

            // Thêm phụ huynh thông qua BLL
            phuhuynh_BLL.AddPhuHuynh(taiKhoanID, matKhau, loaiTK_ID, hoTenPH, email, soDT);
            MessageBox.Show("Dữ liệu đã được thêm thành công!");

            loaddata(); // Tải lại dữ liệu vào DataGridView
        }

        private void btn_QTV_XoaPH_Click(object sender, EventArgs e)
        {
            if (dgv_QTV_QuanLyTaiKhoanPhuHuynh.SelectedRows.Count > 0)
            {
                string taiKhoanID = dgv_QTV_QuanLyTaiKhoanPhuHuynh.SelectedRows[0].Cells["TaiKhoan_ID"].Value.ToString();

                // Xóa phụ huynh thông qua BLL
                phuhuynh_BLL.DeletePhuHuynh(taiKhoanID);
                MessageBox.Show("Dữ liệu đã được xóa thành công!");

                loaddata(); // Tải lại dữ liệu vào DataGridView
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
            }
        }

        private void btn_QTV_LuuPH_Click(object sender, EventArgs e)
        {
            if (dgv_QTV_QuanLyTaiKhoanPhuHuynh.SelectedRows.Count > 0)
            {
                string taiKhoanID = txt_QTV_IDTaiKhoan.Text;
                string matKhau = txt_QTV_MatKhauPhuHuynh.Text;
                string loaiTK_ID = txt_QTV_LoaiTaiKhoanPhuHuynh.Text;
                string hoTenPH = txt_QTV_HoVaTenPhuHuynh.Text;
                string email = txt_QTV_EmailPhuHuynh.Text;
                string soDT = txt_QTV_SoDienThoaiPhuHuynh.Text;

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(taiKhoanID) || string.IsNullOrWhiteSpace(matKhau) ||
                    string.IsNullOrWhiteSpace(hoTenPH) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(soDT))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Cập nhật phụ huynh thông qua BLL
                phuhuynh_BLL.UpdatePhuHuynh(taiKhoanID, matKhau, loaiTK_ID, hoTenPH, email, soDT);
                MessageBox.Show("Dữ liệu đã được cập nhật thành công!");

                loaddata(); // Tải lại dữ liệu vào DataGridView
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần cập nhật.");
            }
        }

        private void btn_QTV_LamMoi_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong các TextBox
            txt_QTV_IDTaiKhoan.Clear();
            txt_QTV_MatKhauPhuHuynh.Clear();
            //txt_QTV_LoaiTaiKhoanPhuHuynh.Clear();
            txt_QTV_HoVaTenPhuHuynh.Clear();
            txt_QTV_EmailPhuHuynh.Clear();
            txt_QTV_SoDienThoaiPhuHuynh.Clear();

            // Tải lại dữ liệu vào DataGridView
            loaddata();
        }

        private void btn_QTV_TimTaiKhoanPhuHuynh_Click(object sender, EventArgs e)
        {
            string tt = txt_QTV_TimTaiKhoanPhuHuynh.Text.Trim();

            if (string.IsNullOrWhiteSpace(tt))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm!");
                return;
            }

            // Tìm kiếm phụ huynh thông qua BLL
            DataTable dt = phuhuynh_BLL.SearchPhuHuynh(tt);
            dgv_QTV_QuanLyTaiKhoanPhuHuynh.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phụ huynh nào phù hợp.");
            }
        }

        private void dgv_QTV_QuanLyTaiKhoanPhuHuynh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_QTV_QuanLyTaiKhoanPhuHuynh.Rows[e.RowIndex];

                // Lấy dữ liệu từ dòng đã chọn và hiển thị vào các TextBox
                txt_QTV_IDTaiKhoan.Text = row.Cells["TaiKhoan_ID"].Value.ToString();
                txt_QTV_MatKhauPhuHuynh.Text = row.Cells["MatKhau"].Value.ToString();
                txt_QTV_LoaiTaiKhoanPhuHuynh.Text = row.Cells["LoaiTK_ID"].Value.ToString();
                txt_QTV_HoVaTenPhuHuynh.Text = row.Cells["HoTenPH"].Value.ToString();
                txt_QTV_EmailPhuHuynh.Text = row.Cells["Email"].Value.ToString();
                txt_QTV_SoDienThoaiPhuHuynh.Text = row.Cells["SoDT"].Value.ToString();
            }
        }

        private void frm_QVT_TKPH_Load(object sender, EventArgs e)
        {
            loaddata();
            txt_QTV_LoaiTaiKhoanPhuHuynh.Text = "LTK01";
        }
    }
}
