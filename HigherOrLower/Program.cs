using System;
using System.Collections.Generic;
using System.Linq;

namespace HigherOrLower {
    class Program
    {
        const int StartingLife = 10;
        private static int _currentLife;
        static void Main(string[] args)
        {
            _currentLife = StartingLife;
            Console.WriteLine("This application will deal you a card from a deck of cards, and you must choose if the next card will be a higher or lower value");
            Console.WriteLine("Guessing incorrectly will decrease your life by 1. You have 10 life total");

            while( true ) {
                List<Card> deck = NewDeck();

                DealCards(deck);

                Console.WriteLine("Press the 'Enter' key to play again");
                ConsoleKeyInfo newPerson = Console.ReadKey(); 
                if( newPerson.Key == ConsoleKey.Enter ) {
                    continue;
                }
                break;
            }

        }

        private static void DealCards(List<Card> deck)
        {
            if (DecreaseLife())
            {
                DealCards(deck);
            }
        }

        private static bool DecreaseLife()
        {
            _currentLife--;
            if (_currentLife > 0)
            {
                Console.WriteLine($"You currently have {_currentLife} life!");
                return true;
            }
            Console.WriteLine("You have taken too much damage and have died a horrible death!");
            return false;
        }

        private static List<Card> NewDeck()
        {
            List<Card> deck = new List<Card>();
            deck.AddRange(from CardNumber number in Enum.GetValues(typeof(CardNumber))
                          from CardSuit suit in Enum.GetValues(typeof(CardSuit))
                          select new Card(suit, number));
            return deck;
        }
    }
}
