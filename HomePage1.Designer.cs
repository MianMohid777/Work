namespace CMS_App
{
    partial class HomePage1
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
            this.exitButton = new System.Windows.Forms.Button();
            this.currentFarm = new System.Windows.Forms.PictureBox();
            this.newFarm = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currentFarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newFarm)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(33, 30);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(78, 30);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // currentFarm
            // 
            this.currentFarm.Image = global::CMS_App.Properties.Resources.Farm;
            this.currentFarm.Location = new System.Drawing.Point(457, 146);
            this.currentFarm.Name = "currentFarm";
            this.currentFarm.Size = new System.Drawing.Size(226, 195);
            this.currentFarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentFarm.TabIndex = 3;
            this.currentFarm.TabStop = false;
            this.currentFarm.Click += new System.EventHandler(this.currentFarm_Click);
            // 
            // newFarm
            // 
            this.newFarm.Image = global::CMS_App.Properties.Resources.Farmer_2;
            this.newFarm.Location = new System.Drawing.Point(133, 146);
            this.newFarm.Name = "newFarm";
            this.newFarm.Size = new System.Drawing.Size(226, 195);
            this.newFarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newFarm.TabIndex = 2;
            this.newFarm.TabStop = false;
            this.newFarm.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "START NEW CROP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "CURRENT CROPS";
            // 
            // HomePage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(795, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentFarm);
            this.Controls.Add(this.newFarm);
            this.Controls.Add(this.exitButton);
            this.MaximizeBox = false;
            this.Name = "HomePage1";
            this.Text = "Crop Management System";
            this.Load += new System.EventHandler(this.HomePage1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentFarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newFarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox newFarm;
        private System.Windows.Forms.PictureBox currentFarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}