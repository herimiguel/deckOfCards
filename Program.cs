using System;

namespace DeckOfCards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.shuffle();
            Player myPlayer = new Player("user1");
            myPlayer.draw(myDeck);
            myPlayer.draw(myDeck);
            myPlayer.draw(myDeck);
            myPlayer.draw(myDeck);
            myPlayer.draw(myDeck);
            foreach(Card card in myPlayer.hand){
                Console.WriteLine("{0} of {1}", card.stringValue, card.suit);
            }
            myPlayer.Discard(2);
            Console.WriteLine("@@@@@@@@@@@@@@@@@");
            foreach(Card card in myPlayer.hand){
                Console.WriteLine("{0} of {1}", card.stringValue, card.suit);

            }

        }
    }
}