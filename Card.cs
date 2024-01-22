using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckBuilder
{
    public abstract class Card
    {
        //All star wars cards are cards, but none are just cards. 
        //The must be either locations, characters, interrupts, effects, or ships. 
        public int DestinyNumber { get; set; }

        // Need to provide a default value for Title
        public string Title { get; set; } = "Default Title";

        public Enums.Alignment Alignment { get; set; }
        public Enums.Type Type { get; set; }

        public abstract void DisplayCardInfo();

    }

}
