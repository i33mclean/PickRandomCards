using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        // Creates a Random Number Generator called random
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomValue()
        {
            // Get a random number from 1 to 13
            int value = random.Next(1, 14);

            // If the value is 1, return the string Ace
            if (value == 1) return "Ace";

            // If the value is 11, return the string Jack
            if (value == 11) return "Jack";

            // If the value is 12, return the string Queen
            if (value == 12) return "Queen";

            // If the value is 13, return the string King
            if (value == 13) return "King";

            // Since the RandomValue Method is a string, value needs to be converted to a string
            return value.ToString();
        }

        private static string RandomSuit()
        {
            // Get a random number from 1 to 4
            int value = random.Next(1, 5);

            // If the value is 1, return the string Spades
            if (value == 1) return "Spades";

            // If the value is 2, return the string Hearts
            if (value == 2) return "Hearts";

            // If the value is 3, return the string Clubs
            if (value == 3) return "Clubs";

            // If it has not returned yet, return the string Diamonds
            return "Diamonds";
        }



    }
}
