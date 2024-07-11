namespace CMS_App
{
    partial class New_Crop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLand = new System.Windows.Forms.Label();
            this.landBox = new System.Windows.Forms.TextBox();
            this.cropBox = new System.Windows.Forms.TextBox();
            this.qtyBox = new System.Windows.Forms.TextBox();
            this.lblCrop = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblsession = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.sessionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLand
            // 
            this.lblLand.AutoSize = true;
            this.lblLand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLand.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLand.Location = new System.Drawing.Point(142, 136);
            this.lblLand.Name = "lblLand";
            this.lblLand.Size = new System.Drawing.Size(207, 18);
            this.lblLand.TabIndex = 0;
            this.lblLand.Text = "Land Area ( cultivation ) :";
            this.lblLand.Click += new System.EventHandler(this.label1_Click);
            // 
            // landBox
            // 
            this.landBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landBox.Location = new System.Drawing.Point(384, 134);
            this.landBox.Name = "landBox";
            this.landBox.Size = new System.Drawing.Size(134, 23);
            this.landBox.TabIndex = 1;
            // 
            // cropBox
            // 
            this.cropBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Wheat",
            "Tomato",
            "Tobacco",
            "Rapeseed & Mustard",
            "Potato",
            "Onion",
            "Linseed (Alsee)",
            "Gram",
            "Garlic",
            "Coriander",
            "Barley",
            "Cauliflower",
            "Radish",
            "Spinach",
            "Sweet Potato",
            "Turnip",
            "Green",
            "Beans",
            "Beets",
            "Fenno Geek",
            "Lettuce",
            "Khol Khal",
            "Carrot",
            "Cabbage",
            "Brinjal",
            "Masoor",
            "Pulse",
            "Banana (R)",
            "Ber",
            "Guava",
            "Laquat",
            "Grapes",
            "Dates (R)",
            "Almond (R)",
            "Mulbery",
            "Grape Fruit",
            "Kinnu",
            "Lemon",
            "Mandrine",
            "Orange",
            "Musmbi",
            "Sour Lime",
            "Sour Orange",
            "Sweet Lime",
            "Sugarcane",
            "Rice",
            "Cotton",
            "Bajra",
            "Jowar",
            "Maize",
            "Seasamum",
            "Tumeric",
            "Chillies",
            "Groundnut",
            "Soyabean",
            "Safflower",
            "Sunflower",
            "Lady Finger",
            "Bitter Gourd",
            "Bottel Gourd",
            "Arum",
            "Field Vech",
            "Cucumber",
            "Beans",
            "Long Melon",
            "Luffa",
            "Lotus Roats",
            "Pumpkin",
            "Musk Melon",
            "Tinda",
            "Water Melon",
            "Mung",
            "Mash",
            "Almond (K)",
            "Apple",
            "Appricot",
            "Banana (K)",
            "Chikoo",
            "Coconut",
            "Dates (K)",
            "Figs",
            "Guava",
            "Jaman",
            "Litchi",
            "Mango",
            "Pomergrante",
            "Plums",
            "Pears",
            "Falsa",
            "Papaya",
            "Peaches",
            "Walnut"});
            this.cropBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cropBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cropBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cropBox.Location = new System.Drawing.Point(384, 182);
            this.cropBox.Name = "cropBox";
            this.cropBox.Size = new System.Drawing.Size(134, 23);
            this.cropBox.TabIndex = 2;
            this.cropBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // qtyBox
            // 
            this.qtyBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyBox.Location = new System.Drawing.Point(384, 336);
            this.qtyBox.Name = "qtyBox";
            this.qtyBox.Size = new System.Drawing.Size(134, 23);
            this.qtyBox.TabIndex = 4;
            // 
            // lblCrop
            // 
            this.lblCrop.AutoSize = true;
            this.lblCrop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrop.Location = new System.Drawing.Point(142, 184);
            this.lblCrop.Name = "lblCrop";
            this.lblCrop.Size = new System.Drawing.Size(102, 18);
            this.lblCrop.TabIndex = 8;
            this.lblCrop.Text = "Crop Name:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(142, 230);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(95, 18);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Crop Type:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(142, 336);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(208, 18);
            this.lblQty.TabIndex = 10;
            this.lblQty.Text = "Seed Quantity ( Kg / ha ) :";
            // 
            // lblsession
            // 
            this.lblsession.AutoSize = true;
            this.lblsession.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsession.Location = new System.Drawing.Point(142, 283);
            this.lblsession.Name = "lblsession";
            this.lblsession.Size = new System.Drawing.Size(165, 18);
            this.lblsession.TabIndex = 11;
            this.lblsession.Text = "Cultivating Session:";
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(384, 386);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(134, 23);
            this.priceBox.TabIndex = 13;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(142, 388);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(156, 18);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Seed Price ( / ha ) :";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(384, 459);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(107, 37);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Proceed";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // typeBox
            // 
            this.typeBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Wheat",
            "Tomato",
            "Tobacco",
            "Rapeseed & Mustard",
            "Potato",
            "Onion",
            "Linseed (Alsee)",
            "Gram",
            "Garlic",
            "Coriander",
            "Barley",
            "Cauliflower",
            "Radish",
            "Spinach",
            "Sweet Potato",
            "Turnip",
            "Green",
            "Beans",
            "Beets",
            "Fenno Geek",
            "Lettuce",
            "Khol Khal",
            "Carrot",
            "Cabbage",
            "Brinjal",
            "Masoor",
            "Pulse",
            "Banana (R)",
            "Ber",
            "Guava",
            "Laquat",
            "Grapes",
            "Dates (R)",
            "Almond (R)",
            "Mulbery",
            "Grape Fruit",
            "Kinnu",
            "Lemon",
            "Mandrine",
            "Orange",
            "Musmbi",
            "Sour Lime",
            "Sour Orange",
            "Sweet Lime",
            "Sugarcane",
            "Rice",
            "Cotton",
            "Bajra",
            "Jowar",
            "Maize",
            "Seasamum",
            "Tumeric",
            "Chillies",
            "Groundnut",
            "Soyabean",
            "Safflower",
            "Sunflower",
            "Lady Finger",
            "Bitter Gourd",
            "Bottel Gourd",
            "Arum",
            "Field Vech",
            "Cucumber",
            "Beans",
            "Long Melon",
            "Luffa",
            "Lotus Roats",
            "Pumpkin",
            "Musk Melon",
            "Tinda",
            "Water Melon",
            "Mung",
            "Mash",
            "Almond (K)",
            "Apple",
            "Appricot",
            "Banana (K)",
            "Chikoo",
            "Coconut",
            "Dates (K)",
            "Figs",
            "Guava",
            "Jaman",
            "Litchi",
            "Mango",
            "Pomergrante",
            "Plums",
            "Pears",
            "Falsa",
            "Papaya",
            "Peaches",
            "Walnut"});
            this.typeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.typeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.typeBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.Location = new System.Drawing.Point(384, 230);
            this.typeBox.Name = "typeBox";
            this.typeBox.ReadOnly = true;
            this.typeBox.Size = new System.Drawing.Size(134, 23);
            this.typeBox.TabIndex = 16;
            // 
            // sessionBox
            // 
            this.sessionBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Wheat",
            "Tomato",
            "Tobacco",
            "Rapeseed & Mustard",
            "Potato",
            "Onion",
            "Linseed (Alsee)",
            "Gram",
            "Garlic",
            "Coriander",
            "Barley",
            "Cauliflower",
            "Radish",
            "Spinach",
            "Sweet Potato",
            "Turnip",
            "Green",
            "Beans",
            "Beets",
            "Fenno Geek",
            "Lettuce",
            "Khol Khal",
            "Carrot",
            "Cabbage",
            "Brinjal",
            "Masoor",
            "Pulse",
            "Banana (R)",
            "Ber",
            "Guava",
            "Laquat",
            "Grapes",
            "Dates (R)",
            "Almond (R)",
            "Mulbery",
            "Grape Fruit",
            "Kinnu",
            "Lemon",
            "Mandrine",
            "Orange",
            "Musmbi",
            "Sour Lime",
            "Sour Orange",
            "Sweet Lime",
            "Sugarcane",
            "Rice",
            "Cotton",
            "Bajra",
            "Jowar",
            "Maize",
            "Seasamum",
            "Tumeric",
            "Chillies",
            "Groundnut",
            "Soyabean",
            "Safflower",
            "Sunflower",
            "Lady Finger",
            "Bitter Gourd",
            "Bottel Gourd",
            "Arum",
            "Field Vech",
            "Cucumber",
            "Beans",
            "Long Melon",
            "Luffa",
            "Lotus Roats",
            "Pumpkin",
            "Musk Melon",
            "Tinda",
            "Water Melon",
            "Mung",
            "Mash",
            "Almond (K)",
            "Apple",
            "Appricot",
            "Banana (K)",
            "Chikoo",
            "Coconut",
            "Dates (K)",
            "Figs",
            "Guava",
            "Jaman",
            "Litchi",
            "Mango",
            "Pomergrante",
            "Plums",
            "Pears",
            "Falsa",
            "Papaya",
            "Peaches",
            "Walnut"});
            this.sessionBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sessionBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.sessionBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionBox.Location = new System.Drawing.Point(384, 282);
            this.sessionBox.Name = "sessionBox";
            this.sessionBox.ReadOnly = true;
            this.sessionBox.Size = new System.Drawing.Size(134, 23);
            this.sessionBox.TabIndex = 17;
            // 
            // New_Crop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(894, 525);
            this.Controls.Add(this.sessionBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.lblsession);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCrop);
            this.Controls.Add(this.qtyBox);
            this.Controls.Add(this.cropBox);
            this.Controls.Add(this.landBox);
            this.Controls.Add(this.lblLand);
            this.Name = "New_Crop";
            this.Text = "Crop Management System";
            this.Load += new System.EventHandler(this.Add_Farm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLand;
        private System.Windows.Forms.TextBox landBox;
        private System.Windows.Forms.TextBox cropBox;
        private System.Windows.Forms.TextBox qtyBox;
        private System.Windows.Forms.Label lblCrop;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblsession;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox sessionBox;
    }
}