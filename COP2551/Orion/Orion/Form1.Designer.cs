namespace Orion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showStars = new System.Windows.Forms.Button();
            this.hideStars = new System.Windows.Forms.Button();
            this.betelgeuseLabel = new System.Windows.Forms.Label();
            this.meissaLabel = new System.Windows.Forms.Label();
            this.alnitakLabel = new System.Windows.Forms.Label();
            this.alnilamLabel = new System.Windows.Forms.Label();
            this.mintakaLabel = new System.Windows.Forms.Label();
            this.saiphLabel = new System.Windows.Forms.Label();
            this.rigelLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 625);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // showStars
            // 
            this.showStars.Location = new System.Drawing.Point(60, 677);
            this.showStars.Name = "showStars";
            this.showStars.Size = new System.Drawing.Size(136, 47);
            this.showStars.TabIndex = 1;
            this.showStars.Text = "Display Names";
            this.showStars.UseVisualStyleBackColor = true;
            this.showStars.Click += new System.EventHandler(this.showStars_Click);
            // 
            // hideStars
            // 
            this.hideStars.Location = new System.Drawing.Point(275, 677);
            this.hideStars.Name = "hideStars";
            this.hideStars.Size = new System.Drawing.Size(136, 47);
            this.hideStars.TabIndex = 2;
            this.hideStars.Text = "Hide Names";
            this.hideStars.UseVisualStyleBackColor = true;
            this.hideStars.Click += new System.EventHandler(this.hideStars_Click);
            // 
            // betelgeuseLabel
            // 
            this.betelgeuseLabel.Location = new System.Drawing.Point(123, 64);
            this.betelgeuseLabel.Name = "betelgeuseLabel";
            this.betelgeuseLabel.Size = new System.Drawing.Size(91, 21);
            this.betelgeuseLabel.TabIndex = 3;
            this.betelgeuseLabel.Text = "Betelgeuse";
            this.betelgeuseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.betelgeuseLabel.Visible = false;
            // 
            // meissaLabel
            // 
            this.meissaLabel.Location = new System.Drawing.Point(430, 108);
            this.meissaLabel.Name = "meissaLabel";
            this.meissaLabel.Size = new System.Drawing.Size(64, 24);
            this.meissaLabel.TabIndex = 4;
            this.meissaLabel.Text = "Meissa";
            this.meissaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.meissaLabel.Visible = false;
            // 
            // alnitakLabel
            // 
            this.alnitakLabel.Location = new System.Drawing.Point(161, 334);
            this.alnitakLabel.Name = "alnitakLabel";
            this.alnitakLabel.Size = new System.Drawing.Size(62, 22);
            this.alnitakLabel.TabIndex = 5;
            this.alnitakLabel.Text = "Alnitak";
            this.alnitakLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alnitakLabel.Visible = false;
            // 
            // alnilamLabel
            // 
            this.alnilamLabel.Location = new System.Drawing.Point(282, 292);
            this.alnilamLabel.Name = "alnilamLabel";
            this.alnilamLabel.Size = new System.Drawing.Size(62, 20);
            this.alnilamLabel.TabIndex = 6;
            this.alnilamLabel.Text = "Alnilam";
            this.alnilamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alnilamLabel.Visible = false;
            // 
            // mintakaLabel
            // 
            this.mintakaLabel.Location = new System.Drawing.Point(390, 292);
            this.mintakaLabel.Name = "mintakaLabel";
            this.mintakaLabel.Size = new System.Drawing.Size(67, 20);
            this.mintakaLabel.TabIndex = 7;
            this.mintakaLabel.Text = "Mintaka";
            this.mintakaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mintakaLabel.Visible = false;
            // 
            // saiphLabel
            // 
            this.saiphLabel.Location = new System.Drawing.Point(161, 551);
            this.saiphLabel.Name = "saiphLabel";
            this.saiphLabel.Size = new System.Drawing.Size(53, 22);
            this.saiphLabel.TabIndex = 8;
            this.saiphLabel.Text = "Saiph";
            this.saiphLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saiphLabel.Visible = false;
            // 
            // rigelLabel
            // 
            this.rigelLabel.Location = new System.Drawing.Point(430, 509);
            this.rigelLabel.Name = "rigelLabel";
            this.rigelLabel.Size = new System.Drawing.Size(46, 23);
            this.rigelLabel.TabIndex = 9;
            this.rigelLabel.Text = "Rigel";
            this.rigelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rigelLabel.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(490, 677);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(136, 47);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 782);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rigelLabel);
            this.Controls.Add(this.saiphLabel);
            this.Controls.Add(this.mintakaLabel);
            this.Controls.Add(this.alnilamLabel);
            this.Controls.Add(this.alnitakLabel);
            this.Controls.Add(this.meissaLabel);
            this.Controls.Add(this.betelgeuseLabel);
            this.Controls.Add(this.hideStars);
            this.Controls.Add(this.showStars);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Orion Constellation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button showStars;
        private System.Windows.Forms.Button hideStars;
        private System.Windows.Forms.Label betelgeuseLabel;
        private System.Windows.Forms.Label meissaLabel;
        private System.Windows.Forms.Label alnitakLabel;
        private System.Windows.Forms.Label alnilamLabel;
        private System.Windows.Forms.Label mintakaLabel;
        private System.Windows.Forms.Label saiphLabel;
        private System.Windows.Forms.Label rigelLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

