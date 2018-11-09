using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BanHangLibraries.Classes;

/**
 * 
 *@ Author: Trieu Tai Niem 
 *@ Nhom: 6
 *@ Create on: 8/11/2018
 *
 */

namespace BanHangLibraries.BanHang
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
    }
}
