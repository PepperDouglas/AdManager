using AdManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdManager.Entities {
    public class Advertisement {
        public int AdvertID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public DateTime PostDate { get; set; }
        public int CategoryID { get; set; }
        public int UserID { get; set; }

        public Advertisement(int advertId, string title, string description, string price, DateTime dateTime, int categoryID, int userID) {
            AdvertID = advertId;
            Title = title;
            Description = description;
            Price = price;
            PostDate = dateTime;
            CategoryID = categoryID;
            UserID = userID;
        }
        public Advertisement(string title, string description, string price, DateTime dateTime, int categoryID, int userID) {
            Title = title;
            Description = description;
            Price = price;
            PostDate = dateTime;
            CategoryID = categoryID;
            UserID = userID;
        }
        public void Save() {
            AdvertisementRepo.Save(this);
        }
    }

}
