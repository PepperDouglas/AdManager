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

//Todo, char counter for each input field
//Is it possible to get data type and length for database

namespace AdManager.Repositories {
    public class AdvertisementRepo {
        public static List<Advertisement> GetAdverts(int categoryId, string title) {
            string sql = "select * from Adverts";
            if (categoryId != -1) { 
                sql +=  $" where CategoryID = '{categoryId}'";          
            }
            if (title != "") {
                sql += $" and Title like ('%{title}%')";
            }
            DataTable data = DataHandler.ExecuteReturnTable(sql, new List<SqlParameter>());

            //Här måste vi göra en mappning eftersom vi får en DT men vill returnera en lista
            //med instruktörer
            List<Advertisement> list = new List<Advertisement>();
            foreach (DataRow row in data.Rows) {
                list.Add(new Advertisement((int)row.ItemArray[0], row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), (int)row.ItemArray[3], (DateTime)row.ItemArray[4], (int)row.ItemArray[5], (int)row.ItemArray[6]));
            }
            return list;
        }
        public static void RemoveAdvert(int advertid) {
            //Kan bytas från void med try catch eller nåt
            string sql = $"delete from adverts where AdvertID = '{advertid}'";
            DataHandler.ExecuteNonQuery(sql, new List<SqlParameter>());
        }
        public static bool Save(Advertisement advert) {
            string sql = $"insert into adverts(Title, Description, Price, PostDate, CategoryID, UserID)" +
                $"values('{advert.Title}', '{advert.Description}', '{advert.Price}', '{advert.PostDate}', {advert.CategoryID}, {advert.UserID})";
            try {
                DataHandler.ExecuteNonQuery(sql, new List<SqlParameter>());
                return true;
            } catch {
                MessageBox.Show("Please enter values within set length");
                return false;
            }
        }
        public static void Update(Advertisement ad) {
            string sql = $"update adverts set Title = '{ad.Title}', Description = " +
                $"'{ad.Description}', Price = {ad.Price}, PostDate = '{ad.PostDate}', " +
                $"CategoryID = {ad.CategoryID}, UserID = {ad.UserID} where" +
                $" AdvertID = {ad.AdvertID}";
            try {
                DataHandler.ExecuteNonQuery(sql, new List<SqlParameter>());
            } catch {
                MessageBox.Show("Please enter values within set length");
            }
        }
    }
}
