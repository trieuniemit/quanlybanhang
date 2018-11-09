using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHangLibraries;

/**
 * 
 *@ Author: Trieu Tai Niem 
 *@ Nhom: 6
 *@ Create on: 31/10/2018
 *
 */

namespace QuanLyBanHang
{
    public partial class MainForm : Form {
        LoginForm loginForm;

        public MainForm(LoginForm lg) {
            InitializeComponent();
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBackground);

            loginForm = lg;
        }
      
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            
        }

        private void DrawBackground(Object sender, PaintEventArgs e) {
            Helper.Gradient(e.Graphics, Width, Height, Color.ForestGreen, Color.Green, 90f);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            Forms.BanHangForm banHangForm = new Forms.BanHangForm();
            banHangForm.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            Forms.QuanLyLoaiSanPhamForm sanPhamForm = new Forms.QuanLyLoaiSanPhamForm();
            sanPhamForm.Show();
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            Forms.QuanLyLoaiSanPhamForm loaiSanPhamForm = new Forms.QuanLyLoaiSanPhamForm();
            loaiSanPhamForm.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Forms.ThongKeForm thongKeForm = new Forms.ThongKeForm();
            thongKeForm.Show();
        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            Forms.ThongTinCaNhanForm thongTinCaNhanForm = new Forms.ThongTinCaNhanForm();
            thongTinCaNhanForm.Show();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            Forms.ThongTinCaNhanForm thongTinCaNhanForm = new Forms.ThongTinCaNhanForm();
            thongTinCaNhanForm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
