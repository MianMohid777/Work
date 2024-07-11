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
    public partial class Register : Form
    {
        LogIn Signin = new LogIn();
        public Register()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblPass2_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=MIAN-DESKTOP-77\\SQLEXPRESS;Initial Catalog=CropManagementSystem;Integrated Security=True");

                con.Open();

                string name = nameBox.Text;
                string username = userBox.Text;

                if (name.Length == 0)
                {
                    MessageBox.Show("Farmer Name field is empty");
                    return;
                }
                else if (username.Length == 0)
                {
                    MessageBox.Show("Username field is empty");
                    return;

                }
                else if (username.Length > 0 && username.Length < 4)
                {
                    MessageBox.Show("Username must be of 4 characters or more");
                    userBox.Clear();
                    return;
                }

                string pass1 = passBox1.Text;
                string pass2 = passBox2.Text;
                int area = 0;

                if (areaBox.Text != "")
                    area = Convert.ToInt32(areaBox.Text);


                if (pass1.Length == 0 || pass2.Length == 0)
                {
                    MessageBox.Show("Password field is empty");
                    passBox1.Clear();
                    passBox2.Clear();
                    

                }
                else if (areaBox.Text == "")
                {
                    MessageBox.Show("Land Area field is empty");
                   
                }
                else if (Convert.ToInt32(areaBox.Text) == 0)
                {
                    MessageBox.Show("Land Area must be of 1 ha or greater");
                    areaBox.Clear();
                    
                }
                else if (pass1 != pass2)
                {
                    MessageBox.Show("Passwords Didn't Match", "Registeration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passBox1.Clear();
                    passBox2.Clear();

                }
                else if (pass1.Length < 8 || pass2.Length < 8)
                {
                    MessageBox.Show("Password should consist of minimum of 8 characters");
                    passBox1.Clear();
                    passBox2.Clear();
                }
                else
                {
                    SqlCommand cmd;

                    string check = "SELECT userName FROM farmer WHERE userName = '"+username+"'";

                    cmd = new SqlCommand(check, con);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        string query = "Insert into farmer (farmerName,userName,passWord,landArea) values ('"+name+"','"+username+"','"+pass1+"','"+area+"')";

                        cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Farmer Registered Successfully", "Registeration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string fetchID = "SELECT farmerID FROM farmer WHERE userName = '"+username+"'";

                        cmd = new SqlCommand(fetchID, con);

                        SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                        DataTable dt2 = new DataTable();
                        da2.Fill(dt2);

                        if (dt2.Rows.Count > 0)
                        {
                            string identity = Convert.ToString(dt2.Rows[0][0]);
                          
                            query = "Insert into Land (farmerID,cultivatedLand,uncultivatedLand) values ('" + identity + "','" + 0 + "','" + area + "')";

                           SqlCommand cmd2 = new SqlCommand(query, con);
                           cmd2.ExecuteNonQuery();
                    
                        }

                        LogIn redirect = new LogIn();
                        redirect.Show();
                        this.Hide();    
                    }
                    else
                    { 
                        MessageBox.Show("Username already taken");
                        userBox.Clear();
                    }

                con.Dispose();

                }
                con.Close();
        }
            catch (Exception) 
            { 
                MessageBox.Show("Error !");
            }

}

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Signin.Show();
           this.Hide();
        }

        private void passBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
