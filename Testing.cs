using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
    internal class Testing : Validation
    {

        public Testing()
        {
            // Create a new instance of the Pack class and shuffle the cards
            Pack pack = new Pack();
            Pack.shuffleCardPack();

            // Create an instance of the Validation class to validate user input

            // Print out the shuffled pack of cards
            foreach (Card card in Pack.pack)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }

            // Prompt the user to choose one of two options, then deal cards and print the user's hand
            while (true)
            {
                int userInput = GetIntInput("Coose one of the following options\n" +
                    "[1] Deal one card\n" +
                    "[2] Deal many cards\n", 1, 2);

                if (userInput == 1)
                {
                    Pack.deal();
                }

                if (userInput == 2)
                {
                    Pack.dealCard(GetIntInput($"Deal how many cards? max[{Pack.pack.Count}]", 0, Pack.pack.Count));
                }

                foreach (Card card in Pack.hand)
                {
                    Console.WriteLine($"{card.Rank} of {card.Suit}");
                }

            }
        }
    }

}