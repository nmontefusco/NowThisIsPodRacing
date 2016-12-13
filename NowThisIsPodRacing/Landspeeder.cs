using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NowThisIsPodRacing
{
  public class Landspeeder
    {
        public int startingPosition;
        public int racetrackLength;
        public PictureBox Mypicturebox = null;
        public int Location;
        public Random Randomizer;

        //moves Racers and returns true if speeder hits "finishline"
        public bool Run()
        {
            Location += Randomizer.Next(1, 4);
            Mypicturebox.Left = startingPosition + Location;
                  
            if (Location >= racetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
         }
        //Reset starting posistion.
        public void TakeStartingPosition()
        {
            
            Location = 0;
            Mypicturebox.Left = 0;
        }
    }
}
