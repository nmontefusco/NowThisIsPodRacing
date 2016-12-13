using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NowThisIsPodRacing
{
    public class Bet
    {
        public int Amount;
        public int Racer;
        public Guy Bettor;

        public string GetDescription()
        {
            string description = Bettor.Name + " has placed " + Amount + " credits on racer " + Racer;
            if (Amount<=0)
            {
                description = Bettor.Name + " hasn't placed a bet.";
                return description;
            }
            else
            {
                return description;
            }
        }

        public int PayOut(int Winner)
        {
            if (Racer == Winner)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
        
            

    }
}
