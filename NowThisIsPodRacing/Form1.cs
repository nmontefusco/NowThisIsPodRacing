using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NowThisIsPodRacing
{
    public partial class Form1 : Form
    {
        Landspeeder[] Racers = new Landspeeder[4];
        Guy[] Guys = new Guy[3];
        Random Randomizer = new Random();
        
        public Form1()
        {
            InitializeComponent();
            
            //declaring arrays and setting picturebox transparency
            Racers[0] = new Landspeeder()
            {
                Mypicturebox = blueSpeederPictureBox,
                startingPosition = blueSpeederPictureBox.Left,
                racetrackLength = bgpictureBox.Width - blueSpeederPictureBox.Width,
                Randomizer = Randomizer
            };
            
            blueSpeederPictureBox.Parent = bgpictureBox;
            blueSpeederPictureBox.BackColor = Color.Transparent;

            Racers[1] = new Landspeeder()
            {
                Mypicturebox = brownSpeederPictureBox,
                startingPosition = brownSpeederPictureBox.Left,
                racetrackLength = bgpictureBox.Width - brownSpeederPictureBox.Width,
                Randomizer = Randomizer
            };

            brownSpeederPictureBox.Parent = bgpictureBox;
            brownSpeederPictureBox.BackColor = Color.Transparent;

            Racers[2] = new Landspeeder()
            {
                Mypicturebox = greenSpeederPictureBox,
                startingPosition = greenSpeederPictureBox.Left,
                racetrackLength = bgpictureBox.Width - greenSpeederPictureBox.Width,
                Randomizer = Randomizer
            };

            greenSpeederPictureBox.Parent = bgpictureBox;
            greenSpeederPictureBox.BackColor = Color.Transparent;

            Racers[3] = new Landspeeder()
            {
                Mypicturebox = redSpeederPictureBox,
                startingPosition = redSpeederPictureBox.Left,
                racetrackLength = bgpictureBox.Width - redSpeederPictureBox.Width,
                Randomizer = Randomizer
            };

            redSpeederPictureBox.Parent = bgpictureBox;
            redSpeederPictureBox.BackColor = Color.Transparent;

            //Declaring guy Array, and updating labels to reflect their respective fields
            Guys[0] = new Guy() { Name = "Luke Skywalker", Cash = 50, MyRadioButton = lukeRadioButton, MyLabel = lukeBetLabel};
            Guys[1] = new Guy() { Name = "Darth Vader", Cash = 75, MyRadioButton = vaderRadioButton, MyLabel = vaderBetLabel };
            Guys[2] = new Guy() { Name = "Jar Jar Binks", Cash = 40, MyRadioButton = jarjarRadioButton, MyLabel = jarjarBetLabel };

            lukeRadioButton.Text = "Luke Skywalker has 50 credits.";
            vaderRadioButton.Text = "Darth Vader has 75 credits.";
            jarjarRadioButton.Text = "Jar Jar Binks has 40 credits.";
            refreshGuybet();
        }
       
        
        private void lukeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            betNamelabel.Text = "Luke";
        }

        private void vaderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            betNamelabel.Text = "Vader";
        }

        private void jarjarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            betNamelabel.Text = "Jar Jar";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Minbetlabel.Text = "Minimum Bet: " + betUpDown.Value;
        }
        //Timer controls movement behavior as well as the win condition of the game.
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0,j=Racers.Length; i<j; i++)
            {
                Racers[i].Run();

                if (Racers[i].Run() == true)
                {
                    timer1.Stop();
                    int Winner=i+1;
                    MessageBox.Show("Landspeeder "+ Winner + " has won the race");
                    for (int p = 0,q= Guys.Length; p<q; p++)
                    {
                        Guys[p].Collect(Winner);
                    }
                    restartRacers();
                    refreshGuybet();
                }
            }
            
        }

        //sets racers back to starting position.
        public void restartRacers()
        {
            for (int i = 0,j=Racers.Length; i<j; i++)
            {
                Racers[i].TakeStartingPosition();
                
            }
            
        }
        //loop to set bets to zero
        public void refreshGuybet()
        {
            for (int i = 0,j=Guys.Length; i<j; i++)
            {
                Guys[i].ClearBet();
            }
            
        }
        private void raceButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checks if labels are checked, sets bet, updates labels
            if (lukeRadioButton.Checked)
            {
                Guys[0].PlaceBet((int)betUpDown.Value, (int)racerUpDown.Value);
                Guys[0].UpdateLabels();
            }
            if (vaderRadioButton.Checked)
            {
                Guys[1].PlaceBet((int)betUpDown.Value, (int)racerUpDown.Value);
                Guys[1].UpdateLabels();
            }
            if (jarjarRadioButton.Checked)
            {
                Guys[2].PlaceBet((int)betUpDown.Value, (int)racerUpDown.Value);
                Guys[2].UpdateLabels();
            }
        }
                
                   
                
                
                
                
                    
                
                    
            
        
    }
}
