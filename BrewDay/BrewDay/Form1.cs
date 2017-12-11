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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yücel\Desktop\Yeni klasör\Brew-a-Day\BrewDay\BrewDay\database.mdf;Integrated Security=True; MultipleActiveResultSets = True;");

        
        public Form1()
        {
            
            InitializeComponent();
            maltupbox.Text = "0";
            hopsupbox.Text = "0";
            yeastsupbox.Text = "0";
            sugarsupbox.Text = "0";
            additivesupbox.Text = "0";
            waterupbox.Text = "0";
        }

        private void get_userinfo()
        {
            con.Open();
            String str = "SELECT [ingredient_name],[current_recipe] FROM [USER] WHERE USERNAME = '" + user.get_username() + "';";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                user.set_ingredient_name(reader["ingredient_name"].ToString());
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
            modifyRecipePanel.Visible = false;
            recipelistadd.Visible = false;
            modifyFavList.Visible = false;
            commentPanel.Visible = false;
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
            SqlDataReader reader;
            DataTable table = new DataTable();
            browseDatagrid.AutoGenerateColumns = false;
            adapter.Fill(table);
            browseDatagrid.DataSource = table;

            shoppingCombo.Items.Clear();
            str = "SELECT [recipe_name] FROM [RECIPES];";
            cmd = new SqlCommand(str, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())           //Filling comments listbox
            {
                shoppingCombo.Items.Add(reader["recipe_name"].ToString());
            }

            con.Close();
            
            BrowseRecipesPanel.Visible = true;
            WhatShouldIBrwPanel.Visible = false;
            RecipeListPanel.Visible = false;
            commentPanel.Visible = false;
            IngListPanel.Visible = false;
            modifyRecipePanel.Visible = false;
            recipelistadd.Visible = false;
            modifyFavList.Visible = false;
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
            commentPanel.Visible = false;
            RecipeListPanel.Visible = false;
            IngListPanel.Visible = false;
            modifyRecipePanel.Visible = false;
            recipelistadd.Visible = false;
            modifyFavList.Visible = false;
        }
        //Recipe List button click
        private void reclist_Click(object sender, EventArgs e)
        {
            con.Open();

            String str = " select fav_rec.recipe_name, ingredients.malt, ingredients.hops, ingredients.yeasts,  ingredients.sugars,  ingredients.additives, ingredients.water,  recipes.creator from fav_rec inner join ingredients on fav_rec.recipe_name = ingredients.name inner join recipes on recipes.ingredient_name = ingredients.name Where fav_rec.username = '" + user.get_username() + "';";
            SqlCommand cmd = new SqlCommand(str, con); 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = new BindingSource(table, null);


            String str2 = "select recipes.recipe_name, ingredients.malt, ingredients.hops, ingredients.yeasts,  ingredients.sugars,  ingredients.additives, ingredients.water  from recipes inner join ingredients on recipes.recipe_name = ingredients.name Where recipes.creator =  '" + user.get_username() + "';";
            SqlCommand cmd2 = new SqlCommand(str2, con);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            dataGridView2.DataSource = new BindingSource(table2, null);

            con.Close();



            BrowseRecipesPanel.Visible = false;
            WhatShouldIBrwPanel.Visible = false;
            commentPanel.Visible = false;
            RecipeListPanel.Visible = true;
            IngListPanel.Visible = false;
            modifyRecipePanel.Visible = false;
            recipelistadd.Visible = false;
            modifyFavList.Visible = false;

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
           

            if (user.get_ingredient_name() == "")
            {
                maltbox.Text = "0";
                hopsbox.Text = "0";
                yeastsbox.Text = "0";
                sugarsbox.Text = "0";
                additivesbox.Text = "0";
                waterbox.Text = "0";

            }
            else
            {

                Ingredients ingredient = new Ingredients();
                con.Open();
                String str = "SELECT [malt],[hops],[yeasts],[sugars],[additives],[water] FROM [ingredients] WHERE name = '" + user.get_ingredient_name() + "';";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ingredient.add_malts(reader.GetInt32(0));
                    ingredient.add_hops(reader.GetInt32(1));
                    ingredient.add_yeasts(reader.GetInt32(2));
                    ingredient.add_sugars(reader.GetInt32(3));
                    ingredient.add_additives(reader.GetInt32(4));
                    ingredient.add_water(reader.GetInt32(5));
                    maltbox.Text = ingredient.get_malts().ToString();
                    hopsbox.Text = ingredient.get_hops().ToString();
                    yeastsbox.Text = ingredient.get_yeasts().ToString();
                    sugarsbox.Text = ingredient.get_sugars().ToString();
                    additivesbox.Text = ingredient.get_additives().ToString();
                    waterbox.Text = ingredient.get_water().ToString();

                }
                con.Close();
            }

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
        /*
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
        */
        private void button2_Click(object sender, EventArgs e)
        {
            string recipen = shoppingCombo.Text;             //Recipe name     
            con.Open();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            String str = "SELECT COUNT([recipe_name]) FROM [recipes] WHERE RECIPE_NAME= '" + recipen + "';";         //Does the recipe exist or not?
            SqlCommand cmd = new SqlCommand(str, con);
            int recExst = (int)cmd.ExecuteScalar();
            if (recExst == 1)                           //If exists
            {
                commentPanel.Visible = true;
                BrowseRecipesPanel.Visible = false;

                SqlDataReader reader;
                str = "SELECT [notes] FROM [recipes] WHERE RECIPE_NAME= '" + recipen + "';";
                cmd = new SqlCommand(str, con);
                reader = cmd.ExecuteReader();

                if (reader.Read())              //Filling brewer notes and changing recipe label
                {
                    recipenLabel.Text = recipen;
                    richTextBox1.Text = reader["notes"].ToString();
                }

                str = "SELECT * FROM [INGREDIENTS] WHERE NAME = '" + recipen + "';";
                cmd = new SqlCommand(str, con);
                reader = cmd.ExecuteReader();
                if (reader.Read())              //Filling ingredients listbox
                {
                    listBox1.Items.Add(reader["malt"].ToString());
                    listBox1.Items.Add(reader["hops"].ToString());
                    listBox1.Items.Add(reader["yeasts"].ToString());
                    listBox1.Items.Add(reader["sugars"].ToString());
                    listBox1.Items.Add(reader["additives"].ToString());
                    listBox1.Items.Add(reader["water"].ToString());
                }
                str = "SELECT * FROM [RECIPE_COMMENT] WHERE RECIPE_NAME = '" + recipen + "';";
                cmd = new SqlCommand(str, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())           //Filling comments listbox
                {
                    listBox2.Items.Add(reader["comment"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Invalid recipe name");
                shoppingCombo.Text = "Recipe name";
                shoppingCombo.ForeColor = Color.Silver;

            }
            con.Close();
        }
        
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

        private void update_ingredients_Click(object sender, EventArgs e)
        {
            int m;
            if (int.TryParse(maltupbox.Text, out m) && int.TryParse(hopsupbox.Text, out m) && int.TryParse(yeastsupbox.Text, out m) && int.TryParse(sugarsupbox.Text, out m) && int.TryParse(additivesupbox.Text, out m) && int.TryParse(waterupbox.Text, out m))
            {
                con.Open();

                if (user.get_ingredient_name() == "")
                {
                    user.set_ingredient_name(user.get_username());
                    String str = "INSERT INTO [INGREDIENTS] ([name],[malt],[hops],[yeasts],[sugars],[additives],[water]) VALUES ( '" + user.get_ingredient_name() + "','" + Convert.ToInt32(maltupbox.Text) + "','" + Convert.ToInt32(hopsupbox.Text) + "','" + Convert.ToInt32(yeastsupbox.Text) + "','" + Convert.ToInt32(sugarsupbox.Text) + "','" + Convert.ToInt32(additivesupbox.Text) + "','" + Convert.ToInt32(waterupbox.Text) + "');";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    str = "UPDATE [USER] SET [ingredient_name]='" + user.get_ingredient_name() + "' where[username] = '" + user.get_username() + "';";
                    cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    int malt = Convert.ToInt32(maltupbox.Text) + Convert.ToInt32(maltbox.Text);
                    int hops = Convert.ToInt32(hopsupbox.Text) + Convert.ToInt32(hopsbox.Text);
                    int yeasts = Convert.ToInt32(yeastsupbox.Text) + Convert.ToInt32(yeastsbox.Text);
                    int sugars = Convert.ToInt32(sugarsupbox.Text) + Convert.ToInt32(sugarsbox.Text);
                    int additives = Convert.ToInt32(additivesupbox.Text) + Convert.ToInt32(additivesbox.Text);
                    int water = Convert.ToInt32(waterupbox.Text) + Convert.ToInt32(waterbox.Text);

                    String str = "UPDATE [INGREDIENTS] SET  [malt] ='" + malt + "', [hops] ='" + hops + "', [yeasts] ='" + yeasts + "', [sugars] ='" + sugars + "', [additives] ='" + additives + "', [water] ='" + water + "'where name ='" + user.get_ingredient_name() + "';";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                }
                maltupbox.Text = "0";
                hopsupbox.Text = "0";
                yeastsupbox.Text = "0";
                sugarsupbox.Text = "0";
                additivesupbox.Text = "0";
                waterupbox.Text = "0";
                con.Close();
            }
            else
            {
                MessageBox.Show("Amounts must be numeric!!");
            }
        }

        private void maltbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addRec_Click(object sender, EventArgs e)
        {
            RecipeListPanel.Visible = false;
            recipelistadd.Visible = true;

        }

        private void addrecipecancelbut_Click(object sender, EventArgs e)
        {
            RecipeListPanel.Visible = true;
            recipelistadd.Visible = false;
        }

        private void addrecipeproceed_Click(object sender, EventArgs e)
        {
            con.Open();

            if (addrecipenamebox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("No name for the recipe");
                con.Close();

                return;
            }
            else if (addrecipetime.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("No expected time given for the recipe");
                con.Close();

                return;

            }
            else if (addrecipemaltbox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Not enough ingredients");
                con.Close();

                return;


            }
            else if (addrecipehopbox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Not enough ingredients");
                con.Close();

                return;

            }
            else if (addrecipeyeastbox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Not enough ingredients");
                con.Close();

                return;


            }
            else if (addrecipesugarbox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Not enough ingredients");
                con.Close();

                return;

            }
            else if (addrecipeadditivebox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Not enough ingredients");
                con.Close();

                return;


            }
            else if (addrecipewaterbox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Not enough ingredients");
                con.Close();

                return;


            }

            else
            {
                try
                {
                    String ingst = "INSERT INTO [INGREDIENTS] ([name],[malt],[hops],[yeasts],[sugars],[additives],[water]) VALUES ('" + addrecipenamebox.Text + "' , '" + Convert.ToInt32(addrecipemaltbox.Text) + "' , '" + Convert.ToInt32(addrecipehopbox.Text) + "' , '" + Convert.ToInt32(addrecipeyeastbox.Text) + "' , '" + Convert.ToInt32(addrecipesugarbox.Text) + "' , '" + Convert.ToInt32(addrecipeadditivebox.Text) + "' , '" + Convert.ToInt32(addrecipewaterbox.Text) + "');";
                    SqlCommand ing = new SqlCommand(ingst, con);
                    ing.ExecuteNonQuery();
                    String statement = "INSERT INTO [RECIPES] ([recipe_name],[time],[ingredient_name],[creator]) VALUES ( '" + addrecipenamebox.Text + "' , '" + Convert.ToInt32(addrecipetime.Text) + "' , '" + addrecipenamebox.Text + "' , '" + user.get_username() + "');"; 
                    SqlCommand cmd = new SqlCommand(statement, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("This recipe name is not valid");
                    con.Close();
                    return;
                }
            }


            EventArgs x = new EventArgs();
            recipelistadd.Visible = false;
            reclist_Click(addrecipeproceed, x);

        }

        private void EditFavs_Click(object sender, EventArgs e)
        {
            modifyFavList.Visible = true;
            RecipeListPanel.Visible = false;
            try
            {
                con.Open();

                String str = " select fav_rec.recipe_name, ingredients.malt, ingredients.hops, ingredients.yeasts,  ingredients.sugars,  ingredients.additives, ingredients.water,  recipes.creator from fav_rec inner join ingredients on fav_rec.recipe_name = ingredients.name inner join recipes on recipes.ingredient_name = ingredients.name Where fav_rec.username = '" + user.get_username() + "';";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView3.DataSource = new BindingSource(table, null);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return;
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String name = textBox4.Text;
                String str = "DELETE FROM fav_rec WHERE recipe_name='" + name + "' and username = '" + user.get_username() + "';";
                SqlCommand del = new SqlCommand(str, con);
                del.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return;
            }
            MessageBox.Show("Succesfully deleted.");
            EventArgs x = new EventArgs();
            modifyFavList.Visible = false;
            reclist_Click(addrecipeproceed, x);
        }

        private void cancelFavEdit_Click(object sender, EventArgs e)
        {
            EventArgs x = new EventArgs();
            modifyFavList.Visible = false;
            reclist_Click(addrecipeproceed, x);
        }

        private void ModRec_Click(object sender, EventArgs e)
        {
            modifyRecipePanel.Visible = true;
            RecipeListPanel.Visible = false;
            try
            {
                con.Open();

                String str2 = "select recipes.recipe_name, ingredients.malt, ingredients.hops, ingredients.yeasts,  ingredients.sugars,  ingredients.additives, ingredients.water  from recipes inner join ingredients on recipes.recipe_name = ingredients.name Where recipes.creator =  '" + user.get_username() + "';";
                SqlCommand cmd2 = new SqlCommand(str2, con);
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                DataTable table2 = new DataTable();
                adapter2.Fill(table2);
                dataGridView4.DataSource = new BindingSource(table2, null);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return;
            }
        }
        //cancel for modify recipe
        private void button6_Click(object sender, EventArgs e)
        {
            EventArgs x = new EventArgs();
            modifyRecipePanel.Visible = false;
            reclist_Click(addrecipeproceed, x);
        }
        //modify recipe proceed button
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String strin = "INSERT INTO [INGREDIENTS] ([name],[malt],[hops],[yeasts],[sugars],[additives],[water]) VALUES ( '" + textBox5.Text + "','" + Convert.ToInt32(textBox11.Text) + "','" + Convert.ToInt32(textBox10.Text) + "','" + Convert.ToInt32(textBox9.Text) + "','" + Convert.ToInt32(textBox8.Text) + "','" + Convert.ToInt32(textBox7.Text) + "','" + Convert.ToInt32(textBox6.Text) + "');";
                SqlCommand cmd = new SqlCommand(strin, con);
                cmd.ExecuteNonQuery();
                String strdel = "DELETE FROM recipes WHERE recipe_name='" + textBox12.Text + "' and creator = '" + user.get_username() + "';";
                SqlCommand del = new SqlCommand(strdel, con);
                del.ExecuteNonQuery();
                String ins = "INSERT INTO [RECIPES] ([recipe_name],[time],[ingredient_name],[creator]) VALUES ( '" + textBox5.Text + "','" + textBox13.Text + "','" + textBox5.Text + "','"+user.get_username()+"');";
                SqlCommand add = new SqlCommand(ins, con);
                add.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return;
            }
            MessageBox.Show("Modification Successful");
            EventArgs x = new EventArgs();
            modifyRecipePanel.Visible = false;
            reclist_Click(addrecipeproceed, x);
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            string recipen = shoppingCombo.Text;             //Recipe name     
            con.Open();
            String str = "INSERT INTO [RECIPE_COMMENT] ([recipe_name],[comment]) VALUES ('" + recipen + "' , '" + user.get_username() + ": " + textBox3.Text + "');";         //Insert comment
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            str = "SELECT * FROM [RECIPE_COMMENT] WHERE RECIPE_NAME = '" + recipen + "';";
            cmd = new SqlCommand(str, con);
            listBox2.Items.Clear();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())           //Filling comments listbox
            {
                listBox2.Items.Add(reader["comment"].ToString());
            }

            con.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            BrowseRecipesPanel.Visible = true;
            WhatShouldIBrwPanel.Visible = false;
            RecipeListPanel.Visible = false;
            IngListPanel.Visible = false;
            commentPanel.Visible = false;
        }

        private void commentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            String str = "SELECT COUNT(*) FROM [FAV_REC] WHERE USERNAME= '" + user.get_username() + "' AND RECIPE_NAME= '" + recipenLabel.Text + "';";         //Does the recipe exist or not?
            SqlCommand cmd = new SqlCommand(str, con);
            int recExst = (int)cmd.ExecuteScalar();
            if (recExst == 0)                           //If exists
            {
                str = "INSERT INTO [FAV_REC] ([username],[recipe_name]) VALUES ('" + user.get_username() + "' , '" + recipenLabel.Text + "');";         //Insert into fav list
                SqlCommand cmd2 = new SqlCommand(str, con);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Recipe succesfully added to your favorite list!");
            }
            else
            {
                MessageBox.Show("This recipe is already in your favorite list!");

            }

            con.Close();
        }
       
        private void waterbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void shopping_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string str = "SELECT * FROM [INGREDIENTS] WHERE NAME = '" + shoppingCombo.Text + "';";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            int malt, hops, yeasts, sugars, additives, water;
            int umalt, uhops, uyeasts, usugars, uadditives, uwater;
            if (reader.Read())           
            {
                //Recipe's ingredients
                malt = Convert.ToInt32(reader["malt"]);
                hops = Convert.ToInt32(reader["hops"]);
                yeasts = Convert.ToInt32(reader["yeasts"]);
                sugars = Convert.ToInt32(reader["sugars"]);
                additives = Convert.ToInt32(reader["additives"]);
                water = Convert.ToInt32(reader["water"]);

                str = "SELECT * FROM [INGREDIENTS] WHERE name = '" + user.get_username() + "';";
                cmd = new SqlCommand(str, con);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //User's ingredients
                    umalt = Convert.ToInt32(reader["malt"]);
                    uhops = Convert.ToInt32(reader["hops"]);
                    uyeasts = Convert.ToInt32(reader["yeasts"]);
                    usugars = Convert.ToInt32(reader["sugars"]);
                    uadditives = Convert.ToInt32(reader["additives"]);
                    uwater = Convert.ToInt32(reader["water"]);

                    if (malt > umalt || hops > uhops || yeasts > uyeasts || sugars > usugars || additives > uadditives || water > uwater)
                    {
                        String slist = "Required ingredients are: \n";
                        if (malt > umalt)
                        {
                            slist = slist + "Malt: " + (malt - umalt).ToString() + "\n";
                        }
                        if (hops > uhops)
                        {
                            slist = slist + "Hops: " + (hops - uhops).ToString() + "\n";
                        }
                        if (yeasts > uyeasts)
                        {
                            slist = slist + "Yeasts: " + (yeasts - uyeasts).ToString() + "\n";
                        }
                        if (sugars > usugars)
                        {
                            slist = slist + "Sugar: " + (sugars - usugars).ToString() + "\n";
                        }
                        if (additives > uadditives)
                        {
                            slist = slist + "Additives: " + (additives - uadditives).ToString() + "\n";
                        }
                        if (water > uwater)
                        {
                            slist = slist + "Water: " + (water - uwater).ToString() + "\n";
                        }
                        MessageBox.Show(slist);
                    }
                    else
                    {
                        MessageBox.Show("Ingredients are enough for this recipe. Have a good brew :)");
                    }
                }
            }

            con.Close();
        }
    }
}
