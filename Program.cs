using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            Player player1 = new Player("steve");
            player1.DrawCard(myDeck);
            player1.DrawCard(myDeck);
            player1.DrawCard(myDeck);
            player1.ShowHand();
            player1.DiscardCard(9);
            player1.ShowHand();
        }
    }
}
