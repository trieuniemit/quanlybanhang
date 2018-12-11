using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class CaiDatForm : Form
    {
        public CaiDatForm()
        {
            InitializeComponent();
        }

        private void CaiDatForm_Load(object sender, EventArgs e)
        {
            tbDiaChi.Text = Properties.Settings.Default.Address;
            tbSoDienThoai.Text = Properties.Settings.Default.NumberPhone;
            tbTenCuaHang.Text = Properties.Settings.Default.StoreName;
        }

        private void SaveSettings() {
            Properties.Settings.Default.Address = tbDiaChi.Text;
            Properties.Settings.Default.NumberPhone = tbSoDienThoai.Text;
            Properties.Settings.Default.StoreName = tbTenCuaHang.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Đã lưu cài đặt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}
