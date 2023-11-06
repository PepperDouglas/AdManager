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
            string sql = $"select count(*) from Users where UserName = '{username}' and Password = '{password}'";
            //We might not need ExecuteReturnTable, but a simpler one!
            return DataHandler.UserExistsQuestion(sql);
        }
        public static int RetrieveUserId(string username, string password) {
            string sql = $"select * from Users where UserName = '{username}' and Password = '{password}'";
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
    }
}
