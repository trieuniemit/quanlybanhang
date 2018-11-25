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

namespace QuanLyBanHang.DuongDucSon
{
    public partial class NhanVienForm : Form
    {
        string MaNV = ""; 
        SqlConnection conn = Helper.SqlCnn;

        public NhanVienForm()
        {
            InitializeComponent();
        }

        public NhanVienForm(string maNV)
        {
            MaNV = maNV;
            InitializeComponent();
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            //ma NV = -1, FORM hien tai la form them, nguoc lai la FORM sửa
            cbbRole.SelectedIndex = 0;

            if(MaNV != "") {
                lbTitle.Text = "Chỉnh sưa thông tin nhân viên";
                this.Text = "Chỉnh sửa thông tin nhân viên";
                btnThem.Text = "Cập nhật";
                tbTenDangNhap.ReadOnly = true;
                Helper.SqlCnn.Open();

                SqlCommand layThongTin = new SqlCommand("SELECT * FROM users WHERE username = '"+MaNV+"'", conn);
                SqlDataReader dr = layThongTin.ExecuteReader();

                if(dr.Read()) {
                    tbTenDangNhap.Text = dr["username"].ToString().Trim();
                    tbHoTen.Text = dr["fullname"].ToString();
                    tbSoDienThoai.Text = dr["phone"].ToString();
                    tbEmail.Text = dr["email"].ToString();
                    cbbRole.SelectedIndex = int.Parse(dr["role"].ToString()) - 1;
                    
                    if(dr["gender"].ToString() == "0")
                        rbNam.Checked = true;
                    else 
                        rbNu.Checked = true;

                    dtpNgaySinh.Value = Convert.ToDateTime(dr["date_of_birth"].ToString());
                }

                Helper.SqlCnn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(KiemTraDieuLieu()) {
                if(MaNV != "") {
                    conn.Open();
                    SqlCommand suaNhanVienCmd = new SqlCommand("UPDATE users SET fullname = @Fullname, password = @Password, phone = @Phone, email = @Email, role = @Role, gender = @Gender, date_of_birth = CONVERT(datetime,@DateOfBirth, 103), created_at = CONVERT(datetime, @Created_at, 103) WHERE username = '"+MaNV+"'", conn);

                    suaNhanVienCmd.Parameters.AddWithValue("Username", tbTenDangNhap.Text);
                    suaNhanVienCmd.Parameters.AddWithValue("Fullname", tbHoTen.Text);
                    suaNhanVienCmd.Parameters.AddWithValue("Password", Helper.MD5Hash(tbMatKhau.Text));
                    suaNhanVienCmd.Parameters.AddWithValue("Phone", tbSoDienThoai.Text);
                    suaNhanVienCmd.Parameters.AddWithValue("Email", tbEmail.Text);
                    suaNhanVienCmd.Parameters.AddWithValue("Role", cbbRole.SelectedIndex+1);
                    suaNhanVienCmd.Parameters.AddWithValue("Gender", rbNam.Checked?0:1);
                    suaNhanVienCmd.Parameters.AddWithValue("DateOfBirth", dtpNgaySinh.Value.ToString("dd/MM/yyyy"));
                    suaNhanVienCmd.Parameters.AddWithValue("Created_at", Helper.GetDateNow());

                    suaNhanVienCmd.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();

                    this.Close();
                } else {
                    conn.Open();
                    SqlCommand themNhanVienCmd = new SqlCommand("INSERT INTO users VALUES(@Username, @Fullname, @Password, @Phone, @Email, @Role, @Gender, CONVERT(datetime,@DateOfBirth, 103), CONVERT(datetime, @Created_at, 103))", conn);

                    themNhanVienCmd.Parameters.AddWithValue("Username", tbTenDangNhap.Text);
                    themNhanVienCmd.Parameters.AddWithValue("Fullname", tbHoTen.Text);
                    themNhanVienCmd.Parameters.AddWithValue("Password", Helper.MD5Hash(tbMatKhau.Text));
                    themNhanVienCmd.Parameters.AddWithValue("Phone", tbSoDienThoai.Text);
                    themNhanVienCmd.Parameters.AddWithValue("Email", tbEmail.Text);
                    themNhanVienCmd.Parameters.AddWithValue("Role", cbbRole.SelectedIndex+1);
                    themNhanVienCmd.Parameters.AddWithValue("Gender", rbNam.Checked?0:1);
                    themNhanVienCmd.Parameters.AddWithValue("DateOfBirth", dtpNgaySinh.Value.ToString("dd/MM/yyyy"));
                    themNhanVienCmd.Parameters.AddWithValue("Created_at", Helper.GetDateNow());

                    themNhanVienCmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();

                    this.Close();
                }
            }
        }

        private bool KiemTraDieuLieu() {
            if (tbTenDangNhap.Text == "")
            {
                MessageBox.Show("Mời bạn nhập vào tên đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbHoTen.Text == "")
            {
                MessageBox.Show("Mời bạn nhập vào họ tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if(tbEmail.Text =="")
            { 
                MessageBox.Show("Mời bạn nhập vào email!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbSoDienThoai.Text == "")
            {
                MessageBox.Show("Mời bạn nhập vào SĐT!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cho tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
