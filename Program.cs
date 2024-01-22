using Microsoft.VisualBasic;

namespace DeckBuilder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StartGame();

            Card[] Deck = GameLogic.GeneratePartialDeck();

            GameLogic.FillRemainingDeckWithCustomCards(Deck);

            GameLogic.DisplayDeck(Deck);

            //Now we have a full deck. Next, we convert to a stack so it behaves more like a real deck of cards. That is, drawing from the top (e.g., last in first out)
            Stack<Card> newDeck = new(Deck);

            string response = string.Empty;
            string question = "\n\n\n What would you like to do? \n" +
                "1. Peek at the top card of your deck.\n" +
                "2. Shuffle your deck.\n" +
                "3. Draw your opening hand of 8 cards.\n" +
                "Q. Quit;";

            // ToLower() allows the user to input q or Q
            // string.Equals() is the preferred way to compare strings
            while (!string.Equals(response.ToLower(), "q"))
            {
                response = GameLogic.GetValidString(question);

                switch (response)
                {
                    case "1":
                        Card topCard = MovingCards.PeekTop(newDeck);
                        Console.WriteLine(topCard.Title);
                        break;
                    case "2":
                        newDeck = MovingCards.ShuffleDeck(newDeck);
                        Console.WriteLine("Shuffled!");
                        break;
                    case "3":
                        MovingCards.DrawHand(newDeck);
                        break;
                }
            }

            Console.WriteLine("Good luck!");
        }

        static void StartGame()
        {
            GameLogic.IntroduceGame();
        }
    }
}
