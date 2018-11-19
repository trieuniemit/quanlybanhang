using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangDTOs
{
    public class Order
    {
        public int Id {set; get; }
        public string Customer {set; get; }
        public string Customer_phone {set; get; }
        public int Deposits {set; get; }
        public int Created_by {set; get; }
        public string Created_at {set; get; }

        public Order() {}

        public Order(int id, string customer, string customer_phone, int deposits, int created_by, string created_at = null) {
            Id = id;
            Customer = customer;
            Customer_phone = customer_phone;
            Deposits = deposits;
            Created_by = created_by;
            string currentTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            Created_at = (created_at == null)?currentTime:created_at;
        }

    }
}
