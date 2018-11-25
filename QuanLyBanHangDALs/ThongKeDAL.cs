using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyBanHangLibraries;

namespace QuanLyBanHangDALs
{
    public class ThongKeDAL
    {
        public int CountTableRow(string table) {
            int totalRows = 0;
            SqlCommand countRowsCmd = new SqlCommand("SELECT COUNT(*) FROM "+table, Helper.SqlCnn);

            Helper.SqlCnn.Open();
            try {
                totalRows = int.Parse(countRowsCmd.ExecuteScalar().ToString());
            } catch (SqlException e) {
                Console.WriteLine(e.ToString());
            }

            Helper.SqlCnn.Close();
            return totalRows;
        }

        public int CountTotalRevenue() {
            int totalRevenue = 0;
            Helper.SqlCnn.Open();

            SqlCommand countRevenueCmd = new SqlCommand("SELECT SUM(total) FROM orders", Helper.SqlCnn);

            try {
                totalRevenue = int.Parse(countRevenueCmd.ExecuteScalar().ToString());
            } catch (SqlException e) {
                Console.WriteLine(e.ToString());
            }

            Helper.SqlCnn.Close();
            return totalRevenue;
        }

        public double GetRevenueOfMonthForCurrentYear(int year, int month) {
            double revenue = 0;
            Helper.SqlCnn.Open();
            
            int daysOfMonth = DateTime.DaysInMonth(year, month);

            string startDate = year + "-" + month + "-1 00:00:00";
            string endDate = year + "-" + month+ "-" + daysOfMonth + " 23:59:59";

            SqlCommand countRevenueCmd = new SqlCommand("SELECT SUM(total) FROM orders WHERE created_at >= '"+startDate + "' AND created_at < '" + endDate +"'" , Helper.SqlCnn);

            try {
                string resuilt = countRevenueCmd.ExecuteScalar().ToString();

                if(resuilt != "") 
                    revenue = double.Parse(resuilt)/1000;

            } catch (SqlException e) {
                Console.WriteLine(e.ToString());
            }

            Helper.SqlCnn.Close();
            return revenue;
        }


        public Dictionary<string,int> GetNumberOfYearActive() {
            Dictionary<string,int> minMaxYear = new Dictionary<string,int>();
            Helper.SqlCnn.Open();

            SqlCommand getYears = new SqlCommand("SELECT MIN(created_at) AS min, MAX(created_at) AS max FROM orders", Helper.SqlCnn);
            SqlDataReader dr = getYears.ExecuteReader();

            
            while(dr.Read()) {
                minMaxYear.Add("min", Convert.ToDateTime(dr["min"]).Year);
                minMaxYear.Add("max", Convert.ToDateTime(dr["max"]).Year);
            }

            Helper.SqlCnn.Close();
            return minMaxYear;
        }
    }
}
