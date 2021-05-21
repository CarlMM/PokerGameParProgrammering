using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGameParProgrammering
{
    class Deck
    {

        public List<Card> cardDeck { get; set; }
        private List<string> uniCodeRepresent = new List<string>()
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
            cardDeck = new List<Card>();
        }

    }
}
