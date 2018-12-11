using System;
using System.Windows.Forms;

using QuanLyBanHangBULs;
using System.Drawing;
using QuanLyBanHangDTOs;
using System.Data.SqlClient;
using QuanLyBanHangLibraries;

/**
 * 
 *@ Author: Trieu Tai Niem 
 *@ Nhom: 6
 *@ Create on: 31/10/2018
 *
 */

namespace QuanLyBanHang.NguyenHuynhDuc
{
    public partial class DangNhapForm : Form
    {
        SqlConnection conn = Helper.SqlCnn;

        public DangNhapForm() {
            InitializeComponent();
        }

        private void DangNhapForm_Load(object sender, EventArgs e) {
        }
     

        public int KiemTraDangNhap(string tenDangNhap, string matKhau) {
            SqlCommand getUserCmd = new SqlCommand("SELECT * FROM users WHERE username = @user AND password = @pwd", Helper.SqlCnn);

            getUserCmd.Parameters.AddWithValue("user", tenDangNhap);
            //ma hoa mat khau truoc khi kiem tra
            getUserCmd.Parameters.AddWithValue("pwd", Helper.MD5Hash(matKhau));

            conn.Open();
            SqlDataReader reader = getUserCmd.ExecuteReader();

            int userInfo = -1;

            if(reader.Read()) {
                userInfo = int.Parse(reader["id"].ToString());
            }

            conn.Close();

            return userInfo;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int idNguoiDung = KiemTraDangNhap(tbUsername.Text, tbPassword.Text);

            if(idNguoiDung >= 0) {
                //mo Main Form
                this.Hide();
                MainForm mainForm = new MainForm(idNguoiDung);
                mainForm.ShowDialog();

                this.Close();

            } else {
                MessageBox.Show("Sai tên tài khoản hoăc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
