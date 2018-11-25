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
    public partial class QuanLyNhanVien : Form
    {
        SqlConnection conn = Helper.SqlCnn;
        int UserId;

        public QuanLyNhanVien(int userId)
        {
            UserId = userId;
            InitializeComponent();
        }

        void HienThi() {
            SqlCommand hienThiCmd = new SqlCommand("SELECT * FROM users WHERE id != " + UserId, Helper.SqlCnn);

            Helper.SqlCnn.Open();

            SqlDataReader reader = hienThiCmd.ExecuteReader();

            dgvDanhSachNhanVien.Rows.Clear();
            dgvDanhSachNhanVien.ColumnCount = 8;
            
            dgvDanhSachNhanVien.Columns[0].HeaderText = "Tên đăng nhập";
            dgvDanhSachNhanVien.Columns[1].HeaderText = "Họ và tên";
            dgvDanhSachNhanVien.Columns[2].HeaderText = "Số điện thoại";
            dgvDanhSachNhanVien.Columns[3].HeaderText = "Email";
            dgvDanhSachNhanVien.Columns[4].HeaderText = "Giới tính";
            dgvDanhSachNhanVien.Columns[5].HeaderText = "Chức vụ";
            dgvDanhSachNhanVien.Columns[6].HeaderText = "Ngày sinh";
            dgvDanhSachNhanVien.Columns[7].HeaderText = "Đã tạo ngày";

            while(reader.Read()) {
                dgvDanhSachNhanVien.Rows.Add(
                        reader["username"].ToString(),
                        reader["fullname"].ToString(),
                        reader["phone"].ToString(),
                        reader["email"].ToString(),
                        Helper.GetGenderName(int.Parse(reader["gender"].ToString())),
                        Helper.GetUserRole(int.Parse(reader["role"].ToString())),
                        Convert.ToDateTime(reader["date_of_birth"].ToString()).ToString("dd/MM/yyyy"),
                        Convert.ToDateTime(reader["created_at"].ToString())
                    );
            }

            conn.Close();

        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVienForm themMoi = new NhanVienForm();
            themMoi.ShowDialog();
            HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachNhanVien.SelectedRows.Count > 0) {
                string username = dgvDanhSachNhanVien.SelectedRows[0].Cells[0].Value.ToString();
                NhanVienForm themMoi = new NhanVienForm(username);
                themMoi.ShowDialog();
                HienThi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa các nhân viên đã chọn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(kq == DialogResult.Yes) {
                conn.Open();

                for(int i = 0; i < dgvDanhSachNhanVien.SelectedRows.Count; i++) {
                    SqlCommand xoa = new SqlCommand("DELETE FROM users WHERE username = '"+ dgvDanhSachNhanVien.SelectedRows[i].Cells[0].Value.ToString() +"'", conn);
                    xoa.ExecuteNonQuery();
                }

                conn.Close();

                HienThi();
            }
        }
    }
}
