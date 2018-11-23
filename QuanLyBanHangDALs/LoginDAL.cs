using System;
using System.Data.SqlClient;
using QuanLyBanHangLibraries;
using QuanLyBanHangDTOs;

namespace QuanLyBanHangDALs
{
    public class LoginDAL {

        public User CheckLogin(string username, string password) {
            SqlCommand getUserCmd = new SqlCommand("SELECT * FROM users WHERE username = @user AND password = @pwd", Helper.SqlCnn);

            getUserCmd.Parameters.AddWithValue("user", username);
            getUserCmd.Parameters.AddWithValue("pwd", Helper.MD5Hash(password));

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
