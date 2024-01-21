using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DeckBuilder
{
    internal class MovingCards
    {

        //todo: shuffle deck into a stack.
        public static Stack<Card> shuffleDeck(Stack<Card> deck)
        {
            //To randomize a stack, I need to put it into a list, then put it back into a stack.
            Random rnd = new Random();

            List<Card> newDeck = new List<Card>();
            while (deck.Count > 0)
            {
                newDeck.Add(deck.Pop());
            }
            while (newDeck.Count > 0)
            {
                int r = rnd.Next(0, newDeck.Count);
                deck.Push(newDeck[r]);
                newDeck.RemoveAt(r);
            }
            return deck;
        }

        public static Card PeekTop(Stack<Card> deck)
        {
            Card topCard = deck.Peek();
            Console.WriteLine(new string('*', 80));
            Console.WriteLine(topCard.Title);
            Console.WriteLine(topCard.Alignment);
            Console.WriteLine(topCard.DestinyNumber);
            Console.WriteLine(topCard.Type);

            if(topCard.Type == Enums.Type.characters)
            {
               //Hmm... how can I access the fields of the card that are unique to the derived class?
            }
            return topCard;
        }

        public static List<Card> DrawHand(Stack<Card> deck)
        {
            Console.Write("Your opening hand is: ");
            List<Card> hand = new List<Card>();
            Card currentCard;

            for(int i = 0; i < Constants.MAX_HAND_SIZE; i++)
            {
                Console.Write(i+1 + ". ");
                currentCard = deck.Pop();
                Console.Write(currentCard.Title + " ");
                hand.Add(currentCard);
                
            }
            return hand;

        }
    }


    //todo: peek at top card

    //todo: examine card details

    //todo: complete custom card entr
}

