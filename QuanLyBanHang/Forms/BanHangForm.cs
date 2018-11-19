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
using System.Text.RegularExpressions;
using QuanLyBanHangDTOs;
using QuanLyBanHangBULs;
using QuanLyBanHangLibraries;

/**
 * 
 *@ Author: Trieu Tai Niem 
 *@ Nhom: 6
 *@ Create on: 8/11/2018
 *
 */

namespace QuanLyBanHang.Forms
{
    public partial class BanHangForm : Form
    {

        private List<SanPham> ListProduct = new List<SanPham>();
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


        //hover event
        private void ptbAdd_MouseHover(object sender, EventArgs e) {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(this.ptbAdd, "Thêm sản phẩm vào đơn hàng");
        }

        private void ptbRemove_MouseHover(object sender, EventArgs e){
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(this.ptbRemove, "Xóa các sản phẩm đã chọn");
        }

        //<!--- end hover envent -->

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
            int total = BanHangBul.TotalPrice(ListProduct);
            tbTotal.Text = Helper.CurrencyFormat(total.ToString());
        }

        private void ptbAdd_Click(object sender, EventArgs e) {
            SanPham sp = BanHangBul.CheckProduct(tbMaSanPham.Text);

            if(sp != null) {
                tbMaSanPham.Text = "";
                //check if product is exitst in list
                int productFinded = ListProduct.FindIndex(product => product.Id == sp.Id);
           
                if(productFinded > -1) {
                    //change quantity if found
                    ListProduct[productFinded].Count++;
                    dgvListProduct.Rows[productFinded].Cells[4].Value = ListProduct[productFinded].Count;
                    int currency = ListProduct[productFinded].Count*ListProduct[productFinded].Price;
                    dgvListProduct.Rows[productFinded].Cells[6].Value = Helper.CurrencyFormat(currency.ToString());
                } else  {
                    //add to list if not found
                    ListProduct.Add(sp);
                    dgvListProduct.Rows.Add(ListProduct.Count, sp.Id, sp.Name, Helper.CurrencyFormat(sp.Price.ToString()), sp.Count, sp.Unit, Helper.CurrencyFormat((sp.Count*sp.Price).ToString()));
                }

                CalculateTotal();

                //clear text box
                tbMaSanPham.Text = "";
            }
        }

        private void tbTienGui_LostFocus(object sender, EventArgs e) {
            TextBox Tb = (TextBox)sender;
            string Currency = Regex.Replace(Tb.Text, "[^0-9]", "");
            Currency = (Currency=="" || Currency == null)?"0" : Currency;

            string Total = Regex.Replace(tbTotal.Text, "[^0-9]", "");

            tbTienGui.Text = Helper.CurrencyFormat(Currency);
            int _return = int.Parse(Currency) - int.Parse(Total);

            if(_return >= 0) {
                tbTienTra.Text = Helper.CurrencyFormat(_return.ToString());
            } else {
                tbTienTra.Text = "Chưa đủ tiền!";
            }
        }

        private void ptbRemove_Click(object sender, EventArgs e) {
            int totalSelected = dgvListProduct.SelectedRows.Count;
            for(int i = totalSelected-1; i >= 0; i--) {
                int index = dgvListProduct.SelectedRows[i].Index;

                ListProduct.RemoveAt(index);
                dgvListProduct.Rows.RemoveAt(index);
            }

            CalculateTotal();
            
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if(ListProduct.Count == 0) {
                MessageBox.Show("Hãy chọn ít nhất một sản phẩm!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                int deposits = int.Parse(Regex.Replace(tbTienGui.Text, "[^0-9]", ""));
                Order order =  new Order(-1, tbKhachHang.Text, tbSoDienThoai.Text, deposits, Helper.CurrentUserId);

                //call to BUL method
                BanHangBul.SaveOrderAndExportData(ListProduct, order, cbExport.Checked);

                tbKhachHang.Text = "";
                tbSoDienThoai.Text = "";
                tbTienGui.Text = "0đ";
                tbTienTra.Text = "0đ";
                tbTotal.Text = "0đ";
            }
        }


    }
}