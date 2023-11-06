using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdManager.Repositories;

namespace AdManager
{
    public partial class AdManager : Form
    {
        public bool IsAdmin { get; set; }
        public AdManager() {
            InitializeComponent();
            IsAdmin = false;


            cBCategories.DisplayMember = "CategoryName";
            cBCategories.ValueMember = "CategoryID";
            cBCategories.DataSource = CategoryRepo.GetCategories();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnLogin_Click(object sender, EventArgs e) {

        }

        private void btnSearch_Click(object sender, EventArgs e) {
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
    }
}
