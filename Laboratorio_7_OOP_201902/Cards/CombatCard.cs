﻿using Laboratorio_7_OOP_201902.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio_7_OOP_201902.Interfaces;

namespace Laboratorio_7_OOP_201902.Cards
{
    [Serializable]
    public class CombatCard : Card
    {
        //Atributos
        private int attackPoints;
        private bool hero;

        //Constructor
        public CombatCard(string name, EnumType type, string effect, int attackPoints, bool hero)
        {
            Name = name;
            Type = type;
            Effect = effect;
            AttackPoints = attackPoints;
            Hero = hero;
        }

        //Propiedades
        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            set
            {
                this.attackPoints = value;
            }
        }
        public bool Hero
        { get
            {
                return this.hero;
            }
            set
            {
                this.hero = value;
            }
        }
        public override List<string> GetCharacteristics()
        {
            List<string> returner = new List<string>();
            returner.Add(Name);
            returner.Add(nameof(Type));
            returner.Add(Effect);
            returner.Add(AttackPoints.ToString());
            returner.Add(Hero.ToString());
            return returner;
        }

        
    }
}
