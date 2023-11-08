using AdManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Globalization;

namespace AdManager.Repositories {
    public class AdvertisementRepo {
        public static List<Advertisement> GetAdverts(int categoryId) {
            string sql;
            if (categoryId != -1) { 
                sql = $"select * from Adverts where CategoryID = '{categoryId}'";          
            } else {
                sql = "select * from Adverts";
            }
            DataTable data = DataHandler.ExecuteReturnTable(sql, new List<SqlParameter>());

            //Här måste vi göra en mappning eftersom vi får en DT men vill returnera en lista
            //med instruktörer
            List<Advertisement> list = new List<Advertisement>();
            foreach (DataRow row in data.Rows) {
                list.Add(new Advertisement((int)row.ItemArray[0], row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), DateTime.ParseExact(row.ItemArray[4].ToString(), "yyyy-MM-dd hh:mm:ss", CultureInfo.InvariantCulture), (int)row.ItemArray[5], (int)row.ItemArray[6]));
            }
            return list;

        }
        public static void Save(Advertisement advert) {
            string sql = $"insert into adverts(Title, Description, Price, CategoryID, UserID)" +
                $"values('{advert.Title}', '{advert.Description}', '{advert.Price}', {advert.CategoryID}, {advert.UserID})";
            DataHandler.ExecuteNonQuery(sql, new List<SqlParameter>());
        }
    }
}
