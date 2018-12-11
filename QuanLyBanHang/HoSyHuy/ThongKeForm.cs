using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHangLibraries;

using System.Data.SqlClient;

namespace QuanLyBanHang.HoSyHuy
{
    public partial class ThongKeForm : Form
    {
        SqlConnection conn = Helper.SqlCnn;

        public ThongKeForm()
        {
            InitializeComponent();
        }
        
        private int DemSoDongTrongBang(string table) {
            int tongSoDong = 0;
            SqlCommand countRowsCmd = new SqlCommand("SELECT COUNT(*) FROM "+table, Helper.SqlCnn);

            conn.Open();
            try {
                tongSoDong = int.Parse(countRowsCmd.ExecuteScalar().ToString());
            } catch (SqlException e) {
                Console.WriteLine(e.ToString());
            }

            conn.Close();
            return tongSoDong;
        }


        //lay tong doanh thu
        public int LayTongDoanhThu() {
            int tongDoanhThu = 0;
            conn.Open();

            SqlCommand demTongDoanhThuCmd = new SqlCommand("SELECT SUM(total) FROM orders", Helper.SqlCnn);

            try {
                tongDoanhThu = int.Parse(demTongDoanhThuCmd.ExecuteScalar().ToString());
            } catch (SqlException e) {
                Console.WriteLine(e.ToString());
            }

            conn.Close();
            return tongDoanhThu;
        }

        //Lay Doanh Thu Cua Mot Thang Theo Nam
        public int LayDoanhThuCuaMotThangTheoNam(int year, int month) {
            int doanhThu = 0;
            conn.Open();
            
            int daysOfMonth = DateTime.DaysInMonth(year, month);

            string startDate = year + "-" + month + "-1 00:00:00";
            string endDate = year + "-" + month+ "-" + daysOfMonth + " 23:59:59";

            SqlCommand demDoanhThuThangCmd = new SqlCommand("SELECT SUM(total) FROM orders WHERE created_at >= '"+startDate + "' AND created_at < '" + endDate +"'" , Helper.SqlCnn);

            try {
                string ketQua = demDoanhThuThangCmd.ExecuteScalar().ToString();
                if(ketQua != "") 
                    doanhThu = int.Parse(ketQua);

            } catch (SqlException e) {
                Console.WriteLine(e.ToString());
            }

            conn.Close();
            return doanhThu;
        }

        //lay min max cua so nam hoat dong
        private void LayMinMaxSoNamHoatDong() {
            cbbDoanhThuTheoNam.DisplayMember = "Text";
            cbbDoanhThuTheoNam.ValueMember = "Value";

            List<int> namHoatDong = new List<int>();

            conn.Open();

            SqlCommand getYears = new SqlCommand("SELECT MIN(created_at) AS min, MAX(created_at) AS max FROM orders", Helper.SqlCnn);
            SqlDataReader dr = getYears.ExecuteReader();
            
            while(dr.Read()) {
                namHoatDong.Add(Convert.ToDateTime(dr["min"]).Year);
                namHoatDong.Add(Convert.ToDateTime(dr["max"]).Year);
            }

            conn.Close();

            for(int i = namHoatDong[1]; i >= namHoatDong[0]; i-- ) {
                cbbDoanhThuTheoNam.Items.Add(new {Text = i, Value = i});
            }

            if(cbbDoanhThuTheoNam.Items.Count > 0)
                cbbDoanhThuTheoNam.SelectedIndex = 0;
        }


        //Khoi tao thong ke
        private void KhoiTaoThongKe() {
            lbSoHangDaBan.Text = DemSoDongTrongBang("orders").ToString();
            lbTongDanhMuc.Text = DemSoDongTrongBang("product_cats").ToString();

            lbTongDoanhThu.Text = Helper.CurrencyFormat(LayTongDoanhThu().ToString());

            lbTongNhanVien.Text = DemSoDongTrongBang("users").ToString();
            lbTongSanPham.Text =  DemSoDongTrongBang("products").ToString();
        }

        private void KhoiTaoDataGridView(int year) {
            dgvDoanhThu.ColumnCount = 2;
            dgvDoanhThu.Columns[0].HeaderText = "Tháng/Năm";
            dgvDoanhThu.Columns[1].HeaderText = "Doanh Thu";
        }

        private void ThongKeForm_Load(object sender, EventArgs e)
        {
            KhoiTaoThongKe();
            LayMinMaxSoNamHoatDong();
        }

        private void cbbDoanhThuTheoNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = Convert.ToInt32((cbbDoanhThuTheoNam.SelectedItem as dynamic).Value);
            KhoiTaoDataGridView(year);
        }

        private void dvgDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
