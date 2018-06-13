using System;
using System.Collections.Generic;

namespace DeckOfCards {
    public class Player {
        public string name;
        public List<Card> hand = new List<Card>();

        public Player(string cName) {
            name = cName;
        }

        public Card draw(Deck deck){
            Card card = deck.Deal();
            hand.Add(card);
            return card;
        }

        public Card Discard(int idx) {
            if(hand.Count<= idx){
                return null;
            }
            Card discarded = hand[idx];
            hand.RemoveAt(idx);
            return discarded;
        }

    }

}
