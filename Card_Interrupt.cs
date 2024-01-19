using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckBuilder
{
    internal class Card_Interrupt : Card
    {
        public string GameText { get; set; }

        public Card_Interrupt()
        {
            //if nothing entered by the user, add a "blast the door, kid!"

            this.Alignment = Enums.Alignment.dark;
            this.Title = "Blast the door kid!";
            this.DestinyNumber = 6;
            this.GameText = "Discard this card to cancel a battle where opponent has more power than you.";
            this.Type = Enums.Type.characters;
        }

    }
}
