using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeckBuilder
{
    public static class GameLogic
    {
        public static string GetValidString(string question)
        {
            string response = string.Empty;


            while (string.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine(new string('*', 80));
                Console.WriteLine(question);
                response = Console.ReadLine();
            }; //as long as response is blank or just spaces, keep looping

            return response;
        }

        public static int GetValidInt(string question, int minVal, int maxVal)
        {
            //When asking for a number, first make sure the user enters a string.
            //Then try to convert it to an int and make sure it is in bounds.

            int num = -1;

            //check to make sure it is an integer. If not, ask again.
            while (num < minVal || num > maxVal)
            {
                string input = GetValidString(question);

                try
                {
                    num = int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Hmm... I didn't understand that. ");
                }
            }

            return num;

        }
        public static void IntroduceGame()
        {
            Console.WriteLine(new string('*', 80));
            Console.WriteLine("Welcome to the Star Wars Customizable Card Game Deck Builder Console App for C#");
            Console.WriteLine($"RULES: A deck must have exactly {Constants.MAX_DECK_SIZE} cards.");
            Console.WriteLine("I can build the deck for you if you like, or you can add cards yourself until you reach 60 cards");
        }
        public static Card[] GeneratePartialDeck()
        {
            //Get a valid integer so we know how many cards to draft.
            int cardsToDraft = GetValidInt($"How many cards would you like me to generate for you? It must not exceed {Constants.MAX_DECK_SIZE}", 0, Constants.MAX_DECK_SIZE);

            //Create an array of cards as the starter deck
            Card[] Deck = new Card[Constants.MAX_DECK_SIZE];

            //start filling the deck with auto generated cards
            for (int i = 0; i < cardsToDraft; i++)
            {
                Deck[i] = AddRandomCard();
            }

            Console.WriteLine($"Drafting complete. However, you still" +
                          $" need {(Constants.MAX_DECK_SIZE - cardsToDraft)} for a deck.");

            return Deck;
        }
        public static Card[] FillRemainingDeckWithCustomCards(Card[] Deck)
        {
            int partialDeckSize=Deck.Count(s => s != null); //This checks to see how many blanks spaces are left to be filled in the array
            //Console.WriteLine(partialDeckSize);

            int cardsRemaining = Constants.MAX_DECK_SIZE - partialDeckSize;

            for (int i = 0; i < cardsRemaining; i++)
            {
                //add a new card after the set we initially drafted
                Deck[partialDeckSize + i] = addCustomCard();
        
            }

            return Deck;
        }
        public static void DisplayDeck(Card[] Deck)
        {
            int count = 1;

            foreach(Card item in Deck)
            {
                Console.Write("|" + count + ". " + item.Title + "|"+"\n");
                count++;
            }

        }
        public static Card AddRandomCard()
        {
            //Add randomly either a character, location, or interrupt card. 
            Random random = new Random();
            switch (random.Next(1, 4))
            {
                case 1:
                    Console.WriteLine("You drafted a location!");
                    return new Card_Location();
                    break;
                case 2:
                    Console.WriteLine("You drafted a character!");
                    return new Card_Character();
                    break;
                default:
                    Console.WriteLine("You drafted an interrupt!");
                    return new Card_Interrupt();
                    break;
            }

        }
        public static Card addCustomCard()
        {

            string question="What sort of card would you like to create?" +
                "\n 1. Location" +
                "\n 2. Interrupt"+
                "\n 3. Character";

            string type = GetValidString(question);
            
            switch (type)
            {
                case "1":
                    string title = GetValidString("Location Title?");
                    string terrainEffect= GetValidString("Location Terrain Effect Text?");
                    int destinyNumber = 0; //all locations have 0 for their destiny number so it isn't necessary to ask the user.
                    Card_Location location = new Card_Location(title, terrainEffect, destinyNumber);
                    return location;
                    break;
                case "2":
                    Console.WriteLine("This feature is not implemented yet, but since you want an interrupt, I will add a Blast the Door Kid for you");
                    return new Card_Interrupt();               
                        break;
                case "3":
                    Console.WriteLine("This feature is not implemented yet, but since you want a character, I will add a Admiral Ozzle for you");
                    return new Card_Interrupt();

                    break;
                default:
                    Console.WriteLine("Sorry, I  didn't understand you, so I added an Admiral Ozzle to your deck.");
                    return new Card_Character();
                    break;
            }

            return new Card_Character();
        }


    }

}

