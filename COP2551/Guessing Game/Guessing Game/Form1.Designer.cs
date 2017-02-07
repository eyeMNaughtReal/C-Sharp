namespace Guessing_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textGuess = new System.Windows.Forms.TextBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelFalse = new System.Windows.Forms.Label();
            this.labelRandomNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelQuestion.Location = new System.Drawing.Point(82, 42);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(354, 30);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Guess a number from 1 - 100:";
            // 
            // textGuess
            // 
            this.textGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textGuess.Location = new System.Drawing.Point(203, 91);
            this.textGuess.Name = "textGuess";
            this.textGuess.Size = new System.Drawing.Size(101, 41);
            this.textGuess.TabIndex = 1;
            this.textGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonGuess
            // 
            this.buttonGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonGuess.Location = new System.Drawing.Point(142, 267);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(109, 56);
            this.buttonGuess.TabIndex = 2;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonExit.Location = new System.Drawing.Point(284, 267);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(109, 56);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelFalse
            // 
            this.labelFalse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelFalse.Location = new System.Drawing.Point(21, 153);
            this.labelFalse.Name = "labelFalse";
            this.labelFalse.Size = new System.Drawing.Size(492, 93);
            this.labelFalse.TabIndex = 4;
            this.labelFalse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFalse.Visible = false;
            // 
            // labelRandomNum
            // 
            this.labelRandomNum.Location = new System.Drawing.Point(39, 91);
            this.labelRandomNum.Name = "labelRandomNum";
            this.labelRandomNum.Size = new System.Drawing.Size(102, 41);
            this.labelRandomNum.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 379);
            this.Controls.Add(this.labelRandomNum);
            this.Controls.Add(this.labelFalse);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.textGuess);
            this.Controls.Add(this.labelQuestion);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox textGuess;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelFalse;
        private System.Windows.Forms.Label labelRandomNum;
    }
}

