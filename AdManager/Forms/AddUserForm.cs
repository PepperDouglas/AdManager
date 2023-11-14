using AdManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdManager.Forms {
    public partial class AddUserForm : Form {
        public AddUserForm() {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e) {
            User user = new User(tBUserName.Text, tBPassword.Text);
            bool userWasCreated = user.Save();
            if (userWasCreated) {
                this.Close();
            } else {
                MessageBox.Show("User name is taken");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
