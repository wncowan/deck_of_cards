using System;
using System.Collections.Generic;

namespace deck_of_cards{
    public class Card{
        public string stringVal { 
            get {
                if(val > 1 && val < 11) {
                 
                    return val.ToString();
                }
                else if (val == 11) {
                    //    stringVal = "Jack";
                    return "Jack";
                }
                else if (val == 12) {
                    return "Queen";
                }
                else if (val == 13) {
                    return "King";
                }
                else if (val == 1) {
                    return "Ace";
                }
                else {
                    return "Joker";
                }
            }
        }
        public string suit { get; set; }
        public int val { get; set; }
        public Card(string my_suit, int my_val){
            // stringVal = my_stringVal;
            suit = my_suit;
            val = my_val;
        }
    }

}