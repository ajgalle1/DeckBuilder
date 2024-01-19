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
        
        public string Title { get; set; }

        public Enums.Alignment Alignment { get; set; }
        public Enums.Type Type { get; set; }
   
        
    
    
    
    }

}
