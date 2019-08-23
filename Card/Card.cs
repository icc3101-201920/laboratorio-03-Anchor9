using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2_OOP_201902.Card
{
    public class Card
    {
        public abstract List<Card> Cards = new List<Card>();
        // SE BORRA private List<CombatCard> combatCards;
        // SE BORRA private List<SpecialCard> SpecialCards;
    }

    {
        //Atributos
        protected string name;
        protected string type;
        protected string effect;

        //Constructor
        public Card()
        {
            Cards.Add(CombatCard);
            Cards.Add(SpecialCard);
        }

        //Propiedades
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public string Effect
        {
            get
            {
                return this.effect;
            }
            set
            {
                this.effect = value;
            }
        }
        
    }
}
