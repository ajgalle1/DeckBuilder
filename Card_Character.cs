using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckBuilder
{
    internal class Card_Character : Card
    {
        public string GameText { get; set; }
        public string Lore { get; set; }
        public int Power { get; set; }
        public int DeployCost { get; set; }

        public bool isWarrior { get; set; }
        public bool isPilot { get; set; }


        public Card_Character()
        {
            //if nothing entered by the user, add a "blast the door, kid!"
            this.isWarrior = true;
            this.isPilot = true;
            this.Power = 3;
            this.DeployCost = 1;

            this.Alignment = Enums.Alignment.dark;
            this.Title = "Admiral Ozzle";
            this.DestinyNumber = 2;
            this.Lore = "Imperial Leader. Has failed Vader for the next to last time. As clumsy as he is stupid.";
            this.Type = Enums.Type.characters;
            this.GameText = "If Vader on table and opponent plays an interrupt during this battle, place Admiral Ozzle out of play.";
        }


    }
}
