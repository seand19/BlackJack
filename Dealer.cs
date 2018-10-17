using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer : Setup
    {
        int handSum; // dealer sum
        int cardCount = 0;
        public int card1; // downcard
        public int card2; // upcard
        public void AceConvert(int x) //Ace enum conversion if applicable
        {
            if (card1 == 11)
            {
                if (handSum > 21 && (handSum - 10) < 21)
                {
                    card1 = 1;
                    handSum -= 10;
                }
            }
            else if (card2 == 11)
            {
                if (handSum > 21 && (handSum - 10) < 21)
                {
                    card2 = 1;
                    handSum -= 10;
                }
            }
            else if (x == 11)
            {
                if (handSum > 21 && (handSum - 10) < 21)
                {
                    card2 = 1;
                    handSum -= 10;
                }
            }             
        }
        public void Hit()
        {
            while (handSum < 17 && handSum > 0)
            {
                int x = NewCard();
                Console.WriteLine();
                Console.WriteLine("Dealer drew a {0}", x);
                handSum += x;
                AceConvert(x);
                if (handSum > 21)
                {
                    Console.WriteLine("Dealer Busted You Win ");
                    handSum = 0;
                }
                if (handSum != 0)
                    HandSum();
            }
        }
        public bool BlackKJackCheck()
        {
            if (cardCount == 2)
            {
                if (handSum == 21)
                {
                    Console.WriteLine("dealer was hiding a {0}", card1);
                    Console.WriteLine("Dealer has BlackJack you lose");
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        public int GetDealerHandSum()
        {
            return handSum;
        }
        public void HandSum()
        {
            Console.WriteLine("The dealer has {0} ", handSum);
        }
        public Dealer()
        {
            cardCount += 2;
            card1 = NewCard();
            card2 = NewCard();
            handSum = card1 + card2;
            Console.WriteLine("The dealer is showing a {0} ", card2);

        }
    }
}
