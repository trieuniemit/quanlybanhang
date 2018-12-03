using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHangLibraries;

namespace QuanLyBanHang.NguyenHuynhDuc
{
    public partial class SuaThongTinCaNhan : Form
    {
        int UserId;

        SqlConnection con = Helper.SqlCnn;

        public SuaThongTinCaNhan(int currentUserId)
        {
            UserId = currentUserId;

            InitializeComponent();
        }

        private void SuaThongTInCanNhan_Load(object sender, EventArgs e)
        {
            InitInfo();
        }

        void InitInfo()
        {

            SqlCommand getCurrentUser = new SqlCommand("SELECT * FROM users WHERE id = " + UserId, con);
            con.Open();
            SqlDataReader dr = getCurrentUser.ExecuteReader();

            while (dr.Read())
            {
                txtHoTen.Text = dr["fullname"].ToString();
                txtEmail.Text = dr["email"].ToString();
                txtSoDT.Text = dr["phone"].ToString();

                int gender = int.Parse(dr["gender"].ToString());

                dtpNgaySinh.Value = Convert.ToDateTime(dr["date_of_birth"].ToString());

                if (gender == 0)
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;

            }


            con.Close();
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Mời bạn nhập vào họ tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtEmail.Text =="")
            { 
                MessageBox.Show("Mời bạn nhập vào email!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSoDT.Text == "")
            {
                MessageBox.Show("Mời bạn nhập vào SĐT!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.Open();

            string SqlUPDATE = "UPDATE users SET fullname = @ten, email = @email,phone = @sdt,gender = @gioitinh,date_of_birth = @ngaysinh  WHERE id = " + UserId;
            SqlCommand command = new SqlCommand(SqlUPDATE, con);

            command.Parameters.AddWithValue("ten", txtHoTen.Text);
            command.Parameters.AddWithValue("email", txtEmail.Text);
            command.Parameters.AddWithValue("sdt", txtSoDT.Text);
            command.Parameters.AddWithValue("gioitinh", rdbNam.Checked ? 0 : 1);
            command.Parameters.AddWithValue("date_of_birth", dtpNgaySinh.Text);
            command.Parameters.AddWithValue("ngaysinh", dtpNgaySinh.Value.ToString("yyyy-MM-dd"));
            command.ExecuteNonQuery();

            MessageBox.Show("Đổi thông tin cá nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSoDT.Clear();
        }


        private void btnLuuMatKhau_Click(object sender, EventArgs e)
        {
            if(txtMatKhauCu.Text == "")  {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtMatKhauMoi.Text == "") {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtNhapLaiMKMoi.Text == "") {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtNhapLaiMKMoi.Text != txtMatKhauMoi.Text) {
                MessageBox.Show("Mật khẩu mới không trùng khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check password
            Helper.SqlCnn.Open();
            SqlCommand checkPassword = new SqlCommand("SELECT COUNT(*) FROM users WHERE password = '" + Helper.MD5Hash(txtMatKhauCu.Text) +"' AND id = " + UserId, Helper.SqlCnn);
            int countRow = int.Parse(checkPassword.ExecuteScalar().ToString());
            Helper.SqlCnn.Close();

            if(countRow < 1 ) {
                MessageBox.Show("Mật khẩu cũ không chính xác! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //update password
            Helper.SqlCnn.Open();
            SqlCommand updatePassword = new SqlCommand("UPDATE users SET password = '" + Helper.MD5Hash(txtMatKhauMoi.Text) +"' WHERE id = " + UserId, Helper.SqlCnn);
            updatePassword.ExecuteNonQuery();
            Helper.SqlCnn.Close();

            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtNhapLaiMKMoi.Text = "";

        }

    }
}
