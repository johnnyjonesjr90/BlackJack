using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackLibrary
{
    public class Logic
    {
        public string HitStay()
        {
            return "(1) Hit or (2) Stay?\n\nChoose and then Press Enter";
        }
        public string Bust()
        {
            return "Sorry you busted\n\nPress Enter";
        }
        public string Hit21()
        {
            return "Congrats!!! you hit 21\n\nPress Enter";
        }
        public int Convert(string card, int total)
        {
            int trans;
            if (card == "KING" || card == "QUEEN" || card == "JACK")
            {
                trans = 10;
                return trans;
            }
            if (card == "ACE")
            {
                if (11 + total > 21)
                {
                    trans = 1;
                    return trans;
                }
                trans = 11;
                return trans;
            }
            else
            {
                trans = Int32.Parse(card);
                return trans;
            }
        }

    }
}
