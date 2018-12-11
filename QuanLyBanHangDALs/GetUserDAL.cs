using QuanLyBanHangDTOs;
using QuanLyBanHangLibraries;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangDALs
{
    public class GetUserDAL
    {
        public User GetCurrentUser(int userID) {
            SqlCommand getUserCmd = new SqlCommand("SELECT * FROM users WHERE id="+userID, Helper.SqlCnn);
            Helper.SqlCnn.Open();
            SqlDataReader reader = getUserCmd.ExecuteReader();

            User userInfo = null;

            if(reader.Read()) {
                userInfo = new User(
                        int.Parse(reader["id"].ToString()),
                        reader["username"].ToString(),
                        reader["fullname"].ToString(),
                        reader["password"].ToString(),
                        reader["phone"].ToString(),
                        reader["email"].ToString(),
                        int.Parse(reader["role"].ToString()),
                        int.Parse(reader["gender"].ToString()),
                        reader["date_of_birth"].ToString(),
                        reader["created_at"].ToString()
                    );
            }

            Helper.SqlCnn.Close();

            return userInfo;
        }
    }
}
