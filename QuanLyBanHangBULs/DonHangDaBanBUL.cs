using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHangDTOs;
using QuanLyBanHangDALs;
using QuanLyBanHangLibraries;

/**
 * 
 *@ Author: Trieu Tai Niem 
 *@ Nhom: 6
 *@ Create on: 20/11/2018
 *
 */

namespace QuanLyBanHangBULs
{
    public class DonHangDaBanBUL
    {
        DonHangDaBanDAL OrdersDal = new DonHangDaBanDAL();

        public List<object> GetRowList(string fromDate = null, string toDate = null, int byUserId = -1) {
            List<object> returnData = new List<object> ();

            List<string[]> rowList = new List<string[]>();
            List<Order> orderList = OrdersDal.GetAllOrders(fromDate, toDate, byUserId);

            foreach(Order order in orderList) {
                User user = OrdersDal.GetOrderUser(order.Created_by);
                string[] row = {order.Id.ToString(), order.Created_at, order.Customer, order.Customer_phone, Helper.CurrencyFormat(order.Total.ToString()), Helper.CurrencyFormat(order.Deposits.ToString()), user.Fullname};
                rowList.Add(row);
            }

            returnData.Add(rowList);
            returnData.Add(orderList);

            return returnData;

        }
        

        public List<object> GetByID(int filterByID) {
            List<object> returnData = new List<object> ();

            List<string[]> rowList = new List<string[]>();
            List<Order> orderList = OrdersDal.FilterByID(filterByID);

            foreach(Order order in orderList) {
                User user = OrdersDal.GetOrderUser(order.Created_by);
                string[] row = {order.Id.ToString(), order.Created_at, order.Customer, order.Customer_phone, Helper.CurrencyFormat(order.Total.ToString()), Helper.CurrencyFormat(order.Deposits.ToString()), user.Fullname};
                rowList.Add(row);
            }

            returnData.Add(rowList);
            returnData.Add(orderList);

            return returnData;

        }
        public List<SanPham> GetProductsInOrder(int orderId) {
            return OrdersDal.GetProductsInOrder(orderId);
        }

        public User GetOrderUser(int userId) {
            return OrdersDal.GetOrderUser(userId);
        }

        public List<User> GetAllUsers() {
            return OrdersDal.GetAllUsers();
        }
    }
}
