using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrewDay
{
    class Ingredients
    {
        private string name;
        private int malts;
        private int hops;
        private int yeasts;
        private int sugars;
        private int additives;
        private int water;
        
        public string get_name()
        {
            return name;
        }
        public int get_malts()
        {
            return malts;
        }
        public int get_hops()
        {
            return hops;
        }
        public int get_yeasts()
        {
            return yeasts;
        }
        public int get_sugars()
        {
            return sugars;
        }
        public int get_additives()
        {
            return additives;
        }
        public int get_water()
        {
            return water;
        }
        public void add_malts(int malt)
        {
            malts = malts + malt;
        }
        public void add_hops(int hop)
        {
            hops = hops + hop;
        }
        public void add_yeasts(int yeast)
        {
            yeasts = yeasts + yeast;
        }
        public void add_sugars(int sugar)
        {
            sugars = sugars + sugar;
        }
        public void add_additives(int additive)
        {
            additives = additives + additive;
        }
        public void add_water(int waterx)
        {
            water = water + waterx;

        }

    }
}
