using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

namespace CMP1903M_A01_2223
{

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
                        Console.WriteLine($"{rank} of {suit}");
                    }
                }
            }
        }

        //public static bool shuffleCardPack(int typeOfShuffle)
        //{
        //    //Shuffles the pack based on the type of shuffle

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
