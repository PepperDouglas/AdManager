﻿using System;
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
        public int CategoryID { get; set; }

        public Advertisement(int advertId, string title, string description, string price, int categoryID) {
            AdvertID = advertId;
            Title = title;
            Description = description;
            Price = price;
            CategoryID = categoryID;
        }
        public void Save() {
            //AdvertisementRepo.Save(this);
        }
    }

}