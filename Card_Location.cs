using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
