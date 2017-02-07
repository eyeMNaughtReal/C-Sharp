using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Builder
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
        * Project 2
        */
        private void upperCaseAButton_Click(object sender, EventArgs e)
        {

            string output;      // defined a variable string named output
            output = "A";       // Assigned the output a value
            sentenceLabel.Text += output; // Added the output value, to the sentence labe
        }

        private void lowerCaseAButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "a";
            sentenceLabel.Text += output;
        }

        private void upperCaseAnButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "An";
            sentenceLabel.Text += output;
        }

        private void lowerCaseAnButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "an";
            sentenceLabel.Text += output;
        }

        private void upperCaseTheButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "The";
            sentenceLabel.Text += output;
        }

        private void lowerCaseTheButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "the";
            sentenceLabel.Text += output;
        }

        private void manButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "man";
            sentenceLabel.Text += output;
        }

        private void womanButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "woman";
            sentenceLabel.Text += output;
        }

        private void dogButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "dog";
            sentenceLabel.Text += output;
        }

        private void catButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "cat";
            sentenceLabel.Text += output;
        }

        private void carButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "car";
            sentenceLabel.Text += output;
        }

        private void bicycleButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "bicycle";
            sentenceLabel.Text += output;
        }

        private void beautifulButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "beautiful";
            sentenceLabel.Text += output;
        }

        private void bigButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "big";
            sentenceLabel.Text += output;
        }

        private void smallButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "small";
            sentenceLabel.Text += output;
        }

        private void strangeButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "strange";
            sentenceLabel.Text += output;
        }

        private void lookedAtButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "looked at";
            sentenceLabel.Text += output;
        }

        private void rodeButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "rode";
            sentenceLabel.Text += output;
        }

        private void spokeToButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "spoke to";
            sentenceLabel.Text += output;
        }

        private void laughedAtButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "laughed at";
            sentenceLabel.Text += output;
        }

        private void droveButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "drove";
            sentenceLabel.Text += output;
        }

        private void spaceButton_Click(object sender, EventArgs e)
        {
            string output;
            output = " ";
            sentenceLabel.Text += output;
        }

        private void periodButton_Click(object sender, EventArgs e)
        {
            string output;
            output = ".";
            sentenceLabel.Text += output;
        }

        private void exclamationButton_Click(object sender, EventArgs e)
        {
            string output;
            output = "!";
            sentenceLabel.Text += output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text = ""; // clears the sentence label
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the application
        }
    }
}
