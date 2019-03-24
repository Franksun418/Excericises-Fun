using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Lower Bound: ");
            Console.WriteLine();
            int lowerBound = int.Parse(Console.ReadLine());
            Console.Write("Enter Higher Bound: ");
            Console.WriteLine();
            int higherBound = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = lowerBound; i <= higherBound; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Deck deck = new Deck();
            List<Card> hands = new List<Card>();
            deck.Shuffle();

            for (int i = 0; i < 5; i++)
            {
                hands.Add(deck.TakeTopCard());
            }

            for (int i = 0; i < hands.Count; i++)
            {
                hands[i].FlipOver();
            }

            foreach (Card card in hands)
            {
                card.Print();
            }
        }
    }
}
