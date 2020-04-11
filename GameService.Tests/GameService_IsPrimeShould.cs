using NUnit.Framework;
using Game.Services;

namespace Game.UnitTests.Services
{
    [TestFixture]
    public class GameService_IsPrimeShould
    {
        private GameService _gameService;

        [SetUp]
        public void SetUp()
        {
            _gameService = new GameService();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _gameService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
    }
}
