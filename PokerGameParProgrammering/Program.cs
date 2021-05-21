using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGameParProgrammering
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Deck deck = new Deck();
            foreach (var card in deck.CardDeck)
            {
                Console.WriteLine($"{card.Unicode} {card.CardName}");
            }
            Console.ReadLine();
        }
    }
}