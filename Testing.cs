using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
    internal class Testing
    {
        Validation validation = new Validation();

        public Testing()
        {
            Pack pack = new Pack();

            Pack.shuffleCardPack(pack.pack);
            foreach (Card card in pack.pack)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }

            while (true)
            {
                int userInput = validation.GetIntInput("Coose one of the following options\n" +
                    "[1] Deal one card\n" +
                    "[2] Deal five cards\n", 1,2);
                if (userInput == 1)
                {
                    Pack.Deal(pack.pack, pack.hand);
                    foreach (Card card in pack.pack);
                }
                if (userInput == 2)
                {
                    Pack.Deal(pack.pack, pack.hand, 5);
                    foreach (Card card in pack.pack);
                }

                foreach (Card card in pack.hand)
                {
                    Console.WriteLine($"{card.Rank} of {card.Suit}");
                }

            }
        }
    }

}
