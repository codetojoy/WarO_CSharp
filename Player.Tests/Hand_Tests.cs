using NUnit.Framework;
using System;
using System.Collections.Generic;

using Player;

namespace Player.UnitTests
{
    [TestFixture]
    public class Hand_Tests
    {
        private Hand hand;

        [SetUp]
        public void SetUp()
        {
            List<int> cards = new List<int>();
            cards.Add(10);
            cards.Add(20);
            cards.Add(30);
            hand = new Hand(cards);
        }

        [Test]
        public void Select_Illegal()
        {
            // test
            var ex = Assert.Throws<ArgumentException>(() => hand.Select(5150));

            Assert.That(ex.Message, Is.EqualTo("illegal selection (Parameter 'card')"));
        }
    }
}
