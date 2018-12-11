using QuanLyBanHangDALs;
using QuanLyBanHangDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangBULs
{
    public class GetUserBUL
    {
        GetUserDAL getUserDAL = new GetUserDAL();

        public User getCurrentUser(int userID) {
            return getUserDAL.GetCurrentUser(userID);
        }
    }
}
