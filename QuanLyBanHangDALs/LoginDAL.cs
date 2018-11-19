using System;
using System.Data.SqlClient;
using QuanLyBanHangLibraries;

namespace QuanLyBanHangDALs
{
    public class LoginDAL {

        public bool CheckLogin(string username, string password) {
            SqlCommand checkLoginCmd = new SqlCommand("SELECT COUNT(*) FROM users WHERE username = @user AND password = @pwd", Helper.SqlCnn);
            checkLoginCmd.Parameters.AddWithValue("user", username);
            checkLoginCmd.Parameters.AddWithValue("pwd", Helper.MD5Hash(password));

            Helper.SqlCnn.Open();
            int check = int.Parse(checkLoginCmd.ExecuteScalar().ToString());
            Helper.SqlCnn.Close();

            return check > 0 ? true:false;
        }

    }
}
