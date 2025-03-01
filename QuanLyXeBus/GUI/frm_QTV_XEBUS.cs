using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyXeBus.BLL;
using QuanLyXeBus.BusinessLogic;

namespace QuanLyXeBus.view
{
    public partial class frm_QTV_XEBUS : Form
    {
        private XeBus_BLL xeBusBLL = new XeBus_BLL();
        public frm_QTV_XEBUS()
        {
            InitializeComponent();

        }

        private void frm_QTV_XEBUS_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.None;
            this.AutoSize = false;
            this.MaximumSize = this.Parent.ClientSize; // Không vượt quá kích thước cha (panel1)
            this.MinimumSize = this.Parent.ClientSize;

            LoadDataXeBus();
            LoadComboBoxTaiXe();
            LoadComboBoxTrangThai();
        }

        private void LoadDataXeBus()
        {
            dgv_QTV_XeBus.DataSource = xeBusBLL.GetAllXeBus();
            // Thiết lập tiêu đề cột cho DataGridView
            dgv_QTV_XeBus.Columns["Bus_ID"].HeaderText = "ID Xe Bus";
            dgv_QTV_XeBus.Columns["SoXeBus"].HeaderText = "Biển Số Xe";
            dgv_QTV_XeBus.Columns["SoGhe"].HeaderText = "Số Ghế";
            dgv_QTV_XeBus.Columns["TaiXe_ID"].HeaderText = "Tài Xế";
            dgv_QTV_XeBus.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }

        private void LoadComboBoxTaiXe()
        {
            DataTable dtTaiXe = xeBusBLL.GetAllTaiXe(); 
            cbb_QTV_TaiXe.DataSource = dtTaiXe;
            cbb_QTV_TaiXe.DisplayMember = "HoTenTX";  // Hiển thị tên tài xế trong ComboBox
            cbb_QTV_TaiXe.ValueMember = "TaiKhoan_ID";  // Giá trị của mỗi mục là TaiKhoan_ID
        }

        private void LoadComboBoxTrangThai()
        {
            cbb_QTV_TrangThaiXeBus.Items.Clear();
            cbb_QTV_TrangThaiXeBus.Items.Add("Đang hoạt động");
            cbb_QTV_TrangThaiXeBus.Items.Add("Đang bảo trì");
            cbb_QTV_TrangThaiXeBus.SelectedIndex = 0;
        }

        
//-------------------------------------------------------------------------------
        private void btn_QTV_ThemXeBus_Click(object sender, EventArgs e)
        {
            string idXeBus = txt_QTV_IDXeBus.Text;
            string bienSoXe = txt_QTV_BienSoXe.Text;
            int soGhe = int.Parse(txt_QTV_SoGhe.Text);
            string taiXeID = cbb_QTV_TaiXe.SelectedValue?.ToString();
            string trangThai = cbb_QTV_TrangThaiXeBus.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(idXeBus) || string.IsNullOrWhiteSpace(bienSoXe) || soGhe <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu tài xế đã được gán xe khác
            if (!string.IsNullOrEmpty(taiXeID))
            {
                if (xeBusBLL.CheckTaiXeIsAssigned(taiXeID))
                {
                    MessageBox.Show("Tài xế này đã được gán vào xe khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            bool success = xeBusBLL.AddXeBus(idXeBus, bienSoXe, soGhe, taiXeID, trangThai);

            if (success)
            {
                MessageBox.Show("Thêm xe bus thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataXeBus();
            }
            else
            {
                MessageBox.Show("Thêm xe bus thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_QTV_XoaXeBus_Click(object sender, EventArgs e)
        {
            //if (dgv_QTV_XeBus.SelectedRows.Count > 0)
            //{
                string idXeBus = dgv_QTV_XeBus.SelectedRows[0].Cells["Bus_ID"].Value.ToString();
                bool success = xeBusBLL.DeleteXeBus(idXeBus);

                if (success)
                {
                    MessageBox.Show("Xóa xe bus thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataXeBus();
                }
                else
                {
                    MessageBox.Show("Xóa xe bus thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn một xe bus để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void btn_QTV_CapNhatXeBus_Click(object sender, EventArgs e)
        {
            //if (dgv_QTV_XeBus.SelectedRows.Count > 0)
            //{
                string idXeBus = txt_QTV_IDXeBus.Text;
                string bienSoXe = txt_QTV_BienSoXe.Text;
                int soGhe = int.Parse(txt_QTV_SoGhe.Text);
                string taiXeID = cbb_QTV_TaiXe.SelectedValue?.ToString();
                string trangThai = cbb_QTV_TrangThaiXeBus.SelectedItem?.ToString();

                bool success = xeBusBLL.UpdateXeBus(idXeBus, bienSoXe, soGhe, taiXeID, trangThai);

                if (success)
                {
                    MessageBox.Show("Cập nhật thông tin xe bus thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataXeBus();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn một xe bus để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void btn_QTV_LamMoiXeBus_Click(object sender, EventArgs e)
        {
            txt_QTV_IDXeBus.Clear();
            txt_QTV_BienSoXe.Clear();
            txt_QTV_SoGhe.Clear();
            cbb_QTV_TaiXe.SelectedIndex = -1;
            cbb_QTV_TrangThaiXeBus.SelectedIndex = 0;
            LoadDataXeBus();
        }

        private void btn_QTV_TimKiemXeBus_Click(object sender, EventArgs e)
        {
            string tt = txt_QTV_TimKiemXeBus.Text.Trim();

            if (string.IsNullOrWhiteSpace(tt))
            {
                LoadDataXeBus();
                return;
            }

            var result = xeBusBLL.SearchXeBus(tt);
            dgv_QTV_XeBus.DataSource = result;

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_QTV_XeBus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_QTV_XeBus.Rows[e.RowIndex];
                txt_QTV_IDXeBus.Text = row.Cells["Bus_ID"].Value.ToString();      
                txt_QTV_BienSoXe.Text = row.Cells["SoXeBus"].Value.ToString();      
                txt_QTV_SoGhe.Text = row.Cells["SoGhe"].Value.ToString();          
                cbb_QTV_TrangThaiXeBus.SelectedItem = row.Cells["TrangThai"].Value?.ToString();
                if (row.Cells["TaiXe_ID"].Value != DBNull.Value)
                {
                    cbb_QTV_TaiXe.SelectedValue = row.Cells["TaiXe_ID"].Value.ToString();
                }
                else
                {
                    cbb_QTV_TaiXe.SelectedIndex = -1; 
                }
            }
        }
    }
}
