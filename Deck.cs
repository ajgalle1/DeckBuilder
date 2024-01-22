namespace DeckBuilder
{
    public class Deck(IEnumerable<Card> initialCards)
    {
        // Define cards as a list of Card objects
        private readonly Stack<Card> _cards = new Stack<Card>(initialCards);

        public void Shuffle()
        {
            // Create a new random number generator
            // Conver the stack of cards to an array
            // Clear the stack
            Random rnd = new();
            var cardsArr = _cards.ToArray();
            _cards.Clear();

            for (int i = cardsArr.Length - 1; i > 0; --i)
            {
                // Randomly pick a card and swap it with the current card
                int j = rnd.Next(i + 1);
                // This is a tuple swap. Tuples are just a data structure that
                // holds 2 values.
                (cardsArr[j], cardsArr[i]) = (cardsArr[i], cardsArr[j]);
            }

            // Add the newly shuffled card back onto the stack
            foreach (var card in cardsArr)
            {
                _cards.Push(card);
            }
        }

        public Card[] Draw(int numOfCardsToDraw)
        {
            if (_cards.Count >= numOfCardsToDraw)
            {
                Card[] cards = [];
                for (int i = 0; i < numOfCardsToDraw; i++)
                {
                    // The .. is the spread operator
                    // It is basically copying all of the elements from cards
                    // and then adding the popped card to the end of the array
                    cards = [.. cards, _cards.Pop()];
                }

                return cards;
            }
            else
            {
                throw new InvalidOperationException("The deck is empty.");
            }
        }

        public Card Peek()
        {
            if (_cards.Count > 0)
            {
                return _cards.Peek();
            }
            else
            {
                throw new InvalidOperationException("The deck is empty.");
            }
        }
    }
}