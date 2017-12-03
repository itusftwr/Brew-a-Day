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
    public partial class Login : Form
    {
        private Form1 form1;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yücel\Desktop\Yeni klasör\Brew-a-Day\BrewDay\BrewDay\database.mdf;Integrated Security=True;");
        public Login(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            
            this.form1.user.set_username(UsernameBox.Text, PasswordBox.Text);
            con.Open();
            String str = "SELECT COUNT([USERNAME]) FROM [USER] WHERE USERNAME = '" + form1.user.get_username() + "'AND PASSWORD ='" + form1.user.get_password() + "';";
            SqlCommand cmd = new SqlCommand(str, con);
            int UserExist = (int)cmd.ExecuteScalar();
            
            if(UserExist ==1)
            {
                MessageBox.Show("Login Successful");
                this.form1.logged_in = true;
                this.form1.setUsernameText(form1.user.get_username());
                this.form1.changeLabelVisLogin();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
            con.Close();

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
