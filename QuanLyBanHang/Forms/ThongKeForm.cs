using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHangBULs;
using QuanLyBanHangLibraries;

namespace QuanLyBanHang.Forms
{
    public partial class ThongKeForm : Form
    {
        ThongKeBUL ThongKeBul = new ThongKeBUL();

        public ThongKeForm()
        {
            InitializeComponent();
        }

        private void InitStatistical() {
            lbSoHangDaBan.Text = ThongKeBul.CountOrders().ToString();
            lbTongDanhMuc.Text = ThongKeBul.CountProductCats().ToString();
            lbTongDoanhThu.Text = Helper.CurrencyFormat(ThongKeBul.CountTotalRevenue().ToString());
            lbTongNhanVien.Text = ThongKeBul.CountUsers().ToString();
            lbTongSanPham.Text = ThongKeBul.CountProducts().ToString();
        }

        private void InitChart(int year) {

            chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = false;
            chartDoanhThu.ChartAreas[0].AxisY.LabelStyle.IsEndLabelVisible = false;

            List<double> revenue = ThongKeBul.GetRevenueOfMonthForTheYear(year);

            DateTime currentDate = DateTime.Now;

            chartDoanhThu.Titles["titleDoanhThu"].Text = "Doanh Thu Trong Năm " + year;
            
             chartDoanhThu.Series["DoanhThu"].Points.Clear();

            //add serrie points
            if(currentDate.Year == year) {
                for(int i = 0; i< currentDate.Date.Month; i++ ) {
                    chartDoanhThu.Series["DoanhThu"].Points.AddXY("Th"+(i+1), revenue[i]);
                    if(revenue[i]!=0)
                        chartDoanhThu.Series["DoanhThu"].Points[i].Label = revenue[i].ToString();
                }

                for(int i = currentDate.Date.Month+1; i <= 12; i++)
                    chartDoanhThu.Series["DoanhThu"].Points.AddXY("Th"+ i, 0);
            } else {
                for(int i = 0; i< 12; i++ ) {
                    chartDoanhThu.Series["DoanhThu"].Points.AddXY("Th"+(i+1), revenue[i]);

                    if(revenue[i]!=0)
                        chartDoanhThu.Series["DoanhThu"].Points[i].Label = revenue[i].ToString();
                }
            }

        }

        private void InitNumberYearsOfActive() {
            cbbDoanhThuTheoNam.DisplayMember = "Text";
            cbbDoanhThuTheoNam.ValueMember = "Value";

            Dictionary<string, int> minMaxYearsOfActive = ThongKeBul.GetNumberOfYearActive();

            for(int i = minMaxYearsOfActive["max"]; i >= minMaxYearsOfActive["min"]; i-- ) {
                cbbDoanhThuTheoNam.Items.Add(new {Text = i, Value = i});
            }

            cbbDoanhThuTheoNam.SelectedIndex = 0;

        }

        private void ThongKeForm_Load(object sender, EventArgs e)
        {
            InitStatistical();
            InitNumberYearsOfActive();
        }

        private void cbbDoanhThuTheoNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = Convert.ToInt32((cbbDoanhThuTheoNam.SelectedItem as dynamic).Value);
            InitChart(year);
        }
    }
}
