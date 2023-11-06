using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdManager.Entities;
using AdManager.Forms;
using AdManager.Repositories;

namespace AdManager
{
    public partial class AdManager : Form
    {
        public bool IsAdmin { get; set; }
        public LoginForm LoginForm { get; set; }
        public AdManager() {
            LoginForm = new LoginForm();
            InitializeComponent();
            IsAdmin = false;


            cBCategories.DisplayMember = "CategoryName";
            cBCategories.ValueMember = "CategoryID";
            cBCategories.DataSource = CategoryRepo.GetCategories();
        }

        private void listBoxAd_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBoxAds.SelectedIndex >= 0) {
                Advertisement selectedAdvert = listBoxAds.SelectedItem as Advertisement;
                if (selectedAdvert != null) {
                    UpdateDetails(selectedAdvert);
                }

            }
        }

        private void UpdateDetails(Advertisement advert) {
            tBTitle.Text = advert.Title;
            tBPrice.Text = advert.Price;
            tBDescription.Text = advert.Description;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            LoginForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            tBTitle.Text = "";
            tBPrice.Text = "";
            tBDescription.Text = "";
            listBoxAds.DisplayMember = "Title";
            listBoxAds.ValueMember = "AdvertID";
            int categorySearchTerm;
            if (cBCategories.SelectedValue == null) {
                categorySearchTerm = -1;
            } else {
                categorySearchTerm = (int)cBCategories.SelectedValue;
            }
            listBoxAds.DataSource = AdvertisementRepo.GetAdverts(categorySearchTerm);
        }

        private void btnRemoveAd_Click(object sender, EventArgs e) {
            if (LoginForm.AdminID != 0) {
                MessageBox.Show("Du är inloggad");
            } else {
                MessageBox.Show("Du är INTE inloggad");
            }

        }

        private void btnInsertAd_Click(object sender, EventArgs e) {
            
            if (LoginForm.AdminID != 0) {
                AdvertAddForm addForm = new AdvertAddForm(LoginForm.AdminID);
                addForm.ShowDialog();
            } else {
                MessageBox.Show("Du är INTE inloggad");
            }
        }
    }
}
