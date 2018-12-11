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

namespace QuanLyBanHang.HoSyHuy
{
    public partial class BanHangForm : Form
    {

        private List<SanPham> ListProduct = new List<SanPham>();
        private BanHangBUL BanHangBul = new BanHangBUL();
        private User CurrentUser;

        public BanHangForm(User user) {
            InitializeComponent();
            CurrentUser = user;
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
                nudQuantity.Value = 1;

                sp.Count = int.Parse(nudQuantity.Value.ToString());

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
            } else {
                MessageBox.Show("Mã sản phẩm không chính xác!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbTienGui_LostFocus(object sender, EventArgs e) {
            TextBox Tb = (TextBox)sender;
            int Currency = Helper.ConvertToInt(Tb.Text);
            int Total = Helper.ConvertToInt(tbTotal.Text);

            tbTienGui.Text = Helper.CurrencyFormat(Currency.ToString());
            int _return = Currency - Total;

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
            if(ListProduct.Count == 0)
                MessageBox.Show("Hãy nhập ít nhất một sản phẩm!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(tbTienGui.Text == "") 
                MessageBox.Show("Hãy nhập tiền số tiền KH gửi!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(BanHangBul.TotalPrice(ListProduct) > Helper.ConvertToInt(tbTienGui.Text))
                MessageBox.Show("Số tiền khách hàng trả chưa đủ, hãy thu thêm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else {
                int deposits = Helper.ConvertToInt(tbTienGui.Text);
                Order order =  new Order(-1, tbKhachHang.Text, tbSoDienThoai.Text, deposits, CurrentUser.Id, null, Helper.ConvertToInt(tbTotal.Text));

                //call to BUL method
                bool isSuccess = BanHangBul.SaveOrderAndExportData(ListProduct, order);

                if(!isSuccess) {
                    MessageBox.Show("Có lỗi trong quá trình lưu dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //open report viewer if check
                if(cbExport.Checked)  {
                    HoSyHuy.BanHangForm_InHoaDon InHoaDon = new HoSyHuy.BanHangForm_InHoaDon(order, ListProduct, CurrentUser);
                    InHoaDon.ShowDialog();
                } else {
                    MessageBox.Show("Đã lưu dữ liệu của đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //reset Ban Hang Form
                tbKhachHang.Text = "";
                tbSoDienThoai.Text = "";
                tbTienGui.Text = "0đ";
                tbTienTra.Text = "0đ";
                tbTotal.Text = "0đ";
                order = null;
                ListProduct.Clear();
                dgvListProduct.Rows.Clear();
            }
        }

    }
}