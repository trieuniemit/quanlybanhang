using System;
using QuanLyBanHangDALs;
using QuanLyBanHangDTOs;

namespace QuanLyBanHangBULs
{
    public class LoginBUL {

        LoginDAL loginDal = new LoginDAL();

        public User CheckLogin(string username = "", string password = "") {
            return loginDal.CheckLogin(username, password);
        }

    }
}
