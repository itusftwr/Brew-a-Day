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
        private string ingredient_name;
        private string current_recipe;
        public void set_username(string name,string pw)
        {
            username = name;
            password = pw;
        }
        public void set_ingredient_name(string ing_name)
        {
            ingredient_name = ing_name;
        }
        public void set_current_recipe(string recipe_name)
        {
            current_recipe = recipe_name;
        }
        public string get_username()
        {
            return username;
        }
        public string get_password()
        {
            return password;
        }
        public string get_ingredient_name()
        {
            return ingredient_name;
        }
        public string get_current_recipe()
        {
            return current_recipe ;
        }
        //private recipe current_recipe;
        /*
        public void AddRecipe(recipe a)
        {

        }
        public void modify_fav_rec_list()
        {

        }
        public recipe wsibt()
        {

        }
        public void start_brewing(recipe a)
        {

        }
        */
    }
}
