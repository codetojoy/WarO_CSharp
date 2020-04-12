using NUnit.Framework;
using Strategy;
using System.Collections.Generic;

namespace Strategy.Tests
{
    [TestFixture]
    public class NearestCard_Tests
    {
        private IStrategy strategy;

        [SetUp]
        public void SetUp()
        {
            strategy = new NearestCard();
        }

        [Test]
        public void SelectCard_Basic()
        {
            int prizeCard = 18;
            List<int> hand = new List<int>();
            hand.Add(11);
            hand.Add(22);
            hand.Add(33);
            int maxCard = 40;

            // test
            var result = strategy.SelectCard(prizeCard, hand, maxCard);

            Assert.AreEqual(22, result);
        }

        [Test]
        public void SelectCard_LowBoundary()
        {
            int prizeCard = 1;
            List<int> hand = new List<int>();
            hand.Add(2);
            hand.Add(27);
            hand.Add(38);
            int maxCard = 40;

            // test
            var result = strategy.SelectCard(prizeCard, hand, maxCard);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void SelectCard_HighBoundary()
        {
            int maxCard = 40;
            int prizeCard = maxCard;
            List<int> hand = new List<int>();
            hand.Add(10);
            hand.Add(20);
            hand.Add(39);

            // test
            var result = strategy.SelectCard(prizeCard, hand, maxCard);

            Assert.AreEqual(39, result);
        }
    }
}
