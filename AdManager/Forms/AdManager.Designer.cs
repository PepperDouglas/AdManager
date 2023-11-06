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
            this.SuspendLayout();
            // 
            // tBTitle
            // 
            this.tBTitle.Location = new System.Drawing.Point(395, 95);
            this.tBTitle.Name = "tBTitle";
            this.tBTitle.Size = new System.Drawing.Size(200, 20);
            this.tBTitle.TabIndex = 0;
            // 
            // tBPrice
            // 
            this.tBPrice.Location = new System.Drawing.Point(395, 137);
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.Size = new System.Drawing.Size(100, 20);
            this.tBPrice.TabIndex = 1;
            // 
            // listBoxAds
            // 
            this.listBoxAds.FormattingEnabled = true;
            this.listBoxAds.Location = new System.Drawing.Point(43, 48);
            this.listBoxAds.Name = "listBoxAds";
            this.listBoxAds.Size = new System.Drawing.Size(261, 225);
            this.listBoxAds.TabIndex = 2;
            this.listBoxAds.SelectedIndexChanged += new System.EventHandler(this.listBoxAd_SelectedIndexChanged);
            // 
            // cBCategories
            // 
            this.cBCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCategories.FormattingEnabled = true;
            this.cBCategories.Location = new System.Drawing.Point(395, 48);
            this.cBCategories.Name = "cBCategories";
            this.cBCategories.Size = new System.Drawing.Size(200, 21);
            this.cBCategories.TabIndex = 3;
            // 
            // tBDescription
            // 
            this.tBDescription.Location = new System.Drawing.Point(395, 177);
            this.tBDescription.Multiline = true;
            this.tBDescription.Name = "tBDescription";
            this.tBDescription.Size = new System.Drawing.Size(200, 101);
            this.tBDescription.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(520, 135);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemoveAd
            // 
            this.btnRemoveAd.Location = new System.Drawing.Point(43, 285);
            this.btnRemoveAd.Name = "btnRemoveAd";
            this.btnRemoveAd.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAd.TabIndex = 6;
            this.btnRemoveAd.Text = "Remove Ad";
            this.btnRemoveAd.UseVisualStyleBackColor = true;
            this.btnRemoveAd.Click += new System.EventHandler(this.btnRemoveAd_Click);
            // 
            // btnInsertAd
            // 
            this.btnInsertAd.Location = new System.Drawing.Point(229, 285);
            this.btnInsertAd.Name = "btnInsertAd";
            this.btnInsertAd.Size = new System.Drawing.Size(75, 23);
            this.btnInsertAd.TabIndex = 7;
            this.btnInsertAd.Text = "Insert Ad";
            this.btnInsertAd.UseVisualStyleBackColor = true;
            this.btnInsertAd.Click += new System.EventHandler(this.btnInsertAd_Click);
            // 
            // btnUpdateAd
            // 
            this.btnUpdateAd.Location = new System.Drawing.Point(395, 284);
            this.btnUpdateAd.Name = "btnUpdateAd";
            this.btnUpdateAd.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAd.TabIndex = 8;
            this.btnUpdateAd.Text = "Update Ad";
            this.btnUpdateAd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Advertisments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Description";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.Location = new System.Drawing.Point(542, 325);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(108, 35);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // AdManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(687, 397);
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
    }
}

