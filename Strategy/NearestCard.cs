using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    public class NearestCard : IStrategy
    {
       public int SelectCard(int prizeCard, List<int> hand, int maxCard) {
           return hand.Aggregate(maxCard * 10, (acc, card) => Math.Abs(card - prizeCard) < Math.Abs(acc - prizeCard) ? card : acc);
       }
    }
}
