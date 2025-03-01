using QuanLyXeBus.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeBus.GUI
{
    public partial class frm_QTV_QLCTHS : Form
    {
        ChiTietHocSinh_BLL chiTietHocSinhBLL = new ChiTietHocSinh_BLL();
        public frm_QTV_QLCTHS()
        {
            InitializeComponent();
            chiTietHocSinhBLL = new ChiTietHocSinh_BLL();
        }

        private void frm_QTV_QLCTHS_Load(object sender, EventArgs e)
        {
            // Load danh sách học sinh vào ComboBox
            LoadHocSinhList();
            // Load danh sách xe bus vào ComboBox
            LoadXeBusList();
            // Load dữ liệu bảng ChiTietDanhSachHocSinh vào DataGridView
            LoadChiTietHocSinhData();

            LoadChiTietHocSinhList();
        }
        

        private void LoadChiTietHocSinhList()
        {
            DataTable dtChiTietHocSinh = chiTietHocSinhBLL.GetAllChiTietDanhSachHocSinh();
            dgv_QTV_DanhSachChiTietHocSinh.DataSource = dtChiTietHocSinh;

        }
        private void LoadHocSinhList()
        {
            DataTable dtHocSinh = chiTietHocSinhBLL.GetHocSinhChuaCoXeBus();

            if (dtHocSinh != null && dtHocSinh.Rows.Count > 0)
            {
                cbb_QTV_ID_HS.DataSource = dtHocSinh;         // Gán dữ liệu vào ComboBox
                cbb_QTV_ID_HS.DisplayMember = "HoTenHS";      // Hiển thị tên học sinh
                cbb_QTV_ID_HS.ValueMember = "HocSinh_ID";     // Lấy giá trị là ID học sinh
            }
            else
            {
                MessageBox.Show("Không có học sinh nào chưa có xe buýt.");
                cbb_QTV_ID_HS.DataSource = null;
            }
        }

        // Load danh sách xe bus vào ComboBox
        private void LoadXeBusList()
        {
            DataTable dtXeBus = chiTietHocSinhBLL.GetXeBusList();
            cbb_QTV_ID_XeBus.DataSource = dtXeBus;
            cbb_QTV_ID_XeBus.DisplayMember = "Bus_ID";
            cbb_QTV_ID_XeBus.ValueMember = "Bus_ID";
        }

        // Load dữ liệu ChiTietDanhSachHocSinh vào DataGridView
        private void LoadChiTietHocSinhData()
        {
            string searchKeyword = txt_QTV_TimKiemChiTietHocSinh.Text.Trim();
            DataTable dt = chiTietHocSinhBLL.SearchChiTietHocSinh(searchKeyword);
            dgv_QTV_DanhSachChiTietHocSinh.DataSource = dt;
        }

        private void btn_QTV_TaoID_CTHS_Click(object sender, EventArgs e)
        {
            try
            {
                // Gọi phương thức GenerateNewCTDSHSID từ BLL
                string newID = chiTietHocSinhBLL.GenerateNewCTDSHSID("CTDSHS");

                // Hiển thị mã mới trong TextBox
                txt_QTV_TaoID_CTHS.Text = newID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã tự động: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_QTV_TimKiemChiTietHocSinh_Click(object sender, EventArgs e)
        {
            LoadChiTietHocSinhData();
        }

        private void btn_QTV_ThemChiTietHocSinh_Click(object sender, EventArgs e)
        {
            try
            {
                string CT_DSHS_ID = txt_QTV_TaoID_CTHS.Text.Trim();
                string Bus_ID = cbb_QTV_ID_XeBus.SelectedValue.ToString();
                string HocSinh_ID = cbb_QTV_ID_HS.SelectedValue.ToString();

                // Gọi BLL để thêm dữ liệu
                bool result = chiTietHocSinhBLL.AddChiTietHocSinh(CT_DSHS_ID, Bus_ID, HocSinh_ID);

                if (result)
                {
                    MessageBox.Show("Thêm học sinh vào xe buýt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChiTietHocSinhData();   // Làm mới DataGridView
                    LoadHocSinhList();          // Làm mới ComboBox học sinh
                }
            }
            catch (SqlException ex)
            {
                // Hiển thị thông báo từ trigger
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_QTV_XoaChiTietHocSinh_Click(object sender, EventArgs e)
        {
            if (dgv_QTV_DanhSachChiTietHocSinh.SelectedRows.Count > 0)
            {
                string CT_DSHS_ID = dgv_QTV_DanhSachChiTietHocSinh.SelectedRows[0].Cells["CT_DSHS_ID"].Value.ToString();
                bool result = chiTietHocSinhBLL.DeleteChiTietHocSinh(CT_DSHS_ID);
                if (result)
                {
                    MessageBox.Show("Xóa chi tiết học sinh thành công!");
                    LoadChiTietHocSinhData();  // Tải lại dữ liệu
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
            }
        }

        private void btn_QTV_LamMoiCTHS_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa nội dung tìm kiếm (nếu có)
                txt_QTV_TimKiemChiTietHocSinh.Clear();

                // Làm mới ComboBox danh sách học sinh chưa có xe bus
                LoadHocSinhList();

                // Làm mới ComboBox danh sách xe bus
                LoadXeBusList();

                // Làm mới DataGridView danh sách chi tiết học sinh
                LoadChiTietHocSinhData();

                // Xóa các trường nhập liệu (nếu cần)
                txt_QTV_TaoID_CTHS.Clear();
                cbb_QTV_ID_HS.SelectedIndex = -1;   // Bỏ chọn ComboBox
                cbb_QTV_ID_XeBus.SelectedIndex = -1;

                MessageBox.Show("Làm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi làm mới dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
