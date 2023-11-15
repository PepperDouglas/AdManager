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
            tBPrice.Text = advert.Price.ToString();
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
            if (listBoxAds.SelectedItem == null) {
                return;
            }
            if (LoginForm.AdminID != 0) {
                //MessageBox.Show("Du är inloggad");
                Advertisement selectedAdvert = (Advertisement)listBoxAds.SelectedItem;
                if (selectedAdvert.UserID == LoginForm.AdminID) {
                    AdvertisementRepo.RemoveAdvert(selectedAdvert.AdvertID);
                    //Uppdatera searchen
                    btnSearch_Click(null, null);
                } else {
                    MessageBox.Show("You can only remove your own ads");
                }
            } else {
                MessageBox.Show("Please log in to remove ads");
            }

        }

        private void btnInsertAd_Click(object sender, EventArgs e) {
            
            if (LoginForm.AdminID != 0) {
                AdvertAddForm addForm = new AdvertAddForm(LoginForm.AdminID);
                addForm.ShowDialog();
            } else {
                MessageBox.Show("Please log in");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            if (LoginForm.AdminID == 0) {
                AddUserForm registerForm = new AddUserForm();
                registerForm.ShowDialog();
            } else {
                MessageBox.Show("Please log out to register a new account");

            }
        }

        private void btnSignOut_Click(object sender, EventArgs e) {
            if (LoginForm.AdminID != 0) {
                LoginForm.IsAdmin = false;
                LoginForm.AdminID = 0;
                MessageBox.Show("You have signed out");

            } else {
                MessageBox.Show("Please log in to log out");

            }
        }

        private void buttonFilter_Click(object sender, EventArgs e) {
            string sortType = comboBox1.Text; //Can be Price or Date
            string sortOrder = comboBox2.Text; //Can be Ascending or Descending
            //Test---
            
            List<Advertisement> adList = (List<Advertisement>)listBoxAds.DataSource;

            if (sortType == "Price" && sortOrder == "Ascending") {
                listBoxAds.DataSource = adList.OrderBy(p => p.Price).ToList();
            } else if (sortType == "Price") {
                listBoxAds.DataSource = adList.OrderByDescending(p => p.Price).ToList();
            } else if (sortType == "Date" && sortOrder == "Ascending") {
                listBoxAds.DataSource = adList.OrderBy(p => p.PostDate).ToList();
            } else {
                listBoxAds.DataSource = adList.OrderByDescending(p => p.PostDate).ToList();
            }

            listBoxAds.Refresh();
            //listBoxAds.DataSource = adList;
            //listBoxAds.DisplayMember = "Title";
            //listBoxAds.ValueMember = "AdvertID";
        }

        private void btnUpdateAd_Click(object sender, EventArgs e) {
            if (listBoxAds.SelectedItem == null) {
                return;
            }
            if (LoginForm.AdminID != 0) {
                //MessageBox.Show("Du är inloggad");
                Advertisement selectedAdvert = (Advertisement)listBoxAds.SelectedItem;
                if (selectedAdvert.UserID == LoginForm.AdminID) {
                    if (!int.TryParse(tBPrice.Text, out _)) {
                        MessageBox.Show("Enter a valid price");
                        return;
                    }
                    //AdvertisementRepo.RemoveAdvert(selectedAdvert.AdvertID);
                    Advertisement updatedAd = new Advertisement(selectedAdvert.AdvertID, tBTitle.Text, tBDescription.Text
                        , int.Parse(tBPrice.Text), DateTime.Now, cBCategories.SelectedIndex + 1, selectedAdvert.UserID);
                    //Uppdatera searchen
                    updatedAd.Update();
                    //btnSearch_Click(null, null);
                } else {
                    MessageBox.Show("You can only update your own ads");
                }
            } else {
                MessageBox.Show("Please log in to edit ads");
            }
        }
    }
}
