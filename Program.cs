using Microsoft.VisualBasic;

namespace DeckBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GameLogic.IntroduceGame();

            Card[] Deck = GameLogic.GeneratePartialDeck();

            GameLogic.FillRemainingDeckWithCustomCards(Deck);

            GameLogic.DisplayDeck(Deck);

            //Now we have a full deck. Next, we convert to a stack so it behaves more like a real deck of cards. That is, drawing from the top (e.g., last in first out)
            Stack<Card> newDeck = new Stack<Card>(Deck);

            string response = string.Empty;
            string question = "\n\n\n What would you like to do? \n" +
                "1. Peek at the top card of your deck.\n" +
                "2. Shuffle your deck.\n" +
                "3. Draw your opening hand of 8 cards.\n" +
                "Q. Quit;";
            while (response != "Q")
            {
                response = GameLogic.GetValidString(question);

                switch (response)
                {
                    case "1":
                        Card topCard = MovingCards.PeekTop(newDeck);
                        Console.WriteLine(topCard.Title);
                        break;
                    case "2":
                        newDeck = MovingCards.shuffleDeck(newDeck);
                        Console.WriteLine("Shuffled!");
                        break;
                    case "3":
                        MovingCards.DrawHand(newDeck);
                        break;
                }
            }

            Console.WriteLine("Good luck!");
        }

    }
}
