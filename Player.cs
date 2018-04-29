using System;
using System.Collections.Generic;

namespace deck_of_cards{
    public class Player{
        public string name { get; set; }
        public List<Card> hand { get; set; }
        public Player(string my_name){
            // stringVal = my_stringVal;
            name = my_name;
            hand = new List<Card>();
        }
        public Card DrawCard(Deck currentDeck){
            Card temp = currentDeck.Deal();
            hand.Add(temp);
            return temp;
        }
        public Card DiscardCard(int index){
            if (index < 0 || index > hand.Count-1){
                Console.WriteLine("Index invalid");
                return null;
            }
            Card temp = hand[0];
            hand.RemoveAt(index);
            return temp;
        }
        public void ShowHand(){
            Console.WriteLine("{0}'s hand: ", this.name);
            foreach(Card card in hand){
                Console.WriteLine("{0} of {1}", card.stringVal, card.suit);
            }
        }


    }

}