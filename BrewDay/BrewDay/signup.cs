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
    public partial class signup : Form
    {
        private Form1 form1;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yücel\Desktop\Yeni klasör\Brew-a-Day\BrewDay\BrewDay\database.mdf;Integrated Security=True;");
        public signup(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String str = "SELECT COUNT([USERNAME]) FROM [USER] JOIN [RECIPES] ON [USER].USERNAME = '" + UsernameBox.Text + "' OR [RECIPES].RECIPE_NAME = '" + UsernameBox.Text + "';";
            SqlCommand cmd = new SqlCommand(str, con);
            int UserExist = (int)cmd.ExecuteScalar();
            if (UserExist > 0)
            {
                MessageBox.Show("Username already exist");
            }
            else if (password1.Text != password2.Text)
            {
                MessageBox.Show("Passwords must match");
            }
            else if (UsernameBox.Text.Length < 1)
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if ((password1.Text == password2.Text) && (password1.Text).Length < 1)
            {
                MessageBox.Show("Password cannot be empty");
            }
            else
            {
                str = "INSERT INTO [USER](username,password) VALUES ( '" + UsernameBox.Text + "','" + password1.Text + "');";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sign up successfull");
                this.form1.changeSignupLab();
                this.Hide();
            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void showPass_Click(object sender, EventArgs e)
        {
            if (password1.UseSystemPasswordChar)
            {
                password1.UseSystemPasswordChar = false;
            }
            else
            {
                password1.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (password2.UseSystemPasswordChar)
            {
                password2.UseSystemPasswordChar = false;
            }
            else
            {
                password2.UseSystemPasswordChar = true;
            }
        }
    }
}
