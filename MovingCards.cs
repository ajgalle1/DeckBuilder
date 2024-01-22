namespace DeckBuilder
{
    internal class MovingCards
    {

        //todo: shuffle deck into a stack.
        // Minor naming convention issue: shuffleDeck should be ShuffleDeck
        public static Stack<Card> ShuffleDeck(Stack<Card> deck)
        {
            //To randomize a stack, I need to put it into a list, then put it back into a stack.
            Random rnd = new();
            List<Card> newDeck = [];

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

            // if (topCard.Type == Enums.Type.characters)
            // {
            //     //Hmm... how can I access the fields of the card that are unique to the derived class?
            // }

            /**
             * I've provided you with some additonal methods that may make displaying
             * the card information easier. However, you can also use this method to 
             * display the card information.
             */

            if (topCard is Character character_card)
            {
                Console.WriteLine(character_card.Power);
                Console.WriteLine(character_card.DeployCost);
                Console.WriteLine(character_card.IsWarrior);
                Console.WriteLine(character_card.IsPilot);
                Console.WriteLine(character_card.Lore);
                Console.WriteLine(character_card.GameText);
            }
            else if (topCard is Interrupt interrupt_card)
            {
                Console.WriteLine(interrupt_card.GameText);
            }
            else if (topCard is Location location_card)
            {
                Console.WriteLine(location_card.TerrainEffect);
            }

            return topCard;
        }

        public static List<Card> DrawHand(Stack<Card> deck)
        {
            Console.Write("Your opening hand is: ");
            List<Card> hand = [];
            Card currentCard;

            for (int i = 0; i < Constants.MAX_HAND_SIZE; i++)
            {
                Console.Write(i + 1 + ". ");
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

