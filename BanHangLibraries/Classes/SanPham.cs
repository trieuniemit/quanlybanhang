using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangLibraries.Classes
{
    public class SanPham
    {
          public string Id {get; set; }
          public string Name {get; set;}
          public int Cat_id {get; set; }
          public int Price {get; set; }
          public string Unit {get; set;}
          public int Status {set; get; }
          public int Count {get; set; }
          public string Created_at {get; set; }
          public int Promo_price {get; set; }

          public SanPham() {}

        public SanPham(string id, string name, int cat_id, int price, string unit, int status = 1, int count = 1, string created_at = "", int promo_price = 0) {
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
