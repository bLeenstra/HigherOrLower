namespace HigherOrLower
{
    public class Card
    {
        public readonly CardNumber CardNumber;
        public readonly CardSuit CardSuit;

        public Card(CardSuit suit, CardNumber number)
        {
            CardSuit = suit; 
            CardNumber = number;
        }
    }
}