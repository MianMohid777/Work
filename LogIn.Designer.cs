namespace CMS_App
{
    partial class LogIn
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
            this.linkReg = new System.Windows.Forms.LinkLabel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.userBox1 = new System.Windows.Forms.TextBox();
            this.passBox1 = new System.Windows.Forms.TextBox();
            this.signButton = new System.Windows.Forms.Button();
            this.lblReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkReg
            // 
            this.linkReg.AutoSize = true;
            this.linkReg.BackColor = System.Drawing.Color.Transparent;
            this.linkReg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkReg.Location = new System.Drawing.Point(396, 317);
            this.linkReg.Name = "linkReg";
            this.linkReg.Size = new System.Drawing.Size(177, 17);
            this.linkReg.TabIndex = 0;
            this.linkReg.TabStop = true;
            this.linkReg.Text = "Register a New Farmer";
            this.linkReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(224, 157);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(95, 18);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username:";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(227, 209);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(92, 18);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password:";
            this.lblPass.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // userBox1
            // 
            this.userBox1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox1.Location = new System.Drawing.Point(341, 157);
            this.userBox1.Name = "userBox1";
            this.userBox1.Size = new System.Drawing.Size(158, 22);
            this.userBox1.TabIndex = 3;
            this.userBox1.TextChanged += new System.EventHandler(this.userBox1_TextChanged);
            // 
            // passBox1
            // 
            this.passBox1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox1.Location = new System.Drawing.Point(341, 210);
            this.passBox1.Name = "passBox1";
            this.passBox1.Size = new System.Drawing.Size(158, 22);
            this.passBox1.TabIndex = 4;
            this.passBox1.UseSystemPasswordChar = true;
            this.passBox1.TextChanged += new System.EventHandler(this.passBox1_TextChanged);
            // 
            // signButton
            // 
            this.signButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.signButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signButton.Location = new System.Drawing.Point(341, 266);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(90, 35);
            this.signButton.TabIndex = 5;
            this.signButton.Text = "Log In";
            this.signButton.UseVisualStyleBackColor = false;
            this.signButton.Click += new System.EventHandler(this.signButton_Click);
            this.signButton.Enter += new System.EventHandler(this.signButton_Click);
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.BackColor = System.Drawing.Color.Transparent;
            this.lblReg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.Location = new System.Drawing.Point(227, 317);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(163, 15);
            this.lblReg.TabIndex = 6;
            this.lblReg.Text = "Don\'t Have an Account ?";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::CMS_App.Properties.Resources.Back_Farm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.passBox1);
            this.Controls.Add(this.userBox1);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.linkReg);
            this.Name = "LogIn";
            this.Text = "Crop Management System";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkReg;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox userBox1;
        private System.Windows.Forms.TextBox passBox1;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Label lblReg;
    }
}