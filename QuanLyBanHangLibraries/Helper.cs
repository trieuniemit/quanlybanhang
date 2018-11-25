using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Globalization;

/**
 * 
 *@ Author: Trieu Tai Niem 
 *@ Nhom: 6
 *@ Create on: 31/10/2018
 *
 */

namespace QuanLyBanHangLibraries
{
    public class Helper
    {
        public static SqlConnection SqlCnn = new SqlConnection(ConfigurationManager.AppSettings["sqlConnectString"]);

        public static void Gradient(System.Drawing.Graphics graphics, int width, int height, System.Drawing.Color formColor, System.Drawing.Color toColor, float deg) {
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, width, height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, formColor, toColor, deg);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        public static string MD5Hash(string input) {
           StringBuilder hash = new StringBuilder();
           MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
           byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

           for (int i = 0; i < bytes.Length; i++) {
             hash.Append(bytes[i].ToString("x2"));
           }

           return hash.ToString();
        }

        public static string CurrencyFormat(string currency) {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            string rt = double.Parse(currency).ToString("#,###", cul.NumberFormat);
            return (rt == "" ? "0" : rt) + "đ";
        }

        public static string GetDateNow(string format = "dd.MM.yyyy HH:mm:ss") {
            return DateTime.Now.ToString(format);
        }

        public static int ConvertToInt(string str) {
            string convert = Regex.Replace(str, "[^0-9]", "");
            convert = (convert=="" || convert == null)?"0" : convert;
            return int.Parse(convert);
        }

        public static string GetUserRole(int role) {
            string roleName = "";
            switch(role) {
                case 1: 
                    roleName = "Quản lý";
                    break;
                case 2: 
                    roleName = "Nhân viên";
                    break;
            }

            return roleName;
        }

        public static string GetGenderName(int gender) {
            string genderName = "";
            switch(gender) {
                case 0: 
                    genderName = "Nam";
                    break;
                case 1: 
                    genderName = "Nữ";
                    break;
            }

            return genderName;
        }

    }
}
