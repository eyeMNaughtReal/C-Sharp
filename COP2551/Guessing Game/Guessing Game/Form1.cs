using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        private int answer; // answer variable is generated
        private int guess; // guess variable is generated
        private int count = 1; // count variable is generated and assigned a default value of 1

        public Form1()
        {
            InitializeComponent();
            answer = rand.Next(10) + 1;  //initializing the random number, giving it a range of 1-100
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            try
            {
                    guess = Convert.ToInt32(textGuess.Text);

                    if (guess == answer)
                    {
                        labelFalse.Visible = true;
                        labelFalse.Text = ("Congratulations!  You got it on your " + count + " guess.");
                        textGuess.Text = ""; // clearing the input field, after the guess
                    }

                    else
                        if (guess < answer) // assigning the loop, for the 
                    {
                        labelFalse.Visible = true;
                        labelFalse.Text = ("Your guess was " + guess + ".  That is too low, try again! " + answer);
                        count++; // adds 1 to the number of guesses.
                        textGuess.Text = "";  // clearing the input field, after the guess.
                    }
                    else
                    {
                        labelFalse.Visible = true;
                        labelFalse.Text = ("Your guess was " + guess + ".  That is too high, try again! " + answer);
                        count++; // adds 1 to the number of guesses.
                        textGuess.Text = ""; // clearing the input field, after the guess.
                    }
             }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
