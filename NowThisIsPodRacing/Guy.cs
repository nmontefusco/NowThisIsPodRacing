using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NowThisIsPodRacing
{
  public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + " has " + Cash + " Credits";
        }
        //clears bet fields, without null object reference. (Everyone intially places a Mybet)
        public void ClearBet()
        {
            PlaceBet(0, 0);
            MyLabel.Text = Name + " hasn't placed a bet";
            
        }
        //place a bet and store it in mybet
        public bool PlaceBet(int BetAmount, int RacerToWin)
        {
           
            if (Cash>=BetAmount)
            {
                MyBet = new Bet() { Amount = BetAmount, Racer = RacerToWin, Bettor = this };
                UpdateLabels();
                return true;
            }
            else
            {
                MessageBox.Show("Come back when you have some more money, buddy!");
                return false;
                
            }
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            UpdateLabels();
        }
    }
}
