namespace Color_Mixer
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
            this.firstRedRadio = new System.Windows.Forms.RadioButton();
            this.firstBlueRadio = new System.Windows.Forms.RadioButton();
            this.firstYellowRadio = new System.Windows.Forms.RadioButton();
            this.secondBlueRadio = new System.Windows.Forms.RadioButton();
            this.secondRedRadio = new System.Windows.Forms.RadioButton();
            this.secondYellowRadio = new System.Windows.Forms.RadioButton();
            this.mixButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstRedRadio
            // 
            this.firstRedRadio.AutoSize = true;
            this.firstRedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.firstRedRadio.Location = new System.Drawing.Point(21, 58);
            this.firstRedRadio.Name = "firstRedRadio";
            this.firstRedRadio.Size = new System.Drawing.Size(85, 34);
            this.firstRedRadio.TabIndex = 0;
            this.firstRedRadio.TabStop = true;
            this.firstRedRadio.Text = "Red";
            this.firstRedRadio.UseVisualStyleBackColor = true;
            // 
            // firstBlueRadio
            // 
            this.firstBlueRadio.AutoSize = true;
            this.firstBlueRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.firstBlueRadio.Location = new System.Drawing.Point(21, 103);
            this.firstBlueRadio.Name = "firstBlueRadio";
            this.firstBlueRadio.Size = new System.Drawing.Size(89, 34);
            this.firstBlueRadio.TabIndex = 1;
            this.firstBlueRadio.TabStop = true;
            this.firstBlueRadio.Text = "Blue";
            this.firstBlueRadio.UseVisualStyleBackColor = true;
            // 
            // firstYellowRadio
            // 
            this.firstYellowRadio.AutoSize = true;
            this.firstYellowRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.firstYellowRadio.Location = new System.Drawing.Point(21, 149);
            this.firstYellowRadio.Name = "firstYellowRadio";
            this.firstYellowRadio.Size = new System.Drawing.Size(113, 34);
            this.firstYellowRadio.TabIndex = 2;
            this.firstYellowRadio.TabStop = true;
            this.firstYellowRadio.Text = "Yellow";
            this.firstYellowRadio.UseVisualStyleBackColor = true;
            // 
            // secondBlueRadio
            // 
            this.secondBlueRadio.AutoSize = true;
            this.secondBlueRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.secondBlueRadio.Location = new System.Drawing.Point(28, 103);
            this.secondBlueRadio.Name = "secondBlueRadio";
            this.secondBlueRadio.Size = new System.Drawing.Size(89, 34);
            this.secondBlueRadio.TabIndex = 3;
            this.secondBlueRadio.TabStop = true;
            this.secondBlueRadio.Text = "Blue";
            this.secondBlueRadio.UseVisualStyleBackColor = true;
            // 
            // secondRedRadio
            // 
            this.secondRedRadio.AutoSize = true;
            this.secondRedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.secondRedRadio.Location = new System.Drawing.Point(28, 58);
            this.secondRedRadio.Name = "secondRedRadio";
            this.secondRedRadio.Size = new System.Drawing.Size(85, 34);
            this.secondRedRadio.TabIndex = 4;
            this.secondRedRadio.TabStop = true;
            this.secondRedRadio.Text = "Red";
            this.secondRedRadio.UseVisualStyleBackColor = true;
            // 
            // secondYellowRadio
            // 
            this.secondYellowRadio.AutoSize = true;
            this.secondYellowRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.secondYellowRadio.Location = new System.Drawing.Point(28, 149);
            this.secondYellowRadio.Name = "secondYellowRadio";
            this.secondYellowRadio.Size = new System.Drawing.Size(113, 34);
            this.secondYellowRadio.TabIndex = 5;
            this.secondYellowRadio.TabStop = true;
            this.secondYellowRadio.Text = "Yellow";
            this.secondYellowRadio.UseVisualStyleBackColor = true;
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(147, 276);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(149, 48);
            this.mixButton.TabIndex = 6;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(334, 276);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(149, 48);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstRedRadio);
            this.groupBox1.Controls.Add(this.firstBlueRadio);
            this.groupBox1.Controls.Add(this.firstYellowRadio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox1.Location = new System.Drawing.Point(63, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 225);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the First Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.secondBlueRadio);
            this.groupBox2.Controls.Add(this.secondRedRadio);
            this.groupBox2.Controls.Add(this.secondYellowRadio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox2.Location = new System.Drawing.Point(426, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 225);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select the Second Color";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(519, 276);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(149, 48);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 354);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mixButton);
            this.Name = "Form1";
            this.Text = "Color Mixer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton firstRedRadio;
        private System.Windows.Forms.RadioButton firstBlueRadio;
        private System.Windows.Forms.RadioButton firstYellowRadio;
        private System.Windows.Forms.RadioButton secondBlueRadio;
        private System.Windows.Forms.RadioButton secondRedRadio;
        private System.Windows.Forms.RadioButton secondYellowRadio;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button resetButton;
    }
}

