using System;
using System.Windows.Forms;
using QuanLyBanHangLibraries;
using QuanLyBanHangLibraries.Classes;
using QuanLyBanHangBULs;
using System.Drawing;

/**
 * 
 *@ Author: Trieu Tai Niem 
 *@ Nhom: 6
 *@ Create on: 31/10/2018
 *
 */

namespace QuanLyBanHang
{
    public partial class LoginForm : FormNoneHeader
    {
        LoginBUL loginBul = new LoginBUL();

        public LoginForm() {
            InitializeComponent();
        }
        
        private void OpenMainForm() {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e) {
            tbUsername.Text = Properties.Settings.Default.Username;
            tbPassword.Text = Properties.Settings.Default.Password;
        }
        
        private void DrawBackground(Object sender, PaintEventArgs e) {
            Helper.Gradient(e.Graphics, Width, Height, Color.RoyalBlue, Color.Transparent, 90f);
        }

        private void pbClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(loginBul.CheckLogin(tbUsername.Text, tbPassword.Text)) {

                //opend Main Form if loged in
                if(cbRemember.Checked) {
                    Properties.Settings.Default.Username = tbUsername.Text;
                    Properties.Settings.Default.Password = tbPassword.Text;
                    Properties.Settings.Default.Save();
                } else {
                    Properties.Settings.Default.Username = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                }

                OpenMainForm();

            } else {
                MessageBox.Show("Sai tài khoản hoăc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
