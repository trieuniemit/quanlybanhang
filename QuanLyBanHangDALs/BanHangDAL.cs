using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyBanHangDTOs;
using QuanLyBanHangLibraries;

/**
 * 
 *@ Author: Trieu Tai Niem 
 *@ Nhom: 6
 *@ Create on: 8/11/2018
 *
 */

namespace QuanLyBanHangDALs
{
    public class BanHangDAL
    {

        public SanPham CheckProduct(string product_id) {
            Helper.SqlCnn.Open();
            SqlCommand getProductCmd = new SqlCommand("SELECT * FROM products WHERE ID = @ProductID", Helper.SqlCnn);
            getProductCmd.Parameters.AddWithValue("ProductID", product_id);

            SqlDataReader reader = getProductCmd.ExecuteReader();
            
            SanPham product = null;

            if(reader.Read()) {
                product = new SanPham(
                    reader["id"].ToString(),
                    reader["name"].ToString(),
                    Convert.ToInt32(reader["cat_id"]),
                    Convert.ToInt32(reader["price"]),
                    reader["unit"].ToString(),
                    1,
                    1
                );
            }

            Helper.SqlCnn.Close();

            return product;
        } 


        public void SaveOrderToDatbase(List<SanPham> products, Order order) {
            Helper.SqlCnn.Open();

            //insert to order table
            string insertString = "INSERT INTO orders(customer, customer_phone, deposits, created_by, created_at)  OUTPUT Inserted.id VALUES(@Customer, @Customer_phone, @Deposits, @Created_by, CONVERT(datetime, @Created_at, 103))";
            SqlCommand insertOrder = new SqlCommand(insertString, Helper.SqlCnn);
            insertOrder.Parameters.AddWithValue("Customer", order.Customer);
            insertOrder.Parameters.AddWithValue("Customer_phone", order.Customer_phone);
            insertOrder.Parameters.AddWithValue("Deposits", order.Deposits);
            insertOrder.Parameters.AddWithValue("Created_by", order.Created_by);
            insertOrder.Parameters.AddWithValue("Created_at", order.Created_at);
            string newestOrderId = insertOrder.ExecuteScalar().ToString();

            //insert to order_items table
            foreach(SanPham sp in products) {
                string sqlString = "INSERT INTO order_items VALUES("+newestOrderId+", "+sp.Id+", "+sp.Count+")";
                SqlCommand insertOrderItem = new SqlCommand(sqlString, Helper.SqlCnn);
                insertOrderItem.ExecuteNonQuery();
            }
            Helper.SqlCnn.Close();
        }
    }
}
