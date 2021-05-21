using System.Collections.Generic;
using System;

namespace PokerGameParProgrammering
{
    internal class Deck
    {

        Random cardRandom = new Random();

        private readonly string[] uniCodeRepresent = new string[]
        {
            //Spader
            "U+1F0A1", "U+1F0A2", "U+1F0A3", "U+1F0A4", "U+1F0A5", "U+1F0A6", "U+1F0A7", "U+1F0A8", "U+1F0A9", "U+1F0AA", "U+1F0AB", "U+1F0AC", "U+1F0AD","U+1F0AE",
            //Hjärta
            "U+1F0B1", "U+1F0B2", "U+1F0B3", "U+1F0B4", "U+1F0B5", "U+1F0B6", "U+1F0B7", "U+1F0B8", "U+1F0B9", "U+1F0BA", "U+1F0BB", "U+1F0BC", "U+1F0BD", "U+1F0BE",
            //Ruter
            "U+1F0C1", "U+1F0C2", "U+1F0C3", "U+1F0C4", "U+1F0C5", "U+1F0C6", "U+1F0C7", "U+1F0C8", "U+1F0C9", "U+1F0CA", "U+1F0CB", "U+1F0CC", "U+1F0CD", "U+1F0CE",
            //Klöver
            "U+1F0D1", "U+1F0D2", "U+1F0D3", "U+1F0D4", "U+1F0D5", "U+1F0D6", "U+1F0D7", "U+1F0D8", "U+1F0D9", "U+1F0DA", "U+1F0DB", "U+1F0DC", "U+1F0DD", "U+1F0DE",
        };

        public Deck()
        {
            int uni = 0;
            CardDeck = new List<Card>();
            //Färger
            for (int i = 0; i < 4; ++i)
            {
                //Värden
                for (int j = 0; j < 13; ++j)
                {
                    CardDeck.Add(new Card(uniCodeRepresent[uni], (CardColour)i, (Value)j));
                    ++uni;
                }
            }
        }

        public List<Card> CardDeck { get; set; }


        public List<Card> ShuffleDeck(List<Card> cardDeck)
        {
            List<Card> cardDeck2 = new List<Card>();
            
            
                for(int y = 0; y < cardDeck.Count; ++y)
                {
                    int secondDeckIndex = cardRandom.Next(0,51);
                    cardDeck2 = cardDeck;
                    cardDeck[y] = cardDeck[secondDeckIndex];
                    cardDeck[secondDeckIndex] = cardDeck2[y];
                }
            

            return cardDeck2;
           
        }
    }
}