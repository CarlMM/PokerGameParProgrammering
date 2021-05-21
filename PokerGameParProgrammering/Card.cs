namespace PokerGameParProgrammering
{
    internal class Card
    {
        private string cardName;

        public Card(string unicode, CardColour cardColour, Value value)
        {
            Unicode = unicode;
            CardColour = cardColour;
            Value = value;
            cardName = this.CardColour.ToString() + " " + this.Value.ToString();
        }

        public string Unicode { get; set; }
        public CardColour CardColour { get; set; }
        public Value Value { get; set; }
        public string CardName { get => cardName; }
    }
}