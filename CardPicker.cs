using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        // Generates a random number 
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

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);

            if (value == 1) return "Ace";
            if (value == 2) return "Jack";
            if (value == 3) return "Queen";
            if (value == 4) return "King";
            return value.ToString();
        }


        private static string RandomValue()
        {
            throw new NotImplementedException();
        }

    }
}
