using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHangDALs;

namespace QuanLyBanHangBULs
{
    public class ThongKeBUL
    {
        ThongKeDAL ThongKeDal = new ThongKeDAL();

        public int CountTotalRevenue() {
            return ThongKeDal.CountTotalRevenue();
        }

        public int CountUsers() {
            return ThongKeDal.CountTableRow("users");
        }

        public int CountProductCats() {
            return ThongKeDal.CountTableRow("product_cats");
        }

        public int CountOrders() {
            return ThongKeDal.CountTableRow("orders");
        }

        public int CountProducts() {
            return ThongKeDal.CountTableRow("products");
        }

        public List<double> GetRevenueOfMonthForTheYear(int year) {
            List<double> revenueOfMonth = new List<double>();
            for(int i = 1; i <= 12; i++)  {
                revenueOfMonth.Add(ThongKeDal.GetRevenueOfMonthForCurrentYear(year, i));
            }

            return revenueOfMonth;
        }

        public Dictionary<string,int> GetNumberOfYearActive() {
            return ThongKeDal.GetNumberOfYearActive();
        }
    }
}
