using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
    internal class Testing
    {
        // Create an instance of the Validation class to validate user input
        Validation validation = new Validation();

        public Testing()
        {
            // Create a new instance of the Pack class and shuffle the cards
            Pack pack = new Pack();
            Pack.shuffleCardPack(pack.pack);

            // Print out the shuffled pack of cards
            foreach (Card card in pack.pack)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }

            // Prompt the user to choose one of two options, then deal cards and print the user's hand
            while (true)
            {
                int userInput = validation.GetIntInput("Coose one of the following options\n" +
                    "[1] Deal one card\n" +
                    "[2] Deal five cards\n", 1, 2);

                if (userInput == 1)
                {
                    Pack.Deal(pack.pack, pack.hand);
                }

                if (userInput == 2)
                {
                    Pack.Deal(pack.pack, pack.hand, 5);
                }

                foreach (Card card in pack.hand)
                {
                    Console.WriteLine($"{card.Rank} of {card.Suit}");
                }

            }
        }
    }

}