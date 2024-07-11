using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace CMS_App
{
    public partial class HomePage1 : Form
    {
        public HomePage1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            New_Crop regCrop = new New_Crop();
            regCrop.Show();
            this.Hide();
        }

        private void currentFarm_Click(object sender, EventArgs e)
        {
            Current_farm direct = new Current_farm();
            direct.Show();
            this.Hide();
        }

        private void HomePage1_Load(object sender, EventArgs e)
        {

        }
    }
}
