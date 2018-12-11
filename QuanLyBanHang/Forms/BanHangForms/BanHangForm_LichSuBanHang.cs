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
using QuanLyBanHangDTOs;

/**
 * 
 *@ Author: Trieu Tai Niem 
 *@ Nhom: 6
 *@ Create on: 20/11/2018
 *
 */

namespace QuanLyBanHang.Forms
{
    public partial class BanHangForm_LichSuBanHang : Form
    {
        DonHangDaBanBUL donHangDaBanBul = new DonHangDaBanBUL();
        List<Order> OrderList;

        public BanHangForm_LichSuBanHang()
        {
            InitializeComponent();
        }

        private void BanHangForm_LichSuBanHang_Load(object sender, EventArgs e) {
            InitDataGribView();
            InitUserSelectCombobox();
        }

        private void InitUserSelectCombobox() {
            cbbUser.DisplayMember = "Text";
            cbbUser.ValueMember = "Value";

            List<User> allUser = donHangDaBanBul.GetAllUsers();
            foreach(User user in allUser) {
                cbbUser.Items.Add(new { Value = user.Id.ToString(), Text = user.Fullname });
            }

            cbbUser.SelectedIndex = 0;
        }


        private void ShowDataGridViewData(List<object> returnedData) {
            //add rows for datagridview
            List<string[]> rowList = returnedData[0] as List<string[]>;
            this.OrderList = returnedData[1] as List<Order>;

            int countRow = 0;
            foreach(string[] row in rowList) {
                dgvBanHangHistory.Rows.Add(int.Parse(row[0]).ToString("D10"),row[1],row[2],row[3],row[4],row[5],row[6], "Xem chi tiết");
                dgvBanHangHistory.Rows[countRow].Cells[7].Style.ForeColor = Color.ForestGreen;
                countRow++;
            }
        }

        private void InitDataGribView() {
            //init header
            string[] headerText = {"Mã Đơn Hàng","Ngày Giờ", "Khách Hàng", "SĐT Khách Hàng", "Tiền Đơn Hàng", "Tiền KH Trả", "Nhân Viên", "Hóa Đơn"};
            dgvBanHangHistory.ColumnCount = headerText.Length;
             for(int i = 0; i < headerText.Length; i++) {
                dgvBanHangHistory.Columns[i].HeaderText = headerText[i];
            }
            
            //change style of datagridview
            dgvBanHangHistory.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvBanHangHistory.DefaultCellStyle.SelectionForeColor = Color.Black;
            
            //add rows for datagridview
            List<object> returnedData = donHangDaBanBul.GetRowList();

            ShowDataGridViewData(returnedData);

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgvBanHangHistory.Rows.Clear();
            List<object> returnedData = donHangDaBanBul.GetRowList();
            ShowDataGridViewData(returnedData);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvBanHangHistory.Rows.Clear();

            //add rows for datagridview
            string fromDate = dtpFromDate.Value.Date.ToString("yyyy-MM-dd");
            string toDate = dtpToDate.Value.Date.ToString("yyyy-MM-dd");
            int filterByUser = int.Parse((cbbUser.SelectedItem as dynamic).Value);

            List<object> returnedData = donHangDaBanBul.GetRowList(fromDate, toDate, filterByUser);

            ShowDataGridViewData(returnedData);

        }

        private void dgvBanHangHistory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row headers
            var dataGridView = (sender as DataGridView);

            if (e.ColumnIndex != 7 || e.RowIndex < 0) {
                dataGridView.Cursor = Cursors.Default;
                return;
            }

            dataGridView.Cursor = Cursors.Hand;
        }

        private void dgvBanHangHistory_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (sender as DataGridView);
            dataGridView.Cursor = Cursors.Default;
        }

        private void dgvBanHangHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 7 || e.RowIndex < 0) {
                return;
            }

            Order currentOrder = OrderList[e.RowIndex];
            
            User currentOrderUser = donHangDaBanBul.GetOrderUser(currentOrder.Created_by);
            List<SanPham> products = donHangDaBanBul.GetProductsInOrder(currentOrder.Id);

            Forms.BanHangForm_InHoaDon detailForm = new BanHangForm_InHoaDon(currentOrder, products, currentOrderUser);
            detailForm.ShowDialog();
        }

        private void btnTimMa_Click(object sender, EventArgs e)
        {
            dgvBanHangHistory.Rows.Clear();

            int filterByID = int.Parse(tbMaDonHang.Text==""?"0":tbMaDonHang.Text);

            List<object> returnedData = donHangDaBanBul.GetByID(filterByID);

            ShowDataGridViewData(returnedData);
        }

    }
}
