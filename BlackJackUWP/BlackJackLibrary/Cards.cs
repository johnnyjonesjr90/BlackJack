using System;

namespace BlackJackLibrary
{
    public class Cards
    {
        public string[] deck = new string[] {"1","2","3","4","5","6","7","8","9","10","KING","QUEEN","JACK","ACE"};
        public string[] suit = new string[] { "CLUBS", "SPADES", "HEARTS", "DIAMONDS" };

     

        public string ShuffleAndDeal()
        {
            string result;
            Random random = new Random();
            result = deck[random.Next(0, 13)];
            return result;
        }
        public string Suitchoice()
        {
            string result;
            Random random = new Random();
            result = suit[random.Next(0, 3)];
            return result;
        }
        
    }
}
