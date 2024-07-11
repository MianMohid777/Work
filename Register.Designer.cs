namespace CMS_App
{
    partial class Register
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass1 = new System.Windows.Forms.Label();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox1 = new System.Windows.Forms.TextBox();
            this.passBox2 = new System.Windows.Forms.TextBox();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(97, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Farmer Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(114, 170);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(95, 18);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username:";
            // 
            // lblPass1
            // 
            this.lblPass1.AutoSize = true;
            this.lblPass1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass1.Location = new System.Drawing.Point(117, 221);
            this.lblPass1.Name = "lblPass1";
            this.lblPass1.Size = new System.Drawing.Size(92, 18);
            this.lblPass1.TabIndex = 2;
            this.lblPass1.Text = "Password:";
            // 
            // lblPass2
            // 
            this.lblPass2.AutoSize = true;
            this.lblPass2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass2.Location = new System.Drawing.Point(411, 219);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(158, 18);
            this.lblPass2.TabIndex = 3;
            this.lblPass2.Text = "Confirm Password:";
            this.lblPass2.Click += new System.EventHandler(this.lblPass2_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(74, 278);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(144, 18);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Land Area ( ha ) :";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(235, 120);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(138, 22);
            this.nameBox.TabIndex = 5;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.Location = new System.Drawing.Point(235, 168);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(138, 22);
            this.userBox.TabIndex = 6;
            // 
            // passBox1
            // 
            this.passBox1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox1.Location = new System.Drawing.Point(235, 219);
            this.passBox1.Name = "passBox1";
            this.passBox1.Size = new System.Drawing.Size(138, 22);
            this.passBox1.TabIndex = 7;
            this.passBox1.UseSystemPasswordChar = true;
            // 
            // passBox2
            // 
            this.passBox2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox2.Location = new System.Drawing.Point(587, 218);
            this.passBox2.Name = "passBox2";
            this.passBox2.Size = new System.Drawing.Size(138, 22);
            this.passBox2.TabIndex = 8;
            this.passBox2.UseSystemPasswordChar = true;
            this.passBox2.TextChanged += new System.EventHandler(this.passBox2_TextChanged);
            // 
            // areaBox
            // 
            this.areaBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaBox.Location = new System.Drawing.Point(235, 279);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(138, 22);
            this.areaBox.TabIndex = 9;
            // 
            // regButton
            // 
            this.regButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.regButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.regButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regButton.Location = new System.Drawing.Point(336, 338);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(104, 35);
            this.regButton.TabIndex = 10;
            this.regButton.Text = "Register";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            this.regButton.Enter += new System.EventHandler(this.regButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(308, 388);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(173, 17);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an Account?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(854, 462);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.passBox2);
            this.Controls.Add(this.passBox1);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPass2);
            this.Controls.Add(this.lblPass1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblName);
            this.Name = "Register";
            this.Text = "Crop Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass1;
        private System.Windows.Forms.Label lblPass2;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox1;
        private System.Windows.Forms.TextBox passBox2;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

