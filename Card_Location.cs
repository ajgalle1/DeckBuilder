using static DeckBuilder.Enums;

namespace DeckBuilder
{
    internal class Location : Card
    {
        public string TerrainEffect { get; set; }
        public Location()
        {
            //if nothing entered by the user, add a "blast the door, kid!"
            this.TerrainEffect = "Spend 1 additional force to deploy here";
            this.Alignment = Enums.Alignment.dark;
            this.Title = "Degobah Swamp";
            this.DestinyNumber = 0;
            this.Type = Enums.Type.locations;
        }
        public Location(string title, string terrainEffect, int destinyNumber)
        {
            //If the user has provided information, create a location card with this overload constructor
            this.TerrainEffect = terrainEffect;
            this.Title = title;
            this.Alignment = Alignment.light;
            this.DestinyNumber = destinyNumber;
            this.Type = Enums.Type.locations;

        }

        public override void DisplayCardInfo()
        {
            Console.WriteLine("".PadRight(80, '*'));
            Console.WriteLine("Title: {0}", this.Title);
            Console.WriteLine("Type: {0}", this.Type);
            Console.WriteLine("Alignment: {0}", this.Alignment);
            Console.WriteLine("Destiny Number: {0}", this.DestinyNumber);
            Console.WriteLine("Terrain Effect: {0}", this.TerrainEffect);
            Console.WriteLine("".PadRight(80, '*'));
        }

    }
}
