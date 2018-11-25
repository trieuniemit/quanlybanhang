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

namespace QuanLyBanHang.HoSyHuy
{
    public partial class QuanLySanPhamForm : Form
    {
        public QuanLySanPhamForm()
        {
            InitializeComponent();
        }
        SqlConnection con;

        private void Form1_Load(object sender, EventArgs e)
        {
            con = Helper.SqlCnn;
            hienThi();
        }

       
        public void hienThi()
        {
            con.Open();
            string select = "SELECT id,products.name AS product_name,product_cats.name AS product_cats_name,unit,count,price,promo_price,status,created_at,updated_at FROM products,product_cats WHERE products.cat_id = product_cats.cat_id";
            SqlCommand cmd = new SqlCommand(select, con);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgvDS.DataSource = dt;

            dgvDS.Columns[0].HeaderText = "Mã sản phẩm";
            dgvDS.Columns[0].Width = 70;
            dgvDS.Columns[1].HeaderText = "Tên sản phẩm";
            dgvDS.Columns[1].Width = 150;
            dgvDS.Columns[2].HeaderText = "Loại sản phẩm";
            dgvDS.Columns[2].Width = 100;
            dgvDS.Columns[3].HeaderText = "Đơn vị";
            dgvDS.Columns[3].Width = 100;
            dgvDS.Columns[4].HeaderText = "Số Lượng";
            dgvDS.Columns[4].Width = 100;
            dgvDS.Columns[5].HeaderText = "Giá";
            dgvDS.Columns[5].Width = 100;
            dgvDS.Columns[6].HeaderText = "Giá khuyến mại";
            dgvDS.Columns[6].Width = 100;
            dgvDS.Columns[7].HeaderText = "Tình trạng";
            dgvDS.Columns[7].Width = 100;
            dgvDS.Columns[8].HeaderText = "Thời gian tạo";
            dgvDS.Columns[8].Width = 150;
            dgvDS.Columns[9].HeaderText = "Thời gian sửa";
            dgvDS.Columns[9].Width = 150;

            con.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSuaSanPham addForm = new ThemSuaSanPham();
            addForm.ShowDialog();
            hienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ThemSuaSanPham editForm = new ThemSuaSanPham(int.Parse(dgvDS.SelectedRows[0].Cells[0].Value.ToString()));
            editForm.ShowDialog();
            hienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            con.Open();
            int index = dgvDS.CurrentRow.Index;
            SqlCommand cmd = new SqlCommand("DELETE FROM products WHERE id = @maSP",con);

            cmd.Parameters.AddWithValue("maSP",dgvDS.Rows[index].Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();

            con.Close();
            hienThi();
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
