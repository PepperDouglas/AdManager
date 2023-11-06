using AdManager.Entities;
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
    public partial class AdvertAddForm : Form
    {
        public int UserID { get; set; }

        public AdvertAddForm(int userID) {
            UserID = userID;
            InitializeComponent();
            cBCategories.DisplayMember = "CategoryName";
            cBCategories.ValueMember = "CategoryID";
            cBCategories.DataSource = CategoryRepo.GetCategories();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Advertisement advert = new Advertisement(tBTitle.Text, tBDescription.Text, tBPrice.Text, cBCategories.SelectedIndex + 1, UserID);
            AdvertisementRepo.Save(advert);
            this.Close();
        }
    }
}
