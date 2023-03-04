using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Rank
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    class Pack
    {
        List<Card> pack = new List<Card>();

        public Pack()
        {
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                    {
                        pack.Add(new Card(rank, suit));
                    }
                }
                foreach (Card card in pack)
                {
                    Console.WriteLine($"{card.Rank} of {card.Suit}");
                }
            }
        }

        //public static bool shuffleCardPack(int typeOfShuffle)
        //{
        //    int userSelect = 0;


        //}
        //public static Card deal()
        //{
        //    //Deals one card

        //}
        //public static List<Card> dealCard(int amount)
        //{
        //    //Deals the number of cards specified by 'amount'
        //}
    }
}
