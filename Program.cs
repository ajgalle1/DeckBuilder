using Microsoft.VisualBasic;

namespace DeckBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            
            Console.WriteLine("Welcome to the Star Wars Customizable Card Game Deck Builder Console App for C#");
            Console.WriteLine("At any time, type Q to Q.\n");
            Console.WriteLine($"RULES: A deck must have exactly {Constants.MAX_DECK_SIZE} cards.");
            Console.WriteLine("I can build the deck for you if you like, or you can add cards yourself until you reach 60 cards");
            
            
            //Get a valid integer so we know how many cards to draft.
            input = GetValidString("How many cards would you like me to generate for you?");
            Console.WriteLine("You wrote " + input);
            

            

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
        public static string GetValidInt(string prompt, int minLength, int maxLength)
        {
            string input = GetValidString(prompt);

            while (input.Length < minLength || input.Length > maxLength)
            {
                input = GetValidString(prompt);
            }


            return input;
        }



    }
}
