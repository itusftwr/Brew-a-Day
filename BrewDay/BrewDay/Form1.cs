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

namespace BrewDay
{
    public partial class Form1 : Form
    {
        public User user = new User();
        public bool logged_in = false;
        Ingredients ingredient = new Ingredients();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AyDoS\Desktop\brew\Brew-a-Day\BrewDay\BrewDay\database.mdf;Integrated Security=True;");

        public Form1()
        {

            InitializeComponent();
        }
        private void get_userinfo()
        {
            con.Open();
            String str = "SELECT [ingredient_id],[current_recipe] FROM [USER] WHERE USERNAME = '" + user.get_username() + "';";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                user.set_ingredient_id(reader["ingredient_id"].ToString());
                user.set_current_recipe(reader["current_recipe"].ToString());

            }
            con.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'databaseDataSet.user' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.userTableAdapter.Fill(this.databaseDataSet.user);
            // TODO: Bu kod satırı 'databaseDataSet.ingredients' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ingredientsTableAdapter.Fill(this.databaseDataSet.ingredients);
            // TODO: Bu kod satırı 'databaseDataSet.fav_rec' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.fav_recTableAdapter.Fill(this.databaseDataSet.fav_rec);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ingredi_Click(object sender, EventArgs e)
        {
            BrowseRecipesPanel.Visible = false;
            WhatShouldIBrwPanel.Visible = false;
            RecipeListPanel.Visible = false;
            IngListPanel.Visible = true;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        //Browse Reicpe Button Clikc
        private void brwsrec_Click(object sender, EventArgs e)
        {
            BrowseRecipesPanel.Visible = true;
            WhatShouldIBrwPanel.Visible = false;
            RecipeListPanel.Visible = false;
            IngListPanel.Visible = false;
        }




        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        //What Should I brew Today button click
        private void wsibt_Click(object sender, EventArgs e)
        {
            BrowseRecipesPanel.Visible = false;
            WhatShouldIBrwPanel.Visible = true;
            RecipeListPanel.Visible = false;
            IngListPanel.Visible = false;
        }
        //Recipe List button click
        private void reclist_Click(object sender, EventArgs e)
        {
            BrowseRecipesPanel.Visible = false;
            WhatShouldIBrwPanel.Visible = false;
            RecipeListPanel.Visible = true;
            IngListPanel.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Login logform = new Login(this);
            logform.Show();
        }

        private void IngListPanel_Paint(object sender, PaintEventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup signupform = new signup(this);
            signupform.Show();
        }

        public void changeLabelVisLogin()
        {
            if (logged_in == true)
            {
                login.Visible = false;
                linkLabel1.Visible = false;
                label11.Visible = true;
                get_userinfo();
                MessageBox.Show(user.get_ingredient_id());
            }
        }
        public void changeSignupLab()
        {
            linkLabel1.Visible = false;
        }
        public void setUsernameText(string a)
        {
            label11.Text = a;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void RecipeListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WhatShouldIBrwPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
