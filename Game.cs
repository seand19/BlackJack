using System;

namespace BlackJack
{
    class Game
    {
        static void HardTotal(int pSum, int upCard, string action)
        {
            if (pSum >= 17 && action != "stay")
                Console.WriteLine(" The Book says to stay at 17 or above! ");
            
            //pSum < 9
            else if (pSum <= 8 && action != "hit")
                Console.WriteLine("The Book says to hit on anything 8 and below! ");
            //pSum = 9
            else if (pSum == 9 && (upCard == 2 || upCard >= 7) && action != "hit")
                Console.WriteLine("The Book says to hit on 9 if upcard is 2 or 7 and up! ");
            else if (pSum == 9 && (upCard >= 3 && upCard <= 6) && action != "double")
                Console.WriteLine("The Book says to double on 9 if upcard is between 3 and 6! ");
            //pSum = 10
            else if (pSum == 10 && upCard <= 9 && action != "double")
                Console.WriteLine("The Book says to double on 10 if upcard is 9 or below! ");
            else if (pSum == 10 && upCard >= 10 && action != "hit")
                Console.WriteLine("The Book says to hit on 10 if upcard is 10 and up! ");
            //pSum = 11
            else if (pSum == 11 && upCard <= 10 && action != "double")
                Console.WriteLine("The Book says to double on 11 if upcard is 10 or below! ");
            else if (pSum == 11 && upCard == 11 && action != "hit")
                Console.WriteLine("The Book says to hit on 11 if upcard is an Ace! ");
            //pSum = 12
            else if (pSum == 12 && (upCard >= 4 && upCard <= 6) && action != "stay")
                Console.WriteLine("The Book says to stay on 12 if upcard is between 4 and 6! ");
            else if (pSum == 12 && ((upCard >= 2 && upCard <= 3) || upCard >= 7) && action != "hit")
                Console.WriteLine("The Book says to hit on 12 if upcard is 2,3, 7 or greater! ");
            //pSum = 13 to 16
            else if ((pSum >= 13 && pSum <= 16) && (upCard <= 6) && action != "stay")
                Console.WriteLine("The Book says to stay on 13 to 16 if upcard is between 2 and 6! ");
            else if ((pSum >= 13 && pSum <= 16) && (upCard >= 7) && action != "hit")
                Console.WriteLine("The Book says to hit on 13 to 16 if upcard is 7 or greater! ");
        }
        static void SofTotal(int pSum, int upCard, string action)
        {
            //pSum 19 or greater
            if (pSum >= 19 && action != "stay")
                Console.WriteLine("The Book says to stay at 19 or above with a soft hand ");
            //pSum 13 or 14
            else if ((pSum == 13 || pSum == 14) && (upCard <= 4 || upCard >= 7) && action != "hit")
                Console.WriteLine("The Book says to hit on a soft 13 or 14 when dealer doesn't show a 5 or 6");
            else if ((pSum == 13 || pSum == 14) && (upCard == 6 || upCard == 5) && action != "double")
                Console.WriteLine("The Book says to double on a soft 13 or 14 when dealer shows a 5 or 6");
            //pSum 15 or 16
            else if ((pSum == 15 || pSum == 16) && (upCard <= 3 || upCard >= 7) && action != "hit")
                Console.WriteLine("The Book says to hit on a soft 13 or 14 when dealer doesn't show a 4, 5 or 6");
            else if ((pSum == 15 || pSum == 16) && (upCard >= 4 && upCard <= 6) && action != "double")
                Console.WriteLine("The Book says to double on a soft 13 or 14 when dealer shows a 4, 5 or 6");
            //pSum 17 
            else if (pSum == 17 && (upCard == 2 || upCard >= 7) && action != "hit")
                Console.WriteLine("The Book says to hit on a soft 17 when dealer shows a 2, or 7 and up");
            else if (pSum == 17 && (upCard >= 3 && upCard <= 6) && action != "double")
                Console.WriteLine("The Book says to double on a soft 17 when dealer shows between a 3 and 6");
            //pSum 18 
            else if (pSum == 18 && upCard >= 9 && action != "hit")
                Console.WriteLine("The Book says to hit on a soft 18 when dealer shows a 9 or greater");
            else if (pSum == 18 && (upCard >= 3 && upCard <= 6) && action != "double")
                Console.WriteLine("The Book says to double on a soft 18 when dealer shows between a 3 and 6");
            else if (pSum == 18 && (upCard == 2 || upCard == 7 || upCard == 8) && action != "stay")
                Console.WriteLine("The book says to stay on soft 18 when dealer shows a 2,7 or 8");
        }
        static void Split(int pSum, int upCard, string action, bool aceCheck)
        {
            //pSum = 4 and 6
            if ((pSum == 4 || pSum == 6) && upCard <= 7 && action != "split")
            {
                Console.WriteLine("the book says to split 2's or 3's if upcard is 7 or below ");
            }
            else if ((pSum == 4 || pSum == 6) && upCard >= 8 && action != "hit")
                Console.WriteLine("The book says to hit if upcard is 8 or more when you have 2's or 3's");
            //pSum = 8
            else if (pSum == 8 && (upCard == 5 || upCard == 6) && action != "split")
                Console.WriteLine("the book says to split 4's against 5 or 6");
            else if (pSum == 8 && (upCard <= 4 || upCard >= 7) && action != "hit")
                Console.WriteLine("The book says to hit on 4's unless against a 5 or 6");
            //pSum = 10 or 20
            else if ((pSum == 10 || pSum == 20) && action == "split")
                Console.WriteLine("You should never split 5's or 10's");
            //pSum = 12
            else if (pSum == 12)
            {
                if (aceCheck)
                {
                    if (action != "split")
                        Console.WriteLine("Always split Ace's!");
                }
                else if (upCard <= 6 && action != "split")
                    Console.WriteLine("The book says you should split 6's if you face a 6 or below");
                else if (upCard >= 7 && action != "hit")
                    Console.WriteLine("The book says to hit on 6's if upcard is 7 or above");
            }
            //pSum = 14
            else if (pSum == 14 && upCard <= 7 && action != "split")
                Console.WriteLine("The book says to split 7's if upcard is 7 or below");
            else if (pSum == 14 && upCard >= 8 && action != "hit")
                Console.WriteLine("The book says to hit on 7's if upcard is 8 or above");
            //pSum = 16
            else if (pSum == 16 && action != "split")
                Console.WriteLine("Always split 8's");
            //pSum = 18
            else if (pSum == 18 && (upCard <= 6 || upCard == 8 || upCard == 9) && action != "split")
                Console.WriteLine("The book says to split 9's against 6 and below or 8, or 9");
            else if (pSum == 18 && (upCard == 7 || upCard >= 10) && action != "stay")
                Console.WriteLine("You should stay with 9's against a 7, 10 or Ace");
        }
        public static void Stradegy(int pSum, int upCard, string action, bool softCheck , bool splitCheck)
        {
            //pSum == player sum
            //upcard == dealer upcard
            //action == action taken and is then evaluated to see if correction should be said in console window
            //acecheck goes to softtotal
            //splitcheck goes to split
            //pSum > 17 
            if (splitCheck)
            {
                Split(pSum, upCard, action, softCheck);
            }
            else if (softCheck)
            {
                SofTotal(pSum, upCard, action);
            }
            else
            {
                HardTotal(pSum, upCard, action);
            }
        }
        public static string EndGameCheck()
        {
            string check = "";
            do
            {
                Console.WriteLine("Do you want to play another hand?(yes/no)");
                check = Console.ReadLine();
            } while (check != "yes" && check != "no");
            Console.WriteLine();
            return check;
        }
        public static bool MoneyCheck(double chips)
        {
            Console.WriteLine("You have {0} chips left", chips);
            if (chips == 0)
            {
                Console.WriteLine("out of money");
                Console.ReadKey();
                return true;
            }
            else
                return false;
        }
        static void Main(string[] args) 
        {
            //intro
            Console.WriteLine("Welcome to Blackjack where the goal is to get as close to 21 as possible.");
            Console.WriteLine("This game is meant to help teach basic stradegy");
            Console.WriteLine("If a bad/ weird move is made it will tell you the recommended play");
            Console.WriteLine("Good Luck and Have fun learning how to play Blackjack");
            Console.WriteLine();
            string response; //stops game if false
            Player player = new Player();   //create player
            Console.WriteLine("You will start off with {0} chips", player.ChipTotal);

            //player is sitting at table until he wants to end the session
            do
            {
                //create dealer and hand
                response = "";
                player.Bet();
                Hand H1 = new Hand();
                player.AddHand(H1);
                Dealer dealer = new Dealer();

                //dealer BlackJack
                if (dealer.BlackKJackCheck())
                {
                    player.Lose();
                    player.RemoveHands();// adjust player back to no hands and ends the round
                    if (MoneyCheck(player.ChipTotal))
                        break;
                    response = EndGameCheck();
                    continue;
                }

                for (int i = 0; i < player.handCount; i++) //iterate throught player hands
                {
                    if (i > 0)
                        Console.WriteLine("Your second hand has {0}", player.hands[i].GetPlayerHandSum());

                    //Player BlackJack
                    if (player.hands[i].BlackJackCheck()) 
                    {
                        player.BlackJack(i + 1);
                        if (player.handCount == 1 || (player.handCount == 2 && i == 1 && player.hands[0].BlackJackCheck() && player.hands[1].BlackJackCheck()))
                        {
                            Console.WriteLine("You have {0} chips left", player.ChipTotal);
                            response = EndGameCheck();
                            continue;
                        }
                        else
                            continue;
                    }
                    string handNum = "";
                    if (player.handCount > 1)
                    {
                        if (i == 0)
                            handNum = "First hand ... ";
                        else if (i == 1)
                            handNum = "Second hand ... ";
                    }
                    if (player.handCount > 1)
                        Console.WriteLine("{0}You can hit, double, split, stay", handNum);
                    else
                        Console.WriteLine("You can hit, double, split, stay, surrender");
                    string action = Console.ReadLine();
                    Stradegy(player.hands[i].GetPlayerHandSum(), dealer.card2, action, player.hands[i].SoftCheck(), player.hands[i].CheckSplit());
                    player.hands[i].Action(action);
                    if (action == "surrender")
                    {
                        player.Surrender();
                        Console.WriteLine("You have {0} chips left", player.ChipTotal);
                        response = EndGameCheck();
                        continue;
                    }

                    //split hand 
                    if (action == "split")
                    {
                        Hand H2 = player.hands[i].Split(player.hands[i].CheckSplit());
                        player.AddHand(H2);
                        i--;
                        continue;
                    }

                    //double bet
                    if (action == "double")
                        player.DoubleBet(i + 1);

                    //if player bust exit / continue
                    if (player.handCount > 1 && player.hands[i].GetPlayerHandSum() == 0)
                    {
                        if ( i == 0)
                        {
                            continue;
                        }
                        else if (i == 1)
                        {
                            break;
                        }
                    }
                    else if (player.hands[i].GetPlayerHandSum() == 0 )
                    {
                        player.Lose();
                        Console.WriteLine("You have {0} chips left", player.ChipTotal);
                        response = EndGameCheck();
                        continue;
                    }
                }

                // check to see if dealer needs to play
                if (response == "")
                {
                    Console.WriteLine();
                    Console.WriteLine("The dealer was hiding a {0}", dealer.card1);
                    Console.WriteLine("The dealer has {0}", dealer.GetDealerHandSum());
                    dealer.Hit();
                    Console.WriteLine();
                    // compare dealer and player hands
                    for (int i = 0; i < player.handCount; i++)
                    {
                        if (dealer.GetDealerHandSum() > player.hands[i].GetPlayerHandSum())
                        {
                            player.Lose(i + 1);
                        }
                        else if (dealer.GetDealerHandSum() < player.hands[i].GetPlayerHandSum())
                        {
                            player.Win(i + 1);
                        }
                        else
                            player.Draw(i + 1);
                    }

                    // player chips
                      if (MoneyCheck(player.ChipTotal))
                        break;
                    response = EndGameCheck();
                }
                player.RemoveHands();// adjust player back to no hands and ends the round
            }
            while (response == "yes");
        }
    }
}
