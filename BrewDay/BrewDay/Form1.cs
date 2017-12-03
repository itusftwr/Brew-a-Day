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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AyDoS\Desktop\brew\Brew-a-Day\BrewDay\BrewDay\database.mdf;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }
        /*
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
        */
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
        
        private void brwsrec_Click(object sender, EventArgs e)
        {
            con.Open();

            String str = "SELECT * FROM [recipes];";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            browseDatagrid.AutoGenerateColumns = false;
            adapter.Fill(table);
            browseDatagrid.DataSource = table;

            con.Close();
            
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
            con.Open();

            String str = "SELECT [recipe_name] FROM [fav_rec] WHERE USERNAME = '" + user.get_username() + "';";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = new BindingSource(table, null);


            String str2 = "SELECT [recipe_name] FROM [recipes] WHERE CREATOR = '" + user.get_username() + "';";
            SqlCommand cmd2 = new SqlCommand(str2, con);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            dataGridView2.DataSource = new BindingSource(table2, null);

            con.Close();



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
                //get_userinfo();
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

        private void BrowseRecipesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void browseDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Search by recipe name")
            {
                con.Open();

                String str = "SELECT * FROM [recipes] WHERE RECIPE_NAME = '" + browseBox.Text + "';";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                browseDatagrid.AutoGenerateColumns = false;
                adapter.Fill(table);
                browseDatagrid.DataSource = table;

                con.Close();
            }
            else if (comboBox1.Text == "Search by creator")
            {
                con.Open();

                String str = "SELECT * FROM [recipes] WHERE CREATOR = '" + browseBox.Text + "';";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                browseDatagrid.AutoGenerateColumns = false;
                adapter.Fill(table);
                browseDatagrid.DataSource = table;

                con.Close();
            }
            else if (comboBox1.Text == "Search by time")
            {
                con.Open();

                String str = "SELECT * FROM [recipes] WHERE TIME = '" + browseBox.Text + "';";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                browseDatagrid.AutoGenerateColumns = false;
                adapter.Fill(table);
                browseDatagrid.DataSource = table;

                con.Close();
            }
            else if (comboBox1.Text == "Show all")
            {
                con.Open();

                String str = "SELECT * FROM [recipes];";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                browseDatagrid.AutoGenerateColumns = false;
                adapter.Fill(table);
                browseDatagrid.DataSource = table;

                con.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void browseBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void browseBox_Enter(object sender, EventArgs e)
        {
            if(browseBox.Text == "Value to search")
            {
                browseBox.Text = "";
                browseBox.ForeColor = Color.Black;
            }
        }

        private void browseBox_Leave(object sender, EventArgs e)
        {
            if (browseBox.Text == "")
            {
                browseBox.Text = "Value to search";
                browseBox.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Recipe name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Recipe name";
                textBox1.ForeColor = Color.Silver;
            }
        }
        /*
        private void button2_Click(object sender, EventArgs e)
        {
            string recipen = textBox1.Text;           
            con.Open();
            String str = "SELECT COUNT([recipe_name]) FROM [recipes] WHERE RECIPE_NAME= '" + recipen +"';";
            SqlCommand cmd = new SqlCommand(str, con);
            int recExst = (int)cmd.ExecuteScalar();
            if (recExst == 1)
            {
                commentPanel.Visible = true;
                SqlCommand mycmd = con.CreateCommand();
                SqlDataReader reader;
                string bnotes;
                mycmd.CommandText = "SELECT [notes] FROM [recipes] WHERE RECIPE_NAME= '" + recipen + "';";
                reader = mycmd.ExecuteReader();
                while (reader.Read())
                {
                    bnotes = reader.GetString(0);
                    textBox2.Text = bnotes;
                }
                mycmd.CommandText = "SELECT [ingredient_id] FROM [recipes] WHERE RECIPE_NAME= '" + recipen + "';";
                reader = mycmd.ExecuteReader();
                int ing;
                while (reader.Read())
                {
                    ing = reader.GetInt32(0);
                }
                mycmd.CommandText = "SELECT [ingredient_id] FROM [recipes] WHERE RECIPE_NAME= '" + recipen + "';";
                reader = mycmd.ExecuteReader();
                while (reader.Read())
                {
                    ing = reader.GetInt32(0);
                }
                                
            }
            else
            {
                MessageBox.Show("Invalid recipe name");
                textBox1.Text = "Recipe name";
                textBox1.ForeColor = Color.Silver;

            }
            con.Close();
        }
        */
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BrowseRecipesPanel.Visible = true;
            WhatShouldIBrwPanel.Visible = false;
            RecipeListPanel.Visible = false;
            IngListPanel.Visible = false;
            commentPanel.Visible = false;
        }
    }
}
