using System;
using System.Collections.Generic;

namespace Player
{
    public class Hand
    {
        private readonly List<int> cards;

        public Hand() : this(new List<int>()) {}

        public Hand(List<int> cards)
        {
            this.cards = cards;
        }

        public Hand Select(int card)
        {
            Hand newHand = null;

            if (cards.Contains(card))
            {
            }
            else
            {
                throw new System.ArgumentException("illegal selection", "card");
            }

            return newHand;
        }
    }
}
