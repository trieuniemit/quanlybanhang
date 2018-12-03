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
    public partial class QuanLyLoaiSanPham : Form
    {
        public QuanLyLoaiSanPham()
        {
            InitializeComponent();
        }

        string tuyChon = "";

        SqlConnection con;

        private void QuanLyLoaiSanPham_Load(object sender, EventArgs e)
        {
            con = Helper.SqlCnn;
            hienThiLoaiSanPham();
        }

        private void hienThiLoaiSanPham()
        {   
            con.Open();
            string SqlSELECT = "SELECT * FROM product_cats";
            SqlCommand command = new SqlCommand(SqlSELECT, con);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvDanhSach.DataSource = dt;

            dgvDanhSach.Columns[0].HeaderText = "Mã Loại";
            dgvDanhSach.Columns[1].HeaderText = "Tên Loại";

            con.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Mời bạn nhập vào Tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(tuyChon == "sua") {
                con.Open();

                string SqlUPDATE = "UPDATE product_cats SET name = @ten WHERE cat_id = @ma";
                SqlCommand cmdSua = new SqlCommand(SqlUPDATE, con);
                cmdSua.Parameters.AddWithValue("ma", int.Parse(dgvDanhSach.SelectedRows[0].Cells[0].Value.ToString()));
                cmdSua.Parameters.AddWithValue("ten", txtTen.Text);
                cmdSua.ExecuteNonQuery();

                con.Close();

                txtTen.Text = "";
                btnCapNhat.Text = "Thêm Mới";
                tuyChon = "";

            } else {

                con.Open();

                string SqlINSERT = "INSERT INTO product_cats VALUES(@ten)";

                SqlCommand cmdThem = new SqlCommand(SqlINSERT, con);
                cmdThem.Parameters.AddWithValue("ten", txtTen.Text);
                cmdThem.ExecuteNonQuery();

                txtTen.Text = "";
                con.Close();
            }

            hienThiLoaiSanPham();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có chắc chắn muốn xóa Loại Sản Phẩm đã chọn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(chon != DialogResult.Yes) 
                return;

            con.Open();

            try{
                string SqlDELETE = "DELETE product_cats WHERE cat_id= @ma";
                SqlCommand command = new SqlCommand(SqlDELETE, con);
                command.Parameters.AddWithValue("ma", dgvDanhSach.SelectedRows[0].Cells[0].Value.ToString());
                command.ExecuteNonQuery();
            } catch(SqlException err) {
                MessageBox.Show("Không thể xóa loại sản phẩm này, do đang được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(err.ToString());
            }

            con.Close();

            hienThiLoaiSanPham();
        }

        public void xoaCacBanGhiTrenTextbox()
        {
            txtTen.Clear();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTen.Text = dgvDanhSach.SelectedRows[0].Cells[1].Value.ToString();
            tuyChon = "sua";
            btnCapNhat.Text = "Cập Nhật";
            btnThemMoi.Visible = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            tuyChon = "them";
            btnCapNhat.Text = "Thêm";
            btnThemMoi.Visible = false;
        }
    }
}
