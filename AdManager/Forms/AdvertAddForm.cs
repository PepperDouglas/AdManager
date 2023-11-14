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
            int price;
            if (!int.TryParse(tBPrice.Text, out _)){
                MessageBox.Show("Please enter a valid price");
                return;
            }
            Advertisement advert = new Advertisement(tBTitle.Text, tBDescription.Text, int.Parse(tBPrice.Text), DateTime.Now, cBCategories.SelectedIndex + 1, UserID);
            bool saveSuccess = AdvertisementRepo.Save(advert);
            if (saveSuccess) {
                this.Close();
            }
        }

        private void UpdateWordCountTitle(object sender, EventArgs e) {
            int chars = tBTitle.Text.Length;
            labelTitleCharCount.Text = $"( {chars} / 30 )";
        }

        private void UpdateWordCountDescription(object sender, EventArgs e) {
            int chars = tBDescription.Text.Length;
            labelCharCounter.Text = $"( {chars} / 200 )";
        }
    }
}
