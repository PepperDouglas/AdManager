using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdManager.Entities {
    public class User {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string userName, string password) {
            UserName = userName;
            Password = password;
        }
        public User(int userId, string userName, string password) {
            UserID = userId;
            UserName = userName;
            Password = password;
        }
        public void Save() {
            //UserRepo.Save(this);
        }
    }
}
