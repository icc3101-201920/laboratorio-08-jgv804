using Laboratorio_7_OOP_201902.Cards;
using Laboratorio_7_OOP_201902.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Laboratorio_7_OOP_201902.Interfaces;

namespace Laboratorio_7_OOP_201902
{
    [Serializable]
    public class Deck : ICharacteristics
    {

        private List<Card> cards;

        public Deck()
        {
        
        }

        public List<Card> Cards { get => cards; set => cards = value; }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
        public void DestroyCard(int cardId)
        {
            cards.RemoveAt(cardId);
        }

        

        public void Shuffle()
        {
            Random random = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }
        public List<string> GetCharacteristics()
        {
            List<string> returner = new List<string>();
            int countM = 0;
            int countR = 0;
            int countLR = 0;
            int countB = 0;
            int countW = 0;
            int countAM = 0;
            int countAR = 0;
            int countALR = 0;
            int countTD = 0;
            CombatCard TC;


            returner.Add(Cards.Count.ToString());


            IEnumerable<Card> CardqueryM =
            from cardm in Cards
            where cardm.Type==EnumType.melee
            select cardm;
            foreach (Card i in CardqueryM)
            {
                countM += 1;
                
            }
            returner.Add(countM.ToString());
            IEnumerable<Card> CardqueryR =
            from cardr in Cards
            where cardr.Type == EnumType.range
            select cardr;
            foreach (Card y in CardqueryR)
            {
                countR += 1;

            }
            returner.Add(countR.ToString());
            IEnumerable<Card> CardqueryLR =
            from cardlr in Cards
            where cardlr.Type == EnumType.longRange
            select cardlr;
            foreach (Card t in CardqueryLR)
            {
                countLR += 1;

            }
            returner.Add(countLR.ToString());
            IEnumerable<Card> CardqueryB =
            from cardb in Cards
            where cardb.Type == EnumType.buff
            select cardb;
            foreach (Card s in CardqueryB)
            {
                countB += 1;

            }
            returner.Add(countB.ToString());
            IEnumerable<Card> CardqueryW =
            from cardw in Cards
            where cardw.Type == EnumType.weather
            select cardw;
            foreach (Card k in CardqueryW)
            {
                countW += 1;

            }
            returner.Add(countW.ToString());
            IEnumerable<Card> CardqueryAM =
            from cardam in Cards
            where cardam.Type == EnumType.melee
            select cardam;
            foreach (Card p in CardqueryAM)
            {
                TC = p as CombatCard;
                countAM += TC.AttackPoints;

            }
            returner.Add(countAM.ToString());
            IEnumerable<Card> CardqueryAR =
            from cardar in Cards
            where cardar.Type == EnumType.range
            select cardar;
            foreach (Card h in CardqueryAR)
            {
                TC = h as CombatCard;
                countAR += TC.AttackPoints;

            }
            returner.Add(countAR.ToString());
            IEnumerable<Card> CardqueryALR =
            from cardalr in Cards
            where cardalr.Type == EnumType.longRange
            select cardalr;
            foreach (Card C in CardqueryALR)
            {
                TC = C as CombatCard;
                countALR += TC.AttackPoints;

            }
            returner.Add(countALR.ToString());
            IEnumerable<Card> CardqueryTC =
            from cardtc in Cards
            where cardtc is CombatCard
            select cardtc;
            foreach (Card x in CardqueryTC)
            {
                TC = x as CombatCard;
                countTD += TC.AttackPoints;

            }
            returner.Add(countTD.ToString());
            return returner;





        }

    }
}
