using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 
 *@ Author: Trieu Tai Niem 
 *@ Nhom: 6
 *@ Create on: 9/11/2018
 *
 */

namespace QuanLyBanHangDTOs
{
    public class SanPham {

        private int _Price;
        public string Id {get; set; }
        public string Name {get; set;}
        public int Cat_id {get; set; }
        public string Unit {get; set;}
        public int Status {set; get; }
        public int Count {get; set; }
        public string Created_at {get; set; }
        public int Promo_price {get; set; }

        public int Price {
            get {
                return Promo_price>0?Promo_price: _Price;
            }
            set {
              _Price = value;
            }
        }


        public SanPham() {}

        public SanPham(string id, string name, int cat_id, int price, string unit, int status = 1, int count = 1, int promo_price = 0, string created_at = "") {
            Id = id;
            Name = name;
            Cat_id = cat_id;
            Price = price;
            Unit = unit;
            Status = status;
            Count = count;
            Created_at = created_at;
            Promo_price = promo_price;
        }
    }
}
