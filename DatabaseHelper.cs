using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace HotelManagementSystem
{
    public static class DatabaseHelper
    {
        private static readonly string _connString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;

        public static DataTable GetGuest(string nationalId)
        {
            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("SELECT * FROM Guest WHERE National_ID = @nid", conn))
            {
                cmd.Parameters.AddWithValue("@nid", nationalId);
                var dt = new DataTable();
                conn.Open();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
        }

        public static int AddGuest(string nid, string firstName, string middleInitial, string lastName,
                                 string email, string address, string phone)
        {
            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand(
                "INSERT INTO Guest (National_ID, first_name, mid_init, last_name, Email, Guest_address, phone_number) " +
                "VALUES (@nid, @fn, @mi, @ln, @email, @addr, @phone)", conn))
            {
                cmd.Parameters.AddWithValue("@nid", nid);
                cmd.Parameters.AddWithValue("@fn", firstName);

                if (string.IsNullOrWhiteSpace(middleInitial))
                {
                    cmd.Parameters.AddWithValue("@mi", middleInitial);
                }
                else
                {
                    string cleanMiddleInitial = middleInitial.Trim().Substring(0, 1).ToUpper();
                    cmd.Parameters.AddWithValue("@mi", cleanMiddleInitial);
                }

                cmd.Parameters.AddWithValue("@ln", lastName);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@addr", address);
                cmd.Parameters.AddWithValue("@phone", phone);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}