using Microsoft.VisualBasic;

namespace DeckBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            Random random = new Random();

            Console.WriteLine(input);
            Console.WriteLine("Welcome to the Star Wars Customizable Card Game Deck Builder Console App for C#");
            Console.WriteLine("At any time, type Q to Q.\n");
            Console.WriteLine($"RULES: A deck must have exactly {Constants.MAX_DECK_SIZE} cards.");
            Console.WriteLine("I can build the deck for you if you like, or you can add cards yourself until you reach 60 cards");

            //Get a valid integer so we know how many cards to draft.
            int cardsToDraft;
            cardsToDraft = GetValidInt("How many cards would you like me to generate for you?", 0, Constants.MAX_DECK_SIZE);
            
            //Create an array of cards as the starter deck
            Card[] Deck = new Card[Constants.MAX_DECK_SIZE];
            for(int i = 0; i < cardsToDraft; i++)
            {
                Deck[i] = AddRandomCard();
            }
            
            Console.WriteLine("You wrote " + cardsToDraft);

        }


        //Every time we get info from the user, we want to state the question and make sure response is not empty.
        public static string GetValidString(string question)
        {
            string response = string.Empty;


            while (string.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine(question);
                response = Console.ReadLine();
            }; //as long as response is blank or just spaces, keep looping

            return response;

        }

        //When asking for a number, first make sure the user enters a string.
        //Then try to convert it to an int and make sure it is in bounds.
        public static int GetValidInt(string question, int minVal, int maxVal)
        {
            //get a string from the user
            string input = GetValidString(question);
            int num = -1;

            //check to make sure it is an integer. If not, ask again.
            while (num < minVal || num > maxVal)
            {

                try
                {
                    num = int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Hmm... I didn't understand that. ");
                    input = GetValidString(question);
                }
            }
            
            return num;

        }

        public static Card AddRandomCard()
        {
            //Add randomly either a character, location, or interrupt card. 
            Random random = new Random();
            switch (random.Next(1, 4))
            {
                case 1:
                    Console.WriteLine("You drafted a location!");
                    break;
                case 2:
                    Console.WriteLine("You drafted a character!");
                    break;
                default:
                    Console.WriteLine("You drafted an interrupt!");
                    break;
            }
            return new Card_Character();

        }


    }
}
