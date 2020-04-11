using System;
using System.Collections.Generic;

namespace Game.Services
{
    public interface IStrategy
    {
       int selectCard(int prizeCard, List<int> hand, int maxCard);
    }
}
