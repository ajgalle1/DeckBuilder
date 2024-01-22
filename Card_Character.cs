namespace DeckBuilder
{
    // I'm going to make this change but it's up to you
    // Personally I think 'Card' is inferred and the classes
    // should be named Character, Location, etc.
    internal class Character : Card
    {
        public string GameText { get; set; }
        public string Lore { get; set; }
        public int Power { get; set; }
        public int DeployCost { get; set; }

        // Minor naming convention issue: isWarrior and isPilot should be IsWarrior and IsPilot
        public bool IsWarrior { get; set; }
        public bool IsPilot { get; set; }


        public Character()
        {
            //if nothing entered by the user, add a "blast the door, kid!"
            this.IsWarrior = true;
            this.IsPilot = true;
            this.Power = 3;
            this.DeployCost = 1;

            this.Alignment = Enums.Alignment.dark;
            this.Title = "Admiral Ozzle";
            this.DestinyNumber = 2;
            this.Lore = "Imperial Leader. Has failed Vader for the next to last time. As clumsy as he is stupid.";
            this.Type = Enums.Type.characters;
            this.GameText = "If Vader on table and opponent plays an interrupt during this battle, place Admiral Ozzle out of play.";
        }

        public override void DisplayCardInfo()
        {
            Console.WriteLine("".PadRight(80, '*'));
            Console.WriteLine("Title: {0}", this.Title);
            Console.WriteLine("Type: {0}", this.Type);
            Console.WriteLine("Alignment: {0}", this.Alignment);
            Console.WriteLine("Destiny Number: {0}", this.DestinyNumber);
            Console.WriteLine("Deploy Cost: {0}", this.DeployCost);
            Console.WriteLine("Power: {0}", this.Power);
            Console.WriteLine("Lore: {0}", this.Lore);
            Console.WriteLine("Game Text: {0}", this.GameText);
            Console.WriteLine("".PadRight(80, '*'));
        }
    }
}
