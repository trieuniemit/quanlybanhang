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

            con.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Mời bạn nhập vào Tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            con.Open();

            string SqlINSERT = "INSERT INTO product_cats VALUES(@ten)";

            SqlCommand command = new SqlCommand(SqlINSERT, con);
            command.Parameters.AddWithValue("ten", txtTen.Text);
            command.ExecuteNonQuery();

            con.Close();

            hienThiLoaiSanPham();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            con.Open();

            string SqlUPDATE = "UPDATE product_cats SET name = @ten WHERE cat_id = @ma";
            SqlCommand command = new SqlCommand(SqlUPDATE, con);
            command.Parameters.AddWithValue("ma", dgvDanhSach.SelectedRows[0].Cells[0].ToString());
            command.Parameters.AddWithValue("ten", txtTen.Text);
            command.ExecuteNonQuery();

            con.Close();

            hienThiLoaiSanPham();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            con.Open();

            string SqlDELETE = "DELETE product_cats WHERE cat_id= @ma";
            SqlCommand command = new SqlCommand(SqlDELETE, con);
            command.Parameters.AddWithValue("ma", dgvDanhSach.SelectedRows[0].Cells[0].ToString());
            command.ExecuteNonQuery();

            con.Close();

            hienThiLoaiSanPham();
        }

        public void xoaCacBanGhiTrenTextbox()
        {
            txtTen.Clear();
        }
    }
}
