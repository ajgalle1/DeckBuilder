using Microsoft.VisualBasic;

namespace DeckBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            Random random = new Random();

            GameLogic.IntroduceGame();

            Card[] Deck = GameLogic.GeneratePartialDeck();

            GameLogic.FillRemainingDeckWithCustomCards(Deck);

            try
            {
                GameLogic.DisplayDeck(Deck);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

    }
}
