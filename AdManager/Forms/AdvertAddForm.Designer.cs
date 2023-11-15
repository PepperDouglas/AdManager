namespace AdManager.Forms
{
    partial class AdvertAddForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBCategories = new System.Windows.Forms.ComboBox();
            this.tBTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBPrice = new System.Windows.Forms.TextBox();
            this.tBDescription = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelCharCounter = new System.Windows.Forms.Label();
            this.labelTitleCharCount = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(290, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // cBCategories
            // 
            this.cBCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCategories.FormattingEnabled = true;
            this.cBCategories.Location = new System.Drawing.Point(32, 45);
            this.cBCategories.Name = "cBCategories";
            this.cBCategories.Size = new System.Drawing.Size(121, 21);
            this.cBCategories.TabIndex = 2;
            // 
            // tBTitle
            // 
            this.tBTitle.Location = new System.Drawing.Point(159, 45);
            this.tBTitle.Name = "tBTitle";
            this.tBTitle.Size = new System.Drawing.Size(100, 20);
            this.tBTitle.TabIndex = 3;
            this.tBTitle.TextChanged += new System.EventHandler(this.UpdateWordCountTitle);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // tBPrice
            // 
            this.tBPrice.Location = new System.Drawing.Point(265, 46);
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.Size = new System.Drawing.Size(100, 20);
            this.tBPrice.TabIndex = 6;
            // 
            // tBDescription
            // 
            this.tBDescription.Location = new System.Drawing.Point(32, 98);
            this.tBDescription.Multiline = true;
            this.tBDescription.Name = "tBDescription";
            this.tBDescription.Size = new System.Drawing.Size(333, 117);
            this.tBDescription.TabIndex = 7;
            this.tBDescription.TextChanged += new System.EventHandler(this.UpdateWordCountDescription);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelCharCounter
            // 
            this.labelCharCounter.AutoSize = true;
            this.labelCharCounter.Location = new System.Drawing.Point(32, 220);
            this.labelCharCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCharCounter.Name = "labelCharCounter";
            this.labelCharCounter.Size = new System.Drawing.Size(54, 13);
            this.labelCharCounter.TabIndex = 9;
            this.labelCharCounter.Text = "( 0 / 200 )";
            // 
            // labelTitleCharCount
            // 
            this.labelTitleCharCount.AutoSize = true;
            this.labelTitleCharCount.Location = new System.Drawing.Point(186, 29);
            this.labelTitleCharCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitleCharCount.Name = "labelTitleCharCount";
            this.labelTitleCharCount.Size = new System.Drawing.Size(48, 13);
            this.labelTitleCharCount.TabIndex = 10;
            this.labelTitleCharCount.Text = "( 0 / 30 )";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(29, 82);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(60, 13);
            this.labelDesc.TabIndex = 11;
            this.labelDesc.Text = "Description";
            // 
            // AdvertAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 264);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelTitleCharCount);
            this.Controls.Add(this.labelCharCounter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tBDescription);
            this.Controls.Add(this.tBPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBTitle);
            this.Controls.Add(this.cBCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "AdvertAddForm";
            this.Text = "AdvertAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBCategories;
        private System.Windows.Forms.TextBox tBTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBPrice;
        private System.Windows.Forms.TextBox tBDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelCharCounter;
        private System.Windows.Forms.Label labelTitleCharCount;
        private System.Windows.Forms.Label labelDesc;
    }
}