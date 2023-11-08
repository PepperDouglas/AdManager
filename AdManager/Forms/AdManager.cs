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
        public bool SelectionEnabled { get; set; }
        public AdManager() {
            LoginForm = new LoginForm();
            InitializeComponent();
            IsAdmin = false;
            SelectionEnabled = true;

            cBCategories.DisplayMember = "CategoryName";
            cBCategories.ValueMember = "CategoryID";
            cBCategories.DataSource = CategoryRepo.GetCategories();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void listBoxAd_SelectedIndexChanged(object sender, EventArgs e) {
            if (SelectionEnabled) {
                if (listBoxAds.SelectedIndex >= 0) {
                    Advertisement selectedAdvert = listBoxAds.SelectedItem as Advertisement;
                    if (selectedAdvert != null) {
                        UpdateDetails(selectedAdvert);
                    }

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
            
            listBoxAds.DisplayMember = "Title";
            listBoxAds.ValueMember = "AdvertID";
            int categorySearchTerm;
            string titleSearchTerm;
            if (cBCategories.SelectedValue == null) {
                categorySearchTerm = -1;
            } else {
                categorySearchTerm = (int)cBCategories.SelectedValue;
            }
            if (string.IsNullOrWhiteSpace(tBTitle.Text)) {
                titleSearchTerm = "";
            } else {
                titleSearchTerm = tBTitle.Text;
            }
            //tBTitle.Text = "";
            tBPrice.Text = "";
            tBDescription.Text = "";
            SelectionEnabled = false;
            listBoxAds.DataSource = AdvertisementRepo.GetAdverts(categorySearchTerm, titleSearchTerm);
            SelectionEnabled = true;
        }

        private void btnRemoveAd_Click(object sender, EventArgs e) {
            if (LoginForm.AdminID != 0) {
                MessageBox.Show("Du är inloggad");
                Advertisement selectedAdvert = (Advertisement)listBoxAds.SelectedItem;
                if (selectedAdvert.UserID == LoginForm.AdminID) {
                    AdvertisementRepo.RemoveAdvert(selectedAdvert.AdvertID);
                    //Uppdatera searchen
                    btnSearch_Click(null, null);
                } else {
                    MessageBox.Show("Du kan endast ta bort dina egna annonser");
                }
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
