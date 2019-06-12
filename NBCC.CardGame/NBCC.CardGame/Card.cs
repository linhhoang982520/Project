using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBCC.CardGame
{
    public class Card
    {
        public Card(Suit newSuit, FaceValue newValue)
        {
            Suit = newSuit;
            FaceValue = newValue;
        }
        public Suit Suit { get; }
        public FaceValue FaceValue { get; }

    }
}
