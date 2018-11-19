using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHangDTOs;
using QuanLyBanHangDALs;

/**
 * 
 *@ Author: Trieu Tai Niem 
 *@ Nhom: 6
 *@ Create on: 8/11/2018
 *
 */

namespace QuanLyBanHangBULs {

    public class BanHangBUL {

        private BanHangDAL BanHangDal = new BanHangDAL();


        public SanPham CheckProduct(string product_id) {
            SanPham sp = BanHangDal.CheckProduct(product_id);
                //MessageBox.Show("Mã sản phẩm không chính xác!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return sp;
        }

        public int TotalPrice(List<SanPham> list) {
            int total = 0;
            foreach(SanPham sp in list) {
                total += sp.Count*sp.Price;
            }

            return total;
        }

        public void SaveOrderAndExportData(List<SanPham> products, Order order, bool isExport) {
            //call to save to database method
            BanHangDal.SaveOrderToDatbase(products, order);

            //call to method export
            if(isExport) 
                ExportToPdf(products, order);
        }

        private void ExportToPdf(List<SanPham> products, Order order) {
            CreateReport report = new CreateReport(products, order);
            report.Show();
        }

    }
}
