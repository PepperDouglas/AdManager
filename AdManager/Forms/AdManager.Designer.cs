namespace AdManager
{
    partial class AdManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tBTitle = new System.Windows.Forms.TextBox();
            this.tBPrice = new System.Windows.Forms.TextBox();
            this.listBoxAds = new System.Windows.Forms.ListBox();
            this.cBCategories = new System.Windows.Forms.ComboBox();
            this.tBDescription = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemoveAd = new System.Windows.Forms.Button();
            this.btnInsertAd = new System.Windows.Forms.Button();
            this.btnUpdateAd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSortType = new System.Windows.Forms.ComboBox();
            this.comboBoxSortOrder = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tBTitle
            // 
            this.tBTitle.Location = new System.Drawing.Point(592, 142);
            this.tBTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tBTitle.Name = "tBTitle";
            this.tBTitle.Size = new System.Drawing.Size(298, 26);
            this.tBTitle.TabIndex = 0;
            // 
            // tBPrice
            // 
            this.tBPrice.Location = new System.Drawing.Point(592, 206);
            this.tBPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.Size = new System.Drawing.Size(148, 26);
            this.tBPrice.TabIndex = 1;
            // 
            // listBoxAds
            // 
            this.listBoxAds.FormattingEnabled = true;
            this.listBoxAds.ItemHeight = 20;
            this.listBoxAds.Location = new System.Drawing.Point(64, 72);
            this.listBoxAds.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAds.Name = "listBoxAds";
            this.listBoxAds.Size = new System.Drawing.Size(390, 324);
            this.listBoxAds.TabIndex = 2;
            this.listBoxAds.SelectedIndexChanged += new System.EventHandler(this.listBoxAd_SelectedIndexChanged);
            // 
            // cBCategories
            // 
            this.cBCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCategories.FormattingEnabled = true;
            this.cBCategories.Location = new System.Drawing.Point(592, 72);
            this.cBCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cBCategories.Name = "cBCategories";
            this.cBCategories.Size = new System.Drawing.Size(298, 28);
            this.cBCategories.TabIndex = 3;
            // 
            // tBDescription
            // 
            this.tBDescription.Location = new System.Drawing.Point(592, 266);
            this.tBDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tBDescription.Multiline = true;
            this.tBDescription.Name = "tBDescription";
            this.tBDescription.Size = new System.Drawing.Size(298, 150);
            this.tBDescription.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(780, 202);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 34);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemoveAd
            // 
            this.btnRemoveAd.Location = new System.Drawing.Point(928, 112);
            this.btnRemoveAd.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveAd.Name = "btnRemoveAd";
            this.btnRemoveAd.Size = new System.Drawing.Size(112, 34);
            this.btnRemoveAd.TabIndex = 6;
            this.btnRemoveAd.Text = "Remove Ad";
            this.btnRemoveAd.UseVisualStyleBackColor = true;
            this.btnRemoveAd.Click += new System.EventHandler(this.btnRemoveAd_Click);
            // 
            // btnInsertAd
            // 
            this.btnInsertAd.Location = new System.Drawing.Point(928, 69);
            this.btnInsertAd.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertAd.Name = "btnInsertAd";
            this.btnInsertAd.Size = new System.Drawing.Size(112, 34);
            this.btnInsertAd.TabIndex = 7;
            this.btnInsertAd.Text = "Insert Ad";
            this.btnInsertAd.UseVisualStyleBackColor = true;
            this.btnInsertAd.Click += new System.EventHandler(this.btnInsertAd_Click);
            // 
            // btnUpdateAd
            // 
            this.btnUpdateAd.Location = new System.Drawing.Point(592, 426);
            this.btnUpdateAd.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateAd.Name = "btnUpdateAd";
            this.btnUpdateAd.Size = new System.Drawing.Size(112, 34);
            this.btnUpdateAd.TabIndex = 8;
            this.btnUpdateAd.Text = "Update Ad";
            this.btnUpdateAd.UseVisualStyleBackColor = true;
            this.btnUpdateAd.Click += new System.EventHandler(this.btnUpdateAd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Advertisments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Description";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.Location = new System.Drawing.Point(879, 507);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 52);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(710, 507);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(162, 52);
            this.btnSignOut.TabIndex = 15;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(538, 507);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(162, 52);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(344, 459);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(112, 34);
            this.buttonFilter.TabIndex = 17;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 426);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sort by";
            // 
            // comboBoxSortType
            // 
            this.comboBoxSortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortType.FormattingEnabled = true;
            this.comboBoxSortType.Items.AddRange(new object[] {
            "Price",
            "Date"});
            this.comboBoxSortType.Location = new System.Drawing.Point(134, 418);
            this.comboBoxSortType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSortType.Name = "comboBoxSortType";
            this.comboBoxSortType.Size = new System.Drawing.Size(152, 28);
            this.comboBoxSortType.TabIndex = 19;
            // 
            // comboBoxSortOrder
            // 
            this.comboBoxSortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortOrder.FormattingEnabled = true;
            this.comboBoxSortOrder.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.comboBoxSortOrder.Location = new System.Drawing.Point(297, 418);
            this.comboBoxSortOrder.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSortOrder.Name = "comboBoxSortOrder";
            this.comboBoxSortOrder.Size = new System.Drawing.Size(157, 28);
            this.comboBoxSortOrder.TabIndex = 20;
            // 
            // AdManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1077, 596);
            this.Controls.Add(this.comboBoxSortOrder);
            this.Controls.Add(this.comboBoxSortType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateAd);
            this.Controls.Add(this.btnInsertAd);
            this.Controls.Add(this.btnRemoveAd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tBDescription);
            this.Controls.Add(this.cBCategories);
            this.Controls.Add(this.listBoxAds);
            this.Controls.Add(this.tBPrice);
            this.Controls.Add(this.tBTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdManager";
            this.Text = "AdManager 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBTitle;
        private System.Windows.Forms.TextBox tBPrice;
        private System.Windows.Forms.ListBox listBoxAds;
        private System.Windows.Forms.ComboBox cBCategories;
        private System.Windows.Forms.TextBox tBDescription;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemoveAd;
        private System.Windows.Forms.Button btnInsertAd;
        private System.Windows.Forms.Button btnUpdateAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSortType;
        private System.Windows.Forms.ComboBox comboBoxSortOrder;
    }
}

