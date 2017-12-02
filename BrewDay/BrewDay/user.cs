using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrewDay
{
    public class User
    {
        private string username;
        private string password;
        public void set_username(string name,string pw)
        {
            username = name;
            password = pw;
        }
        public string get_username()
        {
            return username;
        }
        public string get_password()
        {
            return password;
        }
    }
}
