using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBCC.CardGame
{
    public class Deck
    {
        private List<Card> deck = new List<Card>();

        public Hand DealHand(int number)
        {
            if (deck.Count == 0)
                throw new ConstraintException("There are no cards left in the deck");
            Hand hand = new Hand();

            int countTo = deck.Count >= number ? number : deck.Count;

            for(int handIndex = 0; handIndex < countTo; handIndex++)
            {
                hand.AddCard(deck[0]);
                deck.RemoveAt(0);
            }

            return hand;
        }

        public Deck()
        {
            MakeDeck();
        }

        public Card DrawOneCard()
        {
            Card topCard;

            if (deck.Count > 0)
            {
                //assign top card
                topCard = deck[0];

                //adjust your deck
                deck.RemoveAt(0);
            }
            else
                throw new ArgumentException("No more card in deck");

            return topCard;
        }

        private void MakeDeck()
        {
            //Load the deck with all cards 
            //There are 4 suits
            for(int pickASuit = 0; pickASuit <= 3; pickASuit++)
            {
                //13 persuits
                for(int pickAValue = 0; pickAValue <= 12; pickAValue++)
                {
                    Card newCard = new Card((Suit)pickASuit, (FaceValue)pickAValue);

                    deck.Add(newCard);
                }
            }
        }

        public void Shuffle()
        {
            Random rGen = new Random();
            List<Card> newDeck = new List<Card>();

            // while loop through our deck cards
            while(deck.Count > 0)
            {
                int removerIndex = rGen.Next(0, deck.Count);
                Card removeCard = deck[removerIndex];
                deck.RemoveAt(removerIndex);

                //Add newDeck
                newDeck.Add(removeCard);
            }

            deck = newDeck;
        }
    }
}
