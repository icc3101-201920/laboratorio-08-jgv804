using Laboratorio_6_OOP_201902.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_6_OOP_201902
{
    [Serializable]
    public class Hand : Deck
    {

        public Hand()
        {
            base.Cards = new List<Card>();
        }

        
    }
}
