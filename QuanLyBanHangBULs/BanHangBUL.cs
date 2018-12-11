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
            return sp;
        }

        public int TotalPrice(List<SanPham> list) {
            int total = 0;
            foreach(SanPham sp in list) {
                total += sp.Count*sp.Price;
            }

            return total;
        }

        public int SaveOrderAndExportData(List<SanPham> products, Order order) {
            //call to save to database method
            return BanHangDal.SaveOrderToDatbase(products, order);
        }

    }
}
