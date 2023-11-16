using AdManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace AdManager.Repositories {
    public static class UserRepo
    {
        public static bool IsAdminQuestion(string username, string password) {
            string sql = $"select count(*) from Users where UserName = '{username}' COLLATE SQL_Latin1_General_CP1_CS_AS and Password = '{password}' COLLATE SQL_Latin1_General_CP1_CS_AS";
            return DataHandler.UserExistsQuestion(sql);
        }
        public static int RetrieveUserId(string username, string password) {
            string sql = $"select * from Users where UserName = '{username}' COLLATE SQL_Latin1_General_CP1_CS_AS and Password = '{password}' COLLATE SQL_Latin1_General_CP1_CS_AS";
            DataTable data = DataHandler.ExecuteReturnTable(sql, new List<SqlParameter>());
            List<User> userList = new List<User>();
            foreach (DataRow row in data.Rows) {
                userList.Add(new User((int)row.ItemArray[0], row.ItemArray[1].ToString(), row.ItemArray[2].ToString()));
            }
            if (IsAdminQuestion(username, password)) {
                return userList.First().UserID;
            }
            return 0;
        }

        public static bool Save(User user) {
            string sql = $"select UserName from Users";
            DataTable data = DataHandler.ExecuteReturnTable(sql, new List<SqlParameter>());
            List<string> userList = new List<string>(); 
            foreach (DataRow row in data.Rows) {
                userList.Add(row.ItemArray[0].ToString().Trim());
            }
            if (userList.Contains(user.UserName)) {
                return false;
            }
            sql = $"insert into Users(UserName, Password)" +
                $"values('{user.UserName}', '{user.Password}')";
            DataHandler.ExecuteNonQuery(sql, new List<SqlParameter>());
            return true;
        }
    }
}
