using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrewDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void wsibt_Click(object sender, EventArgs e)
        {
            BrowseRecipesPanel.Visible = false;
            WhatShouldIBrwPanel.Visible = true;
            RecipeListPanel.Visible = false;
            IngListPanel.Visible = false;
        }

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
    }
}
