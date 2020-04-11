﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    public class MaxCard : IStrategy
    {
       public int SelectCard(int prizeCard, List<int> hand, int maxCard) {
           return hand.Max(i => i);
       }
    }
}
