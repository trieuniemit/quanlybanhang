using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHangDTOs;
using QuanLyBanHangLibraries;
using System.Data.SqlClient;

/**
 * 
 *@ Author: Trieu Tai Niem 
 *@ Nhom: 6
 *@ Create on: 21/11/2018
 *
 */

namespace QuanLyBanHangDALs
{
    public class DonHangDaBanDAL
    {

        //get an user
        public User GetOrderUser(int userId) {
            User user = null;
            Helper.SqlCnn.Open();

            SqlCommand getUserCmd = new SqlCommand("SELECT * FROM users WHERE id = @userID", Helper.SqlCnn);
            
            getUserCmd.Parameters.AddWithValue("userID", userId);
            SqlDataReader dr = getUserCmd.ExecuteReader();

            if(dr.Read()) {
                user = new User(
                        int.Parse(dr["id"].ToString()),
                        dr["username"].ToString(),
                        dr["fullname"].ToString(),
                        dr["password"].ToString(),
                        dr["phone"].ToString(),
                        dr["email"].ToString(),
                        int.Parse(dr["role"].ToString()),
                        int.Parse(dr["gender"].ToString()),
                        dr["date_of_birth"].ToString(),
                        dr["created_at"].ToString()
                    );
            }

            Helper.SqlCnn.Close();

            return (user == null)?(new User()):user;
        }

        //get all users
        public List<User> GetAllUsers() {
            List<User> listUser = new List<User>();

            Helper.SqlCnn.Open();

            SqlCommand getAllUsers = new SqlCommand("SELECT * FROM users", Helper.SqlCnn);
            SqlDataReader user = getAllUsers.ExecuteReader();

            while(user.Read()) {
                listUser.Add(new User(
                        int.Parse(user["id"].ToString()),
                        user["username"].ToString(),
                        user["fullname"].ToString(),
                        user["password"].ToString(),
                        user["phone"].ToString(),
                        user["email"].ToString(),
                        int.Parse(user["role"].ToString()),
                        int.Parse(user["gender"].ToString()),
                        user["date_of_birth"].ToString(),
                        user["created_at"].ToString()
                    ));
            }

            Helper.SqlCnn.Close();

            return listUser;
        }


        //get all orders
        public List<Order> GetAllOrders(string fromDate, string toDate, int byUserId) {
            List<Order> listOrder = new List<Order>();

            Helper.SqlCnn.Open();
            string sqlGetOrderCmd = "SELECT * FROM orders";

            if(fromDate != null || toDate != null || byUserId > -1) {
                sqlGetOrderCmd += " WHERE ";

                if(byUserId != -1) 
                    sqlGetOrderCmd += "created_by="+byUserId + " AND ";
                if(fromDate != null && toDate != null) 
                    sqlGetOrderCmd += "created_at >= '"+fromDate + " 00:00:00' AND created_at <= '" + toDate + " 23:59:59'";
            }

            SqlCommand getOrdersCmd = new SqlCommand(sqlGetOrderCmd, Helper.SqlCnn);

            try {
                SqlDataReader reader = getOrdersCmd.ExecuteReader();
            
                while(reader.Read()) {
                    Order order = new Order(
                            int.Parse(reader["id"].ToString()),
                            reader["customer"].ToString(),
                            reader["customer_phone"].ToString(),
                            Convert.ToInt32(reader["deposits"]),
                            int.Parse(reader["created_by"].ToString()),
                            Convert.ToDateTime(reader["created_at"]).ToString("HH:mm - dd/MM/yyyy"),
                            int.Parse(reader["total"].ToString())
                        );
                    listOrder.Add(order);
                }
            } catch(SqlException e) {
                Console.WriteLine(e.ToString());
            }

            Helper.SqlCnn.Close();

            return listOrder;
        }


        public List<Order> FilterByID(int filterById) {
            List<Order> listOrder = new List<Order>();

            Helper.SqlCnn.Open();
            string sqlGetOrderCmd = "SELECT * FROM orders WHERE id LIKE @filterID";

            SqlCommand getOrdersCmd = new SqlCommand(sqlGetOrderCmd, Helper.SqlCnn);
            getOrdersCmd.Parameters.AddWithValue("filterID", "%"+filterById+"%");

            try {
                SqlDataReader reader = getOrdersCmd.ExecuteReader();
            
                while(reader.Read()) {
                    Order order = new Order(
                            int.Parse(reader["id"].ToString()),
                            reader["customer"].ToString(),
                            reader["customer_phone"].ToString(),
                            Convert.ToInt32(reader["deposits"]),
                            int.Parse(reader["created_by"].ToString()),
                            Convert.ToDateTime(reader["created_at"]).ToString("HH:mm - dd/MM/yyyy"),
                            int.Parse(reader["total"].ToString())
                        );
                    listOrder.Add(order);
                }
            } catch(SqlException e) {
                Console.WriteLine(e.ToString());
            }

            Helper.SqlCnn.Close();

            return listOrder;
        }

        //get products in an order
        public List<SanPham> GetProductsInOrder(int orderId) {

            List<SanPham> listProduct = new List<SanPham>();
            Helper.SqlCnn.Open();

            string sqlCmd = "SELECT * FROM order_items WHERE order_id = @orderID";

            SqlCommand getOrdersCmd = new SqlCommand(sqlCmd, Helper.SqlCnn);
            getOrdersCmd.Parameters.AddWithValue("orderId", orderId);
            SqlDataReader orderItem = getOrdersCmd.ExecuteReader();

            List<string[]> listItem = new List<string[]>();

            while(orderItem.Read()) {
                string[] item = {orderItem["product_id"].ToString(), orderItem["quantity"].ToString()};
                listItem.Add(item);
            }

            orderItem.Close();

            foreach(string[] item in listItem) {
                SqlCommand getProduct = new SqlCommand("SELECT * FROM products WHERE id = "+item[0].ToString(), Helper.SqlCnn);
                SqlDataReader pro = getProduct.ExecuteReader();
                pro.Read();
                listProduct.Add(new SanPham(
                        pro["id"].ToString(),
                        pro["name"].ToString(),
                        int.Parse(pro["cat_id"].ToString()),
                        int.Parse(pro["price"].ToString()),
                        pro["unit"].ToString(),
                        int.Parse(pro["status"].ToString()),
                        int.Parse(item[1]),
                        int.Parse(pro["promo_price"].ToString()),
                        pro["created_at"].ToString()
                    ));

                pro.Close();
            }

            Helper.SqlCnn.Close();

            return listProduct;
        }
    }
}
