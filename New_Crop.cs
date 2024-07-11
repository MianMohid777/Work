using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_App
{
    public partial class New_Crop : Form
    {
       
        public New_Crop()
        {
            InitializeComponent();
            string Id = LogIn.ID;     

        }

        private void getData()
        {
            SqlConnection con = new SqlConnection("Data Source=MIAN-DESKTOP-77\\SQLEXPRESS;Initial Catalog=CropManagementSystem;Integrated Security=True");
            
            con.Open();

            string name = cropBox.Text;

            string fetch = "SELECT cropType FROM Types WHERE cropName = '" + name + "'";

            SqlCommand cmd = new SqlCommand(fetch, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                typeBox.Text = Convert.ToString(dt.Rows[0][0]);

                if (typeBox.Text == "Rabi")
                    sessionBox.Text = "Winter";
                else
                    sessionBox.Text = "Summer";

            }
               
        }
        private void Add_Farm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            getData();
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MIAN-DESKTOP-77\\SQLEXPRESS;Initial Catalog=CropManagementSystem;Integrated Security=True");

            con.Open();

            int area = 0 ,qty = 0, price = 0;

            if (landBox.Text != "")
            {  area = Convert.ToInt32(landBox.Text); }

            string cName = cropBox.Text;
            string type = typeBox.Text;

            if (qtyBox.Text != "")
            { qty = Convert.ToInt32(qtyBox.Text); }

            if (priceBox.Text != "")
            { price = Convert.ToInt32(priceBox.Text); }

            if(landBox.Text == ""|| qtyBox.Text == "" || priceBox.Text == "" || cropBox.Text == "")
            {
                MessageBox.Show("Fill the empty field(s)");
                return;
            }
            string fetch_land = "SELECT uncultivatedLand FROM Land WHERE farmerID = '" + LogIn.ID + "'";
            
            SqlCommand cmd = new SqlCommand(fetch_land, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                string U_area = Convert.ToString(dt.Rows[0][0]);

                int remain = Convert.ToInt32(U_area) - Convert.ToInt32(area);

                if (remain < 0)
                {
                    MessageBox.Show("Insufficent Land Available for Cultivation");
                    landBox.Clear();
                }
                else
                {
                    string rem = Convert.ToString(remain);

                    string sq = "UPDATE Land SET cultivatedLand = '"+area+"', uncultivatedLand = '"+rem+"' WHERE farmerID = '" + LogIn.ID + "' ";
                    cmd = new SqlCommand(sq, con);
                    cmd.ExecuteNonQuery();

                    string query = "Insert into Crops (farmerID,cropName,cropType,areaPloughed,seedQty,seedPrice) values ('"+LogIn.ID+ "','"+cName+"','"+type+"','"+area+"','"+qty+"','"+price+"')";

                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Crop Production Started Successfully");
                    con.Dispose();

                    HomePage1 direct = new HomePage1();
                    direct.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Data Not Found");           
            con.Close();
        }
    }
}
