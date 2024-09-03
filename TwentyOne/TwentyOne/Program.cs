using System;
using System.Collections.Generic;
using System.Linq;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {

            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
