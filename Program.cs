using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Initalize();

            bool keepGoing = true;

            while (keepGoing == true)
            {
                Console.WriteLine("Play Again - Yes or No");

                if(Console.ReadLine() == "Yes")
                {
                    Initalize();
                }
                else
                {
                    Console.WriteLine("Thanks for playing");
                    keepGoing = false;
                }
            }
        }

        private static void Initalize()
        {
            Console.Write("Enter the number of cards to pick: ");

            string line = Console.ReadLine();

            int.TryParse(line, out int numberOfCards);

            if (int.TryParse(line, out numberOfCards))
            {
                string[] cards = CardPicker.PickSomeCards(numberOfCards);

                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("The number was not valid");
            }
        }
    }
}
