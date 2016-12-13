namespace NowThisIsPodRacing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bgpictureBox = new System.Windows.Forms.PictureBox();
            this.Minbetlabel = new System.Windows.Forms.Label();
            this.betNamelabel = new System.Windows.Forms.Label();
            this.lukeRadioButton = new System.Windows.Forms.RadioButton();
            this.vaderRadioButton = new System.Windows.Forms.RadioButton();
            this.jarjarRadioButton = new System.Windows.Forms.RadioButton();
            this.betUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Bet_button = new System.Windows.Forms.Button();
            this.blueSpeederPictureBox = new System.Windows.Forms.PictureBox();
            this.brownSpeederPictureBox = new System.Windows.Forms.PictureBox();
            this.greenSpeederPictureBox = new System.Windows.Forms.PictureBox();
            this.redSpeederPictureBox = new System.Windows.Forms.PictureBox();
            this.racerUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lukeBetLabel = new System.Windows.Forms.Label();
            this.vaderBetLabel = new System.Windows.Forms.Label();
            this.jarjarBetLabel = new System.Windows.Forms.Label();
            this.raceButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bgpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSpeederPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownSpeederPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSpeederPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSpeederPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bgpictureBox
            // 
            this.bgpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("bgpictureBox.Image")));
            this.bgpictureBox.Location = new System.Drawing.Point(0, -2);
            this.bgpictureBox.Name = "bgpictureBox";
            this.bgpictureBox.Size = new System.Drawing.Size(814, 293);
            this.bgpictureBox.TabIndex = 0;
            this.bgpictureBox.TabStop = false;
            // 
            // Minbetlabel
            // 
            this.Minbetlabel.AutoSize = true;
            this.Minbetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minbetlabel.Location = new System.Drawing.Point(3, 294);
            this.Minbetlabel.Name = "Minbetlabel";
            this.Minbetlabel.Size = new System.Drawing.Size(104, 17);
            this.Minbetlabel.TabIndex = 1;
            this.Minbetlabel.Text = "Minimum Bet:";
            // 
            // betNamelabel
            // 
            this.betNamelabel.AutoSize = true;
            this.betNamelabel.Location = new System.Drawing.Point(12, 410);
            this.betNamelabel.Name = "betNamelabel";
            this.betNamelabel.Size = new System.Drawing.Size(46, 17);
            this.betNamelabel.TabIndex = 2;
            this.betNamelabel.Text = "label1";
            // 
            // lukeRadioButton
            // 
            this.lukeRadioButton.AutoSize = true;
            this.lukeRadioButton.Location = new System.Drawing.Point(1, 314);
            this.lukeRadioButton.Name = "lukeRadioButton";
            this.lukeRadioButton.Size = new System.Drawing.Size(127, 21);
            this.lukeRadioButton.TabIndex = 3;
            this.lukeRadioButton.TabStop = true;
            this.lukeRadioButton.Text = "Luke Skywalker";
            this.lukeRadioButton.UseVisualStyleBackColor = true;
            this.lukeRadioButton.CheckedChanged += new System.EventHandler(this.lukeRadioButton_CheckedChanged);
            // 
            // vaderRadioButton
            // 
            this.vaderRadioButton.AutoSize = true;
            this.vaderRadioButton.Location = new System.Drawing.Point(1, 341);
            this.vaderRadioButton.Name = "vaderRadioButton";
            this.vaderRadioButton.Size = new System.Drawing.Size(106, 21);
            this.vaderRadioButton.TabIndex = 4;
            this.vaderRadioButton.TabStop = true;
            this.vaderRadioButton.Text = "Darth Vader";
            this.vaderRadioButton.UseVisualStyleBackColor = true;
            this.vaderRadioButton.CheckedChanged += new System.EventHandler(this.vaderRadioButton_CheckedChanged);
            // 
            // jarjarRadioButton
            // 
            this.jarjarRadioButton.AutoSize = true;
            this.jarjarRadioButton.Location = new System.Drawing.Point(1, 369);
            this.jarjarRadioButton.Name = "jarjarRadioButton";
            this.jarjarRadioButton.Size = new System.Drawing.Size(111, 21);
            this.jarjarRadioButton.TabIndex = 5;
            this.jarjarRadioButton.TabStop = true;
            this.jarjarRadioButton.Text = "Jar Jar Binks";
            this.jarjarRadioButton.UseVisualStyleBackColor = true;
            this.jarjarRadioButton.CheckedChanged += new System.EventHandler(this.jarjarRadioButton_CheckedChanged);
            // 
            // betUpDown
            // 
            this.betUpDown.Location = new System.Drawing.Point(127, 408);
            this.betUpDown.Name = "betUpDown";
            this.betUpDown.Size = new System.Drawing.Size(62, 22);
            this.betUpDown.TabIndex = 6;
            this.betUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "credits on Landspeeder";
            // 
            // Bet_button
            // 
            this.Bet_button.Location = new System.Drawing.Point(64, 407);
            this.Bet_button.Name = "Bet_button";
            this.Bet_button.Size = new System.Drawing.Size(48, 23);
            this.Bet_button.TabIndex = 8;
            this.Bet_button.Text = "Bets";
            this.Bet_button.UseVisualStyleBackColor = true;
            this.Bet_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // blueSpeederPictureBox
            // 
            this.blueSpeederPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("blueSpeederPictureBox.Image")));
            this.blueSpeederPictureBox.Location = new System.Drawing.Point(0, 12);
            this.blueSpeederPictureBox.Name = "blueSpeederPictureBox";
            this.blueSpeederPictureBox.Size = new System.Drawing.Size(45, 31);
            this.blueSpeederPictureBox.TabIndex = 9;
            this.blueSpeederPictureBox.TabStop = false;
            // 
            // brownSpeederPictureBox
            // 
            this.brownSpeederPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("brownSpeederPictureBox.Image")));
            this.brownSpeederPictureBox.Location = new System.Drawing.Point(0, 80);
            this.brownSpeederPictureBox.Name = "brownSpeederPictureBox";
            this.brownSpeederPictureBox.Size = new System.Drawing.Size(45, 28);
            this.brownSpeederPictureBox.TabIndex = 10;
            this.brownSpeederPictureBox.TabStop = false;
            // 
            // greenSpeederPictureBox
            // 
            this.greenSpeederPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("greenSpeederPictureBox.Image")));
            this.greenSpeederPictureBox.Location = new System.Drawing.Point(0, 153);
            this.greenSpeederPictureBox.Name = "greenSpeederPictureBox";
            this.greenSpeederPictureBox.Size = new System.Drawing.Size(45, 28);
            this.greenSpeederPictureBox.TabIndex = 11;
            this.greenSpeederPictureBox.TabStop = false;
            // 
            // redSpeederPictureBox
            // 
            this.redSpeederPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("redSpeederPictureBox.Image")));
            this.redSpeederPictureBox.Location = new System.Drawing.Point(0, 234);
            this.redSpeederPictureBox.Name = "redSpeederPictureBox";
            this.redSpeederPictureBox.Size = new System.Drawing.Size(45, 29);
            this.redSpeederPictureBox.TabIndex = 12;
            this.redSpeederPictureBox.TabStop = false;
            // 
            // racerUpDown
            // 
            this.racerUpDown.Location = new System.Drawing.Point(360, 410);
            this.racerUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.racerUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.racerUpDown.Name = "racerUpDown";
            this.racerUpDown.Size = new System.Drawing.Size(42, 22);
            this.racerUpDown.TabIndex = 13;
            this.racerUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bets";
            // 
            // lukeBetLabel
            // 
            this.lukeBetLabel.AutoSize = true;
            this.lukeBetLabel.Location = new System.Drawing.Point(306, 318);
            this.lukeBetLabel.Name = "lukeBetLabel";
            this.lukeBetLabel.Size = new System.Drawing.Size(230, 17);
            this.lukeBetLabel.TabIndex = 15;
            this.lukeBetLabel.Text = "Luke Skywalker hasn\'t placed a bet";
            // 
            // vaderBetLabel
            // 
            this.vaderBetLabel.AutoSize = true;
            this.vaderBetLabel.Location = new System.Drawing.Point(306, 345);
            this.vaderBetLabel.Name = "vaderBetLabel";
            this.vaderBetLabel.Size = new System.Drawing.Size(209, 17);
            this.vaderBetLabel.TabIndex = 16;
            this.vaderBetLabel.Text = "Darth Vader hasn\'t placed a bet";
            // 
            // jarjarBetLabel
            // 
            this.jarjarBetLabel.AutoSize = true;
            this.jarjarBetLabel.Location = new System.Drawing.Point(306, 373);
            this.jarjarBetLabel.Name = "jarjarBetLabel";
            this.jarjarBetLabel.Size = new System.Drawing.Size(214, 17);
            this.jarjarBetLabel.TabIndex = 17;
            this.jarjarBetLabel.Text = "Jar Jar Binks hasn\'t placed a bet";
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(729, 373);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(86, 64);
            this.raceButton.TabIndex = 18;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 436);
            this.Controls.Add(this.raceButton);
            this.Controls.Add(this.jarjarBetLabel);
            this.Controls.Add(this.vaderBetLabel);
            this.Controls.Add(this.lukeBetLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.racerUpDown);
            this.Controls.Add(this.redSpeederPictureBox);
            this.Controls.Add(this.greenSpeederPictureBox);
            this.Controls.Add(this.brownSpeederPictureBox);
            this.Controls.Add(this.blueSpeederPictureBox);
            this.Controls.Add(this.Bet_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betUpDown);
            this.Controls.Add(this.jarjarRadioButton);
            this.Controls.Add(this.vaderRadioButton);
            this.Controls.Add(this.lukeRadioButton);
            this.Controls.Add(this.betNamelabel);
            this.Controls.Add(this.Minbetlabel);
            this.Controls.Add(this.bgpictureBox);
            this.Name = "Form1";
            this.Text = "Now This Is PodRacing!";
            ((System.ComponentModel.ISupportInitialize)(this.bgpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSpeederPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownSpeederPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSpeederPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSpeederPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bgpictureBox;
        private System.Windows.Forms.Label Minbetlabel;
        private System.Windows.Forms.Label betNamelabel;
        private System.Windows.Forms.RadioButton lukeRadioButton;
        private System.Windows.Forms.RadioButton vaderRadioButton;
        private System.Windows.Forms.RadioButton jarjarRadioButton;
        private System.Windows.Forms.NumericUpDown betUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bet_button;
        private System.Windows.Forms.PictureBox blueSpeederPictureBox;
        private System.Windows.Forms.PictureBox brownSpeederPictureBox;
        private System.Windows.Forms.PictureBox greenSpeederPictureBox;
        private System.Windows.Forms.PictureBox redSpeederPictureBox;
        private System.Windows.Forms.NumericUpDown racerUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lukeBetLabel;
        private System.Windows.Forms.Label vaderBetLabel;
        private System.Windows.Forms.Label jarjarBetLabel;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Timer timer1;
    }
}

