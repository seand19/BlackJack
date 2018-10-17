using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Hand : Setup
    {
        //variables
        List<int> hand = new List<int>();
        int handSum;
        int cardCount = 0;
        int card1;
        int card2;

        //functions
        void Hit(string action) //standard hit
        {
            while (action == "hit" && handSum > 0)
            {
                int x = NewCard();
                Console.WriteLine("You drew a {0}", x);
                handSum += x;
                hand.Add(x);
                AceConvert(x);
                cardCount++;
                if (handSum > 21)
                {
                    Console.WriteLine("You Busted ");
                    handSum = 0;
                    break;
                }
                HandSum();
                Console.WriteLine("Hit again or stay");
                action = Console.ReadLine();
            }
        }
        void DoubleDown() //double the bet and only get one card
        {
            int x = NewCard();  
            Console.WriteLine("You drew a {0}", x);
            handSum += x;
            hand.Add(x);
            AceConvert(x);
            cardCount++;
            if (handSum > 21)
            {
                Console.WriteLine("You Busted ");
                handSum = 0;
            }
            if (handSum != 0)
                HandSum();
        }
        public void Action(string action)
        {
            switch (action)
            {
                case "hit":
                    Hit(action);
                    break;
                case "double":
                    DoubleDown();
                    break;
                case "surrender":
                    handSum = 0;
                    break;
                case "stay":
                    break;
                case "split":
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
        public Hand Split(bool check)
        {
            hand.RemoveAt(0);
            int splitcard = NewCard();
            card1 = splitcard;
            hand.Add(splitcard);
            CalcHandSum();
            Console.WriteLine("Your first hand has {0} and {1}", splitcard, card2);
            return new Hand(card2);

        } //splits by creating a second player with different constructor
        public bool CheckSplit()
        {
            if (cardCount == 2)
            {
                if (card1 == card2)
                    return true;
                else
                    return false;
            }
            else
                return false;
        } //check if split is possible returns the bool
        public bool BlackJackCheck()
        {
            if (cardCount == 2)
            {
                if (handSum == 21)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        } //checks for BlackJack
        public bool SoftCheck()
        {
            if (card1 == 11 || card2 == 11)
                return true;
            else
                return false;
        }
        public void AceConvert(int x)
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
                    int index = hand.IndexOf(11);
                    hand[index] = 1;
                    CalcHandSum();
                }
            }
        }
        public void HandSum()
        {
            Console.WriteLine("You have a total of {0} ", handSum);
        }
        private void CalcHandSum()
        {
            handSum = 0;
            foreach (int card in hand)
            {
                handSum += card;
            }
        }
        public int GetPlayerHandSum()
        {
            return handSum;
        }
        public Hand ()
        {
            card1 = NewCard();
            card2 = NewCard();
            //card1 = 11;
            //card2 = 11;
            cardCount += 2;
            AceConvert(card2);
            hand.Add(card1);
            hand.Add(card2);
            handSum = card1 + card2;
            Console.WriteLine("Your cards are {0} and {1}", card1, card2);
        }
        public Hand( int c)
        {
            card1 = NewCard();
            card2 = c;
            cardCount += 2;
            hand.Add(card1);
            hand.Add(card2);
            handSum = card1 + card2;
            Console.WriteLine("Your Second hand is {0} and {1}", card1, card2);
        }
    }
}
