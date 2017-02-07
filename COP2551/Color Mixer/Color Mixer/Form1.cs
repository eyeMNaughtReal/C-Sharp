using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Mixer
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
          * Project 3
          */

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            if (firstYellowRadio.Checked && secondYellowRadio.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else if (firstYellowRadio.Checked && secondRedRadio.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (firstYellowRadio.Checked && secondBlueRadio.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (firstRedRadio.Checked && secondRedRadio.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (firstRedRadio.Checked && secondBlueRadio.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (firstRedRadio.Checked && secondYellowRadio.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (firstBlueRadio.Checked && secondBlueRadio.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (firstBlueRadio.Checked && secondRedRadio.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (firstBlueRadio.Checked && secondYellowRadio.Checked)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            firstRedRadio.Checked = false;
            firstBlueRadio.Checked = false;
            firstYellowRadio.Checked = false;
            secondRedRadio.Checked = false;
            secondBlueRadio.Checked = false;
            secondYellowRadio.Checked = false;
        }
    }
}
