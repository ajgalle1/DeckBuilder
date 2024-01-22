namespace DeckBuilder
{
    internal class Interrupt : Card
    {
        public string GameText { get; set; }

        public Interrupt()
        {
            //if nothing entered by the user, add a "blast the door, kid!"

            this.Alignment = Enums.Alignment.dark;
            this.Title = "Blast the door kid!";
            this.DestinyNumber = 6;
            this.GameText = "Discard this card to cancel a battle where opponent has more power than you.";
            this.Type = Enums.Type.characters;
        }


        public override void DisplayCardInfo()
        {
            Console.WriteLine("".PadRight(80, '*'));
            Console.WriteLine("Title: {0}", this.Title);
            Console.WriteLine("Type: {0}", this.Type);
            Console.WriteLine("Alignment: {0}", this.Alignment);
            Console.WriteLine("Destiny Number: {0}", this.DestinyNumber);
            Console.WriteLine("Game Text: {0}", this.GameText);
            Console.WriteLine("".PadRight(80, '*'));
        }
    }
}
