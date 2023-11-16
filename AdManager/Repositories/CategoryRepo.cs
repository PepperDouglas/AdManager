using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdManager.Entities;

namespace AdManager.Repositories {
    public class CategoryRepo {
        public static List<Category> GetCategories() {
            string sql = "select CategoryID, CategoryName from Categories";
            DataTable data = DataHandler.ExecuteReturnTable(sql, new List<SqlParameter>());

            List<Category> list = new List<Category>();
            foreach (DataRow row in data.Rows) {
                list.Add(new Category((int)row.ItemArray[0], row.ItemArray[1].ToString()));
            }
            return list;

        }
    }
}
