using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBCC.CardGame
{
    public class Hand
    {
        private List<Card> cards = new List<Card>();

        public int Count { get { return cards.Count(); } }

        public Card this[int index]
        {
            get
            {
                return cards[index];
            }
        }

        public void AddCard (Card newCard)
        {
            if (ConstainCard(newCard))
            {
                throw new ConstraintException(newCard.FaceValue.ToString() + " of " + newCard.ToString() + " already exist in the Hands");
            }

            cards.Add(newCard);
        }

        private bool ConstainCard(Card cardToCheck)
        {
            bool result = cards.Where(c => c.FaceValue == cardToCheck.FaceValue && c.Suit == cardToCheck.Suit).Count() > 0;
            return result;
        }

        public void RemoveCard(Card theCard)
        {
            if (cards.Contains(theCard))
            {
                cards.Remove(theCard);
            }
            else
            {
                throw new ConstraintException("The card does not exist in the Hands");
            }
        }
        
        public void RemoveCard(int index)
        {
            if(index <= cards.Count - 1)
            {
                cards.RemoveAt(index);
            }
            else
            {
                throw new DataException("Index value exceeds the number of cards in the hand");
            }
        }

        public void RemoverCard(Suit theSuit, FaceValue theFaceValue)
        {
            foreach(Card card in cards)
            {
                if(card.Suit == theSuit && card.FaceValue == theFaceValue)
                {
                    cards.Remove(card);
                    return;
                }
            }
            throw new DataException(theFaceValue.ToString() + " of " + theSuit.ToString());
        }
    }
}
