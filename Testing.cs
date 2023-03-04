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
        }
    }

}
