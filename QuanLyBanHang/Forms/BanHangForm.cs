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
using BanHangLibraries.Classes;
using BanHangLibraries.BanHang;
using BanHangLibraries;
using System.Text.RegularExpressions;

namespace QuanLyBanHang.Forms
{
    public partial class BanHangForm : Form
    {

        private List<SanPham> listProduct = new List<SanPham>();
        private BanHangBUL BanHangBul = new BanHangBUL();
        

        public BanHangForm() {
            InitializeComponent();
        }

        private void BanHangForm_Load(object sender, EventArgs e) {
            InitDataGridView();
        }

        private void tbMaSanPham_GotFocus(object sender, EventArgs e) {
            if(string.IsNullOrWhiteSpace(tbMaSanPham.Text) || tbMaSanPham.Text == "Nhập mã sản phẩm...")
                tbMaSanPham.Text = "";
        }

        private void tbMaSanPham_LostFocus(object sender, EventArgs e) {
            if(string.IsNullOrWhiteSpace(tbMaSanPham.Text))
                tbMaSanPham.Text = "Nhập mã sản phẩm...";
        }

        private void InitDataGridView() {
            string[] listHeader = {"STT", "Mã sản phẩm", "Tên sản phẩm", "Đơn giá", "Số lượng", "Đơn vị", "Thành tiền"};
            dgvListProduct.ColumnCount = 7;
            dgvListProduct.Columns[0].Width = 50;

            //insert header text
            for(int i = 0; i < listHeader.Length; i++) {
                dgvListProduct.Columns[i].HeaderText = listHeader[i];
            }
        }

        private void CalculateTotal() {
            int total = BanHangBul.TotalPrice(listProduct);
            tbTotal.Text = Helper.CurrencyFormat(total.ToString());
        }

        private void ptbAdd_Click(object sender, EventArgs e) {
            SanPham sp = BanHangBul.CheckProduct(tbMaSanPham.Text);

            if(sp != null) {
                tbMaSanPham.Text = "";
                //check if product is exitst in list
                int productFinded = listProduct.FindIndex(product => product.Id == sp.Id);
           
                if(productFinded > -1) {
                    //change quantity if found
                    listProduct[productFinded].Count++;
                    dgvListProduct.Rows[productFinded].Cells[4].Value = listProduct[productFinded].Count;
                    int currency = listProduct[productFinded].Count*listProduct[productFinded].Price;
                    dgvListProduct.Rows[productFinded].Cells[6].Value = Helper.CurrencyFormat(currency.ToString());
                } else  {
                    //add to list if not found
                    listProduct.Add(sp);
                    dgvListProduct.Rows.Add(listProduct.Count, sp.Id, sp.Name, Helper.CurrencyFormat(sp.Price.ToString()), sp.Count, sp.Unit, Helper.CurrencyFormat((sp.Count*sp.Price).ToString()));
                }

                CalculateTotal();
            }
        }

        private void tbTienGui_LostFocus(object sender, EventArgs e) {
            TextBox Tb = (TextBox)sender;
            string Currency = Regex.Replace(Tb.Text, "[^0-9]", "");
            tbTienGui.Text = Helper.CurrencyFormat(Currency.ToString());
            int _return = int.Parse(Currency) - int.Parse(tbTotal.Text);
            if(_return >= 0) {
                tbTienTra.Text = Helper.CurrencyFormat(_return.ToString());
            } else {
                tbTienTra.Text = "Chưa đủ tiền!";
            }
        }

    }
}