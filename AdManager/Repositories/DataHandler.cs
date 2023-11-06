using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdManager.Repositories {
    public static class DataHandler {
        private static string _connString = "Data Source=DESKTOP-HUERL9P;Initial Catalog=AdManager;Integrated Security=SSPI;";
        public static void ExecuteNonQuery(string sql, List<SqlParameter> parameters) {
            using (SqlConnection conn = new SqlConnection(_connString)) {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                //Loopas igenom alla parametrar som skickas in och lägger till dessa
                foreach (SqlParameter param in parameters) {
                    cmd.Parameters.Add(param);
                }
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable ExecuteReturnTable(string sql, List<SqlParameter> parameters) {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connString)) {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                foreach (SqlParameter param in parameters) {
                    cmd.Parameters.Add(param);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
        }
        public static DataTable GetUser(string sql) {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connString)) {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
        }
        public static bool UserExistsQuestion(string sql) {
            using (SqlConnection conn = new SqlConnection(_connString)) {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0 ? true : false;
            }
        }
    }
}
