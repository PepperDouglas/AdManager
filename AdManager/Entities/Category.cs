using AdManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdManager.Entities {
    public class Category {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public Category(int categoryId, string categoryName) {
            CategoryID = categoryId;
            CategoryName = categoryName;
        }

        public void Save() {
            //CategoryRepo.Save(this);
        }
    }
}
