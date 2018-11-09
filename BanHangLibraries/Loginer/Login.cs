using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


/**
 * 
 *@ Author: Trieu Tai Niem 
 *@ Nhom: 6
 *@ Create on: 31/10/2018
 *
 */

namespace BanHangLibraries.Loginer
{
    public class LoginDAL {

        public bool CheckLogin(string username, string password) {
            SqlCommand checkLoginCmd = new SqlCommand("SELECT COUNT(*) FROM users WHERE username = @user AND password = @pwd", Helper.SqlCnn);
            checkLoginCmd.Parameters.AddWithValue("user", username);
            checkLoginCmd.Parameters.AddWithValue("pwd", password);

            Helper.SqlCnn.Open();
            int check = int.Parse(checkLoginCmd.ExecuteScalar().ToString());
            Helper.SqlCnn.Close();

            return check > 0 ? true:false;
        }

    }


    public class LoginBUL {

        LoginDAL loginDal = new LoginDAL();

        public bool CheckLogin(string username = "", string password = "") {

            return loginDal.CheckLogin(username, password);
        }

    }
}
