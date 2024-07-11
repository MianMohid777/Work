using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMS_App
{
    
    public partial class LogIn : Form
    {
        public static string ID;
        public LogIn()
        {
            InitializeComponent();
           
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register Signup = new Register();
            Signup.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void userBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void signButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MIAN-DESKTOP-77\\SQLEXPRESS;Initial Catalog=CropManagementSystem;Integrated Security=True");

            con.Open();

            string user = userBox1.Text;
            string pass  = passBox1.Text;

            string fetch = "SELECT farmerId,userName,passWord FROM farmer WHERE userName = '"+user+"' AND passWord = '"+pass+"'";

            SqlCommand cmd;

            cmd = new SqlCommand(fetch, con);

            string username = "";
            string password = "";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Logged In Successfully");

                ID = (Convert.ToString(dt.Rows[0][0]));
                userBox1.Clear();
                passBox1.Clear();

                HomePage1 home = new HomePage1();
                home.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username/Password");
            }
            
        }
    }
}
