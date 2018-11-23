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
        public string Username {get; set;}
        public string Fullname {get; set;}
        public string Password {get; set;}
        public string Phone {get; set;}
        public string Email {get; set;}
        public int Role {get; set;}
        public int Gender {get; set;}
        public string Date_of_birth {get; set;}
        public string Created_at {get; set;}

        public User() {}

        public User(int id, string username, string fullname, string passsword, string phone, string email, int role, int gender, string date_of_birth, string created_at) {
            Id = id;
            Username = username;
            Fullname = fullname;
            Password = passsword;
            Phone = phone;
            Email = email;
            Role = role;
            Gender = gender;
            Date_of_birth = date_of_birth;
            Created_at = created_at;
        }

        public string getGender() {
            return (Gender==0)?"Nam": "Nữ";
        }
    }
}
