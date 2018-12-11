using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHangDTOs;
using QuanLyBanHangLibraries;
using QuanLyBanHangBULs;

namespace QuanLyBanHang.HoSyHuy {

    public partial class BanHangForm_InHoaDon : Form {
        Order Order;
        List<SanPham> Products;
        User CurrentUser;

        public BanHangForm_InHoaDon(Order order, List<SanPham> products, User user) {
            InitializeComponent();
            Order = order;
            Products = products;
            CurrentUser = user;
        }

        private void BanHangForm_HoaDon_Load(object sender, EventArgs e) {
            int totalPrice = (new BanHangBUL()).TotalPrice(Products);

            //set parameter for report
            rpvHoaDonBanHang.LocalReport.SetParameters(new ReportParameter[] {
                new ReportParameter("TenCuaHang", Properties.Settings.Default.StoreName),
                new ReportParameter("DiaChi", Properties.Settings.Default.Address),
                new ReportParameter("SoDienThoai", Properties.Settings.Default.NumberPhone),
                new ReportParameter("SoHoaDon", Order.Id.ToString("D10")),
                new ReportParameter("TenNhanVien", CurrentUser.Fullname),
                new ReportParameter("NgayLap", Helper.GetDateNow("dd/MM/yyyy - HH:mm")),
                new ReportParameter("TongTien", Helper.CurrencyFormat(totalPrice.ToString())),
                new ReportParameter("TienGui", Helper.CurrencyFormat(Order.Deposits.ToString())),
                new ReportParameter("TienTra", Helper.CurrencyFormat((Order.Deposits - totalPrice).ToString())),
                new ReportParameter("TenKhachHang", Order.Customer),
                new ReportParameter("SoDienThoaiKhach", Order.Customer_phone),
            });
            
            //init datatable
            DataTable productDataTable = new DataTable();
            productDataTable.Columns.Add("Count", typeof(int));
            productDataTable.Columns.Add("Name", typeof(string));
            productDataTable.Columns.Add("Quanity", typeof(int));
            productDataTable.Columns.Add("Price", typeof(string));
            productDataTable.Columns.Add("Unit", typeof(string));
            productDataTable.Columns.Add("Total", typeof(string));

            //add datatable rows
            int i = 0;
            foreach(SanPham sp in Products) {
                string subTotal = Helper.CurrencyFormat(sp.Price*sp.Count + "");
                productDataTable.Rows.Add(++i, sp.Name, sp.Count, Helper.CurrencyFormat(sp.Price.ToString()), sp.Unit, subTotal);
            }

            //defind report data source
            ReportDataSource reportDataSource = new ReportDataSource("SanPhamDataSet", productDataTable);
            rpvHoaDonBanHang.LocalReport.DataSources.Clear();
            rpvHoaDonBanHang.LocalReport.DataSources.Add(reportDataSource);

            //load report viewer
            this.rpvHoaDonBanHang.RefreshReport();
        }
    }
}
