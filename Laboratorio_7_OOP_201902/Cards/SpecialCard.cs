using Laboratorio_7_OOP_201902.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio_7_OOP_201902.Interfaces;

namespace Laboratorio_7_OOP_201902.Cards
{
    [Serializable]
    public class SpecialCard : Card
    {
        //Atributos
        private string buffType;

        //Propiedades
        public string BuffType
        {
            get
            {
                return this.buffType;
            }
            set
            {
                this.buffType = value;
            }
        }
        //Constructor
        public SpecialCard(string name, EnumType type, string effect)
        {
            Name = name;
            Type = type;
            Effect = effect;
            BuffType = null;
        }

        public override List<string> GetCharacteristics()
        {
            List<string> returner = new List<string>();
            returner.Add(Name);
            returner.Add(nameof(Type));
            returner.Add(Effect);
            returner.Add(BuffType);
            
            return returner;
        }


    }
}
