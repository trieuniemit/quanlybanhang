using System;
using QuanLyBanHangDALs;

namespace QuanLyBanHangBULs
{
    public class LoginBUL {

        LoginDAL loginDal = new LoginDAL();

        public bool CheckLogin(string username = "", string password = "") {
            return loginDal.CheckLogin(username, password);
        }

    }
}
