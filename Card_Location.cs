using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DeckBuilder.Enums;

namespace DeckBuilder
{
    internal class Card_Location : Card
    {
        public string TerrainEffect { get; set; }
        public Card_Location()
        {
            //if nothing entered by the user, add a "blast the door, kid!"
            this.TerrainEffect = "Spend 1 additional force to deploy here";
            this.Alignment = Enums.Alignment.dark;
            this.Title = "Degobah Swamp";
            this.DestinyNumber = 0;
            this.Type = Enums.Type.locations;
        }
         public Card_Location(string title, string terrainEffect, int destinyNumber)
        {
            //If the user has provided information, create a location card with this overload constructor
            this.TerrainEffect = terrainEffect;
            this.Title= title;
            this.Alignment = Alignment.light;
            this.DestinyNumber = destinyNumber;
            this.Type= Enums.Type.locations;

        }

    }
}
