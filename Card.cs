using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public Card(Rank rank, Suit suit)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}
