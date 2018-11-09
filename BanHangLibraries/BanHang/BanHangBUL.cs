using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanHangLibraries.Classes;
using System.Windows.Forms;

/**
 * 
 *@ Author: Trieu Tai Niem 
 *@ Nhom: 6
 *@ Create on: 8/11/2018
 *
 */

namespace BanHangLibraries.BanHang
{
    public class BanHangBUL
    {
        private BanHangDAL banHangDal = new BanHangDAL();


        public SanPham CheckProduct(string product_id) {
            SanPham sp = banHangDal.CheckProduct(product_id);
            if(sp == null)
                MessageBox.Show("Mã sản phẩm không chính xác!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return sp;
        }

        public int TotalPrice(List<SanPham> list) {
            int total = 0;
            foreach(SanPham sp in list) {
                total += sp.Count*sp.Price;
            }

            return total;
        }

    }
}
