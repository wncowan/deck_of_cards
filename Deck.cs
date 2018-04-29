using System;
using System.Collections.Generic;

namespace deck_of_cards{
    public class Deck{
        public List<Card> cards { get; set; }
        

        public Deck(){
            cards = new List<Card>();
            string[] suits = new string[4]{"Hearts", "Clubs", "Spades", "Diamonds"};
            foreach(string suit in suits){
                for(int i = 1; i < 14; i++){
                    cards.Add(new Card(suit, i));
                }
            }
        }
        public void Show(){
            Console.WriteLine("Cards in Deck: ");
            foreach(Card card in cards){
                Console.WriteLine("{0} of {1}", card.stringVal, card.suit);
            }
        }
        public Card Deal(){
            if(cards.Count > 0){
                Card temp = cards[0];
                cards.RemoveAt(0);
                Console.WriteLine("Card Dealt: {0} of {1}", temp.stringVal, temp.suit);
                return temp;
            }
            return null;
        }
        public void Reset(){
            cards = new List<Card>();
            string[] suits = new string[4]{"Hearts", "Clubs", "Spades", "Diamonds"};
            foreach(string suit in suits){
                for(int i = 1; i < 14; i++){
                    cards.Add(new Card(suit, i));
                }
            }
        }
        public void Shuffle(){
            Random rand = new Random();
            int rando;
            Card temp;
            for(int i = 0; i < cards.Count; i++){
                rando = rand.Next(0,51);
                temp = cards[i];
                cards[i] = cards[rando];
                cards[rando] = temp;
            }
        }
    }
    
}