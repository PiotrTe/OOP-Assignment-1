using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
    // Define a class called Card
    class Card
    {
        // Define two properties: Suit and Rank
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        // Define a constructor for the Card class that takes a Rank and a Suit as parameters
        public Card(Rank rank, Suit suit)
        {
            // Assign the passed-in Rank and Suit values to the Suit and Rank properties of the Card instance
            Suit = suit;
            Rank = rank;
        }
    }
}
