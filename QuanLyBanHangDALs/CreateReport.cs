using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHangDTOs;

namespace QuanLyBanHangDALs
{
    public class CreateReport
    {

        private List<SanPham> List;
        private Order Order;
        public CreateReport(List<SanPham> products, Order order) {
            List = products;
            Order = order;
        }

        public void Show() {
           
        }
    }
}
