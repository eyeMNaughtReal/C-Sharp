using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /* Created by Mark Conley 
         * Class: COP2551.0M1 
         * Date: 01/10/2017 
         * Instructor: Debbie Reid
         * Project 1
         */
        private void showStars_Click(object sender, EventArgs e)
        {
            // Makes all stars visible
            betelgeuseLabel.Visible = true;
            meissaLabel.Visible = true;
            alnitakLabel.Visible = true;
            alnilamLabel.Visible = true;
            mintakaLabel.Visible = true;
            saiphLabel.Visible = true;
            rigelLabel.Visible = true;
        }

        private void hideStars_Click(object sender, EventArgs e)
        {
            // Hides all stars
            betelgeuseLabel.Visible = false;
            meissaLabel.Visible = false;
            alnitakLabel.Visible = false;
            alnilamLabel.Visible = false;
            mintakaLabel.Visible = false;
            saiphLabel.Visible = false;
            rigelLabel.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes application
            this.Close();
        }
    }
}
