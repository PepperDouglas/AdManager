using AdManager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdManager.Forms
{
    public partial class LoginForm : Form
    {
        public bool IsAdmin { get; set; }
        public int AdminID { get; set; }
        public LoginForm() {
            InitializeComponent();
            IsAdmin = false;
            AdminID = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            AdminID = UserRepo.RetrieveUserId(username, password);
            if (AdminID == 0) {
                MessageBox.Show("Wrong username or password");
            } else {
                this.Close();
            }
            //IsAdmin = UserRepo.IsAdminQuestion(username, password);
        }
    }
}
