using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public abstract class Setup //Parent Class
    {
        enum FaceChange { A = 11, J = 10, Q = 10, K = 10 }; //declare the Face card values Ace is changed within main code
        public static int[] cards = { (int)FaceChange.A, 2, 3, 4, 5, 6, 7, 8, 9, 10, (int)FaceChange.J, (int)FaceChange.Q, (int)FaceChange.K }; //create array of cards 
        static Random rand = new Random(); //create random int object
        public static int NewCard() //takes a random 1 in 13 chance of picking a card, acts as the drawing of a card
        {
            int newcard;
            newcard = rand.Next(0, 13);
            return cards[newcard];
        }
    }
}
