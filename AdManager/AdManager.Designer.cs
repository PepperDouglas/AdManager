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
            this.tBTitle.Location = new System.Drawing.Point(592, 142);
            this.tBTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBTitle.Name = "tBTitle";
            this.tBTitle.Size = new System.Drawing.Size(298, 26);
            this.tBTitle.TabIndex = 0;
            // 
            // tBPrice
            // 
            this.tBPrice.Location = new System.Drawing.Point(592, 205);
            this.tBPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.Size = new System.Drawing.Size(148, 26);
            this.tBPrice.TabIndex = 1;
            // 
            // listBoxAds
            // 
            this.listBoxAds.FormattingEnabled = true;
            this.listBoxAds.ItemHeight = 20;
            this.listBoxAds.Location = new System.Drawing.Point(64, 72);
            this.listBoxAds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxAds.Name = "listBoxAds";
            this.listBoxAds.Size = new System.Drawing.Size(390, 344);
            this.listBoxAds.TabIndex = 2;
            this.listBoxAds.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cBCategories
            // 
            this.cBCategories.FormattingEnabled = true;
            this.cBCategories.Location = new System.Drawing.Point(592, 72);
            this.cBCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBCategories.Name = "cBCategories";
            this.cBCategories.Size = new System.Drawing.Size(298, 28);
            this.cBCategories.TabIndex = 3;
            // 
            // tBDescription
            // 
            this.tBDescription.Location = new System.Drawing.Point(592, 266);
            this.tBDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBDescription.Multiline = true;
            this.tBDescription.Name = "tBDescription";
            this.tBDescription.Size = new System.Drawing.Size(298, 150);
            this.tBDescription.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(780, 202);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemoveAd
            // 
            this.btnRemoveAd.Location = new System.Drawing.Point(64, 428);
            this.btnRemoveAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveAd.Name = "btnRemoveAd";
            this.btnRemoveAd.Size = new System.Drawing.Size(112, 35);
            this.btnRemoveAd.TabIndex = 6;
            this.btnRemoveAd.Text = "Remove Ad";
            this.btnRemoveAd.UseVisualStyleBackColor = true;
            // 
            // btnInsertAd
            // 
            this.btnInsertAd.Location = new System.Drawing.Point(344, 428);
            this.btnInsertAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertAd.Name = "btnInsertAd";
            this.btnInsertAd.Size = new System.Drawing.Size(112, 35);
            this.btnInsertAd.TabIndex = 7;
            this.btnInsertAd.Text = "Insert Ad";
            this.btnInsertAd.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAd
            // 
            this.btnUpdateAd.Location = new System.Drawing.Point(592, 426);
            this.btnUpdateAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateAd.Name = "btnUpdateAd";
            this.btnUpdateAd.Size = new System.Drawing.Size(112, 35);
            this.btnUpdateAd.TabIndex = 8;
            this.btnUpdateAd.Text = "Update Ad";
            this.btnUpdateAd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Advertisments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 77);
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
            this.label4.Location = new System.Drawing.Point(496, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Description";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.Location = new System.Drawing.Point(813, 488);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 53);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // AdManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1030, 595);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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

