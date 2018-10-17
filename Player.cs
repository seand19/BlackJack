using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player 
    {
        //variables
        double bet;
        double bet2;
        private double chipTotal = 100;
        public double ChipTotal
        {
            get { return chipTotal; }
        }
        public int handCount = 0;
        public List<Hand> hands = new List<Hand>();
        public void AddHand( Hand hand)
        {
            hands.Add(hand);
            chipTotal -= bet;
            handCount++;
            if (handCount == 2)
                bet2 = bet;
        }
        public void RemoveHands()
        {
            for(int i = 0; i<handCount ;)
            {
                hands.RemoveAt(i);
                handCount--;
            }
        }
        //functions
        public void Win()
        {
            chipTotal += 2 * bet;
            Console.WriteLine("You won your hand");
        } 
        public void Win(int x)
        {
            string output;
            if (x == 1 && handCount > 1)
                output = "1st ";
            else if (x == 2 && handCount > 1)
                output = "2nd ";
            else
                output = "";
            Console.WriteLine("You won your {0}hand", output);
            if (x == 1)
                chipTotal += 2 * bet;
            else
                chipTotal += 2 * bet2;
        }
        public void Lose()
        {
            Console.WriteLine("You lost your hand");
        } 
        public void Lose(int x)
        {
            string output;
            if (x == 1 && handCount > 1)
                output = "1st ";
            else if (x == 2 && handCount > 1)
                output = "2nd ";
            else
                output = "";
            Console.WriteLine("You lost your {0}hand", output);
        }
        public void Draw()
        {
            chipTotal += bet;
            Console.WriteLine("Draw!");
        }
        public void Draw(int x)
        {
            string output;
            if (x == 1 && handCount > 1)
                output = "1st ";
            else if (x == 2 && handCount > 1)
                output = "2nd ";
            else
                output = "";
            Console.WriteLine("You drew your {0}hand", output);
            if (x == 1)
                chipTotal += bet;
            else
                chipTotal += bet2;
        }
        public void BlackJack(int x)
        {
            string output;
            if (x == 1 && handCount == 1)
                Console.WriteLine("You got BlackJack, Nice!");
            else if (x == 1 && handCount > 1)
            {
                output = "1st ";
                Console.WriteLine("Your {0}hand made BlackJack", output);
            }
            else if (x == 2 && handCount > 1)
            {
                output = "2nd ";
                Console.WriteLine("Your {0}hand made BlackJack", output);
            }
                if (x == 1)
            {
                chipTotal += 1.5 * bet + bet ;
            }
            else
                chipTotal += 1.5 * bet2 + bet2;
        }
        public void Surrender()
        {
            chipTotal += bet/2;
            Console.WriteLine("You gave up... you get half back");
        } //get back half your bet cause your gonna lose 
        public void Bet()
        {
            Console.WriteLine("Place a bet");
            while (true)
            {
                try
                {
                    bet = Convert.ToDouble(Console.ReadLine());
                    if (bet > chipTotal)
                    {
                        Console.WriteLine("Bet must be smaller than {0}", chipTotal+1);
                        continue;
                    }
                    else
                        break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid plz put in a numeric bet");
                }
                catch (Exception e)
                {
                    Console.WriteLine("An unknown error occured");
                }
            }
        }
        public void DoubleBet(int x )//on double down or split
        {
            if (x == 1)
            {
                chipTotal -= bet;
                bet *= 2;
            }
            else
            {
                chipTotal -= bet2;
                bet2 *= 2;
            }
        }
    }
}
