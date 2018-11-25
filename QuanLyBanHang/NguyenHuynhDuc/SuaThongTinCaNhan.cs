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
        int UserId = 0;
        SqlConnection con = Helper.SqlCnn;

        public SuaThongTinCaNhan()
        {
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

                if (gender == 0)
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;

            }


            con.Close();
        }

        private void ktra(CheckBox rdbNam,CheckBox rdbNu)
        {
            try
            {
                rdbNam.Checked = false;
                rdbNu.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Mời chọn giới tính","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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
            command.Parameters.AddWithValue("ngaysinh", dtpNgaySinh.Value.ToString("yyyy-MM-dd 00:00:00"));
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

    }
}
