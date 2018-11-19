using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangDTOs
{
    public class User
    {
        public int Id {get; set;}

        public User() {}

        public User(int id) {
            Id = id;
        }
    }
}
