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
        public List<Card> pack = new List<Card>();
        public List<Card> hand = new List<Card>();

        public Pack()
        {
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                    {
                        pack.Add(new Card(rank, suit));
                    }
                }

            }
        }


        public static void shuffleCardPack(List<Card> pack)
        {
            Validation validation = new Validation();

            int shuffleType = validation.GetIntInput($"Choose shuffling method:\n" +
                $"[1] Fisher Yates shuffle\n" +
                $"[2] Riffle shuffle\n" +
                $"[3] No shuffle\n", 1, 3);
            if (shuffleType == 1)
            {
                Random rng = new Random();
                int n = pack.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    Card temp = pack[k];
                    pack[k] = pack[n];
                    pack[n] = temp;
                }
            }
            if (shuffleType == 2)
            {
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Random rng = new Random();
                        int n = pack.Count / 2;
                        List<Card> left = new List<Card>(pack.GetRange(0, n));
                        List<Card> right = new List<Card>(pack.GetRange(n, n));
                        pack.Clear();
                        while (left.Count > 0 && right.Count > 0)
                        {
                            if (rng.NextDouble() < 0.5)
                            {
                                pack.Add(left[0]);
                                left.RemoveAt(0);
                            }
                            else
                            {
                                pack.Add(right[0]);
                                right.RemoveAt(0);
                            }
                        }
                        pack.AddRange(left);
                        pack.AddRange(right);
                    }

                }
            }
            if (shuffleType == 3)
            {

            }
        }
        public static void Deal(List<Card> pack, List<Card> hand)
        {
            if (pack.Count <= 0)
            {
                Console.WriteLine("There are no more cards in the deck");
            }
            else
            {
                hand.Add(pack[0]);
                pack.RemoveAt(0);
            }
        }
        public static void Deal(List<Card> pack, List<Card> hand, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if (pack.Count <= 0)
                {
                    Console.WriteLine("There are no more cards in the deck");
                    break;
                }
                else
                {
                    hand.Add(pack[0]);
                    pack.RemoveAt(0);
                }
            }
        }
    }
}
