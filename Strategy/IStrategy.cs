using System;
using System.Collections.Generic;

namespace Strategy
{
    public interface IStrategy
    {
       int SelectCard(int prizeCard, List<int> hand, int maxCard);
    }
}
