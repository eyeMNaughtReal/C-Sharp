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
        private int count = 0; // count variable is generated and assigned a default value of 1

        public Form1()
        {
            InitializeComponent();
            answer = rand.Next(100) + 1;  //initializing the random number, giving it a range of 1-100
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            try
            {
                guess = Convert.ToInt32(textGuess.Text);  //converts text guess, to numerical guess.

                if (guess < answer) //if answer doesn't match guess, then it goes through this loop
                {
                    labelStatus.Visible = true;  //enables label visability
                    labelStatus.ForeColor = System.Drawing.Color.Red;   //changes font color to red
                    labelStatus.Text = ("Your guess was " + guess + ".  That is too low, try again! " + answer);
                    count++; // adds 1 to the number of guesses.
                    textGuess.Text = "";  // clearing the input field, after the guess.
                }
                else
                {
                    labelStatus.Visible = true;  //enables label visability
                    labelStatus.ForeColor = System.Drawing.Color.Red;  //changes font color to red
                    labelStatus.Text = ("Your guess was " + guess + ".  That is too high, try again! " + answer);
                    count++; // adds 1 to the number of guesses.
                    textGuess.Text = ""; // clearing the input field, after the guess.
                }
                while (guess == answer)  // if answer matches guess, then it proceeds to here and enables the game to continue
                {
                    labelStatus.Visible = true;  //enables label visability
                    labelStatus.ForeColor = System.Drawing.Color.Green; //changes font color to green
                    labelStatus.Text = ("Congratulations!  You got it on your " + count + " guess.");
                    count = 0; //resets guess count to 0;
                    answer = rand.Next(100) + 1;  //after correctly guessing, gives new random number
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
